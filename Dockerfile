FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

WORKDIR /src

COPY StringApp/StringApp.csproj StringApp/
COPY stylecop.json ./

RUN dotnet restore StringApp/StringApp.csproj

COPY StringApp/. StringApp/

RUN dotnet publish StringApp/StringApp.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/runtime:9.0
WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "StringApp.dll"]
