# .NET Publishers

Have you ever wanted to test a publish package without committing to git and go through CI/CD pipelines, but can't be bothered to manually run the publish command? Well, at least I have, then this is the answer.

This project simply enables that. You can choose a solution, then the project within the solution to build to, and customize the available parameters. Those projects and parameters will be saved as presets to a JSON file inside the root folder. You can choose to build it individually or in batch.

Currently, only .NET Core projects are supported.

![Main Form](/imgs/main_form.jpg "Main Form")

## License

[MIT](LICENSE) &copy; 2021 mcmudafi
