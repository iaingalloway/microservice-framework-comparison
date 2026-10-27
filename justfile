alias b := build
alias f := format

default: check

# Build the project
build:
  docker build -f src/csharp-aspnetcore/Dockerfile -t csharp-aspnetcore:local .
  docker build -f src/csharp-aspnetcore/Dockerfile.aot -t csharp-aspnetcore-aot:local .

check: build

# Format the project
format:
  dotnet format src/csharp-aspnetcore/Service

up:

down:
