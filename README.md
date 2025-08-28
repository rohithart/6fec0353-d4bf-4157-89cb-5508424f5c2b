# StringApp  

A sample **.NET 9** application with unit tests, linting, code coverage, Docker support, and GitHub Actions CI/CD.  


## Prerequisites  

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)  
- [Docker](https://docs.docker.com/get-docker/) (optional, for containerized runs)  
- [ReportGenerator](https://github.com/danielpalme/ReportGenerator) (for coverage reports)  


## Assumptions
- Used .NET Version 9 and has created a Console App.
- Program returns the longest non-breaking sequence.
- Manual DI was used as this is a simple console app.
- GH action requires an approval for Publishing (I am the only approver for now).
- Multiple Unit test patters are used (even-though it shows inconsistency) to showcase knowledge.
- Dockerfile is included to showcase knowledge and is not being used for deployment.
- Currently, the deployment is uploading the complied binaries as artifact.

## Running Locally  

### Restore dependencies  
```bash
dotnet restore StringApp.sln
```

### Build the application
```bash
dotnet build StringApp.sln
```

### Run the application
```bash
dotnet run --project StringApp/StringApp.csproj
```

## Running Tests
### Run unit tests
```bash
dotnet test StringApp.Tests/StringApp.Tests.csproj
```

### Run with coverage

```bash
dotnet test StringApp.Tests/StringApp.Tests.csproj \
  --no-build \
  --collect:"XPlat Code Coverage"

dotnet tool run reportgenerator -reports:coverage/coverage.cobertura.xml \
                -targetdir:coverage-report \
                -reporttypes:Html
```

Open coverage/index.html in your browser

## Linting & Formatting

Install the dotnet-format tool if not already installed:

```bash
dotnet tool install -g dotnet-format
```

### Run lint/format check:
```bash
dotnet format StringApp.sln --verify-no-changes
```

### Apply formatting fixes:
```bash
dotnet format StringApp.sln
```

## Running with Docker
Build Docker image
```bash
docker build -t stringapp .
```

Run container
```bash
docker run -it --rm stringapp
```

The app will run in the console.

## CI/CD
GitHub action workflow is in place to implement CI/CD.
The approval stage, creates a GitHub issue, which has to be responded with a `Yes` or `No` to progress enable publishing. This acts as a gate to avoid accidental publish.
Currently I am the only approver.

##  Useful Commands

### Clean build artifacts:
```bash
dotnet clean
```

### Restore dependencies:
```bash
dotnet restore
```

### Run all from scratch:
```bash
dotnet restore
dotnet build
dotnet test
```