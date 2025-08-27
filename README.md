# StringApp  

A sample **.NET 9** application with unit tests, linting, code coverage, Docker support, and GitHub Actions CI/CD.  

---

## Prerequisites  

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)  
- [Docker](https://docs.docker.com/get-docker/) (optional, for containerized runs)  
- [ReportGenerator](https://github.com/danielpalme/ReportGenerator) (for coverage reports)  

---

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