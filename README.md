# Microservice framework comparison

This repository contains implementations of an identical trivial webservice in different runtimes and frameworks. The goal is to compare the performance and resource usage of the different frameworks.

## Goals

I want to measure

- Throughput
- Latency
- Memory usage
  - How much of a pod's resident set size is used by the framework itself, and how much is used by the application code
  - How much of the memory used for the framework can be shared between pods

## Implementations

Language | Runtime | Framework | Notes
--- | --- | --- | ---
C# | .NET | ASP.NET Core | -
C# | .NET (AOT) | ASP.NET Core | -
Go | Go | - | -
Java | GraalVM | Spring Boot | -
Java | JVM | Spring Boot | -
PHP | PHP | - | -
Python | Python | FastAPI | -
Rust | Rust | Axum | -
Typescript | Bun | - | -
Typescript | node.js | Express | -

## Specification

### Endpoints

#### `GET /`

Returns a JSON object containing an ISO 8601 timestamp of the current time in UTC.

```json
{
  "timestamp": "2026-07-24T17:12:34Z"
}
```

#### `GET /health`

Returns 200 OK if the service is running.

#### `GET /ready`

Returns 200 OK when the service is ready to serve traffic.
