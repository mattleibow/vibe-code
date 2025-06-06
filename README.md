# VibeCode

A .NET application built with C# and ready for cross-platform development.

## Overview

This project provides a foundation for building cross-platform applications using .NET 8.0. The project structure is prepared for future enhancement with .NET MAUI capabilities for mobile and desktop development.

## Project Structure

- `VibeCode/` - Main application project
- `VibeCode.Tests/` - Unit tests for the application
- `.github/workflows/` - GitHub Actions CI/CD pipeline

## Features

- .NET 8.0 console application
- Logging with Microsoft.Extensions.Logging
- Unit testing with xUnit
- GitHub Actions for automated build and test
- Ready for MAUI enhancement

## Building and Running

### Prerequisites

- .NET 8.0 SDK

### Commands

```bash
# Restore dependencies
dotnet restore

# Build the solution
dotnet build

# Run tests
dotnet test

# Run the application
dotnet run --project VibeCode/VibeCode.csproj
```

## Development

The project uses:
- C# with implicit usings and nullable reference types enabled
- Microsoft.Extensions.Logging for structured logging
- xUnit for unit testing

## Future Enhancements

This project is structured to support future MAUI development for:
- Android applications
- iOS applications  
- macOS applications via Mac Catalyst
- Windows applications

## CI/CD

The project includes a GitHub Actions workflow that:
- Builds the solution on Ubuntu
- Runs all unit tests
- Executes the application

## Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Add tests for new functionality
5. Ensure all tests pass
6. Submit a pull request