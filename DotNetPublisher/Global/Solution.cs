using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace DotNetPublisher.Global {
    class Project {
        static readonly Dictionary<Runtime, string> RUNTIME = new Dictionary<Runtime, string>{
            [Runtime.Windows] = "win-x64",
            [Runtime.Linux] = "linux-x64",
            [Runtime.OSX] = "osx-x64"
        };

        public string Name { get; set; }
        public string SolutionName { get; set; }
        public string SolutionPath { get; set; }
        public string ProjectPath { get; set; }
        public bool IsSelfContained { get; set; } = false;
        public Runtime Runtime { get; set; } = Runtime.Windows;
        public Configuration Configuration { get; set; } = Configuration.Debug;
        public bool ForceResolvePackages { get; set; } = false;
        public List<Parameter> Parameters { get; set; } = new List<Parameter>();

        [JsonIgnore]
        public bool IsSolutionSetup {
            get => File.Exists(SolutionPath);
        }
        [JsonIgnore]
        public bool IsProjectSetup {
            get => IsSolutionSetup && File.Exists(FullPath);
        }
        public string FullPath {
            get => Path.Join(Path.Join(Path.GetDirectoryName(SolutionPath), ProjectPath));
        }
        public string Command {
            get {
                var sb = new StringBuilder();
                sb.Append($"publish \"{FullPath}\"");
                sb.Append($" --configuration {Configuration}");
                sb.Append($" --output \"build\\{SolutionName} {Name}\"");

                if (IsSelfContained) {
                    sb.Append($" --self-contained --runtime {RUNTIME[Runtime]}");
                }

                if (ForceResolvePackages) {
                    sb.Append(" --force");
                }

                foreach (var param in Parameters) {
                    sb.Append($" /p:{param.Key}={param.Value}");
                }

                return sb.ToString();
            }
        }
        public IEnumerable<string> ProjectsInSolution {
            get {
                return File.ReadAllLines(SolutionPath)
                    .Where(line => line.StartsWith("Project("))
                    .Select(line => {
                        var items = line.Split(" = ");
                        items = items[1].Split(", ");
                        return items[1].Trim('"');
                });
            }
        }
    }

    class Parameter {
        public string Key { get; set; }
        public string Value { get; set; }

        public Parameter (string key, string value) {
            Key = key;
            Value = value;
        }
    }

    enum Configuration {
        Debug,
        Release
    }

    enum Runtime {
        Windows,
        Linux,
        OSX
    }
}
