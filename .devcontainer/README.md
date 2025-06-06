# Development Container for GitHub Copilot

This directory contains the development container configuration that provides a pre-configured environment for GitHub Copilot to work with the .NET MAUI project.

## Purpose

This devcontainer configuration addresses the firewall access issues mentioned in PR #7 by providing a complete, pre-configured development environment that:

- **Bypasses firewall restrictions**: All necessary tools are pre-installed in the container
- **Provides consistent environment**: Every developer and Copilot gets the same setup
- **Enables full .NET MAUI development**: Includes all required SDKs and workloads
- **Supports GitHub Codespaces**: Works seamlessly in cloud development environments

## What's Included

### Base Environment
- **Container Image**: `mcr.microsoft.com/devcontainers/dotnet:1-9.0-bookworm`
- **User**: `vscode` (non-root for security)
- **.NET Version**: 9.0.x SDK with all required components

### Development Tools
- **MAUI Android Workload**: Pre-installed for cross-platform development  
- **GitHub CLI**: For repository interactions
- **VS Code Extensions**: 
  - C# extension for IntelliSense and debugging
  - .NET MAUI extension for mobile development
  - .NET runtime extension for optimal performance

### Project Setup
- **Automatic dependency restore**: Project packages are restored on container creation
- **Build verification**: Ensures the project builds successfully 
- **Environment validation**: Confirms all tools are working correctly

## Usage

### With GitHub Codespaces
1. Open the repository in GitHub
2. Click **Code** → **Codespaces** → **Create codespace on [branch]**
3. The devcontainer will automatically build and configure the environment
4. GitHub Copilot will have access to a fully configured .NET MAUI development environment

### With VS Code Dev Containers
1. Install the **Dev Containers** extension in VS Code
2. Open the repository in VS Code
3. Press `Ctrl+Shift+P` (or `Cmd+Shift+P` on Mac)
4. Run **Dev Containers: Reopen in Container**
5. The container will build and configure automatically

### With Docker CLI
```bash
# Build and run the development container
docker build -f .devcontainer/Dockerfile -t vibe-code-dev .
docker run -it --rm -v $(pwd):/workspace vibe-code-dev
```

## Configuration Files

- **`devcontainer.json`**: Main configuration defining the container, extensions, and settings
- **`setup.sh`**: Post-creation script that installs MAUI workloads and restores dependencies
- **`README.md`**: This documentation file

## Benefits for GitHub Copilot

1. **Pre-configured Environment**: Copilot immediately has access to all .NET MAUI tools
2. **No Network Dependencies**: All required components are pre-installed
3. **Consistent Context**: Every session provides the same development environment
4. **Enhanced Code Suggestions**: Copilot can provide better suggestions with full tool access
5. **Faster Development**: No time wasted on environment setup

## Troubleshooting

### Container Build Issues
- Ensure Docker is running and has sufficient resources
- Check internet connectivity for downloading the base image
- Verify `.devcontainer/devcontainer.json` syntax is valid

### MAUI Workload Issues  
- The setup script includes `--skip-sign-check` to handle certificate issues
- If workload installation fails, try rebuilding the container
- Check the container logs for specific error messages

### Project Build Issues
- Ensure `VibeCodeApp/VibeCodeApp.csproj` exists and is valid
- Check for any missing NuGet package sources
- Verify .NET 9.0 compatibility of project dependencies

## Related Issues

- **Addresses PR #7**: Resolves firewall access issues to Microsoft domains
- **Enables Copilot**: Provides the pre-configured environment Copilot needs
- **Standard Practice**: Follows GitHub's recommended approach for development environment customization