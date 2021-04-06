# AndcultureCode.CSharp.Data.PostgreSQL
Infrastructure layer's PostgreSQL specific package.

## Getting Started
This package is installed via NuGet
```
dotnet add [<PROJECT>] package AndcultureCode.CSharp.Data.PostgreSQL
```

## Documentation

[Full API Documentation](src/AndcultureCode.CSharp.Data.PostgreSQL/AndcultureCode.CSharp.Data.PostgreSQL.md)


## Development Setup

* Install Dotnet Core 2.x
* Install the `and-cli` tooling found at [AndcultureCode.Cli](https://github.com/AndcultureCode/AndcultureCode.Cli)

Below are a few basics to get you started, but there are many more commands and options for managing this and other projects found in the `and-cli`.

### Building project
* Run the build command
    ```
    and-cli dotnet --build
    ```

### Running tests along with code coverage
* Run the test command
    ```
    and-cli dotnet-test
    ```
* Open the `coverage/index.htm` file in your browser

### Publishing a new version
* Run the publish command with the next version number ([See semver package versioning](https://docs.microsoft.com/en-us/nuget/concepts/package-versioning))
    ```
    and-cli nuget --publish <version>
    ```

Contributing
======

Information on contributing to this repo is in the [Contributing Guide](CONTRIBUTING.md)
