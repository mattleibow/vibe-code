# Copilot Setup Steps Workflow

This workflow helps prepare the development environment for GitHub Copilot to work correctly with the .NET MAUI project.

## Purpose

The workflow addresses firewall access issues mentioned in PR #7, where Copilot encountered blocked access to Microsoft domains (like `aka.ms`) during environment setup. By running this workflow, the necessary development tools are installed before firewall restrictions are applied.

## What it does

1. **Sets up .NET 9.0 SDK** - Installs the required .NET version for the project
2. **Installs MAUI Android workload** - Adds cross-platform mobile development capabilities
3. **Caches NuGet packages** - Improves performance for subsequent builds
4. **Restores project dependencies** - Downloads and prepares all required packages
5. **Verifies build capability** - Ensures the project can be built successfully

## Usage

### Manual Execution
1. Go to **Actions** tab in the GitHub repository
2. Select **Copilot Setup Steps** workflow
3. Click **Run workflow** button
4. Choose the branch (usually `main`)
5. Click **Run workflow**

### Automatic Execution
- Runs automatically every Sunday at midnight UTC to keep the environment fresh
- Can be triggered by other workflows if needed

## Benefits for Copilot

- **Pre-configured environment**: Copilot can work with an already prepared development setup
- **Bypasses firewall restrictions**: Setup happens before network restrictions are applied
- **Verified working state**: The workflow ensures all components are properly installed and functional
- **Consistent environment**: Every run creates the same development environment state

## Technical Details

- **Platform**: Ubuntu Latest (Linux)
- **Tools**: .NET 9.0 SDK, MAUI Android workload
- **Caching**: NuGet packages are cached for performance
- **Verification**: Each step includes verification to ensure proper installation

## Troubleshooting

If the workflow fails:
1. Check the Actions logs for specific error messages
2. Verify that the .NET 9.0 SDK version is available
3. Ensure the project file (`VibeCodeApp.csproj`) is valid
4. Check if there are any NuGet package conflicts

## Related Issues

- Addresses issues mentioned in PR #7 regarding firewall access to Microsoft domains
- Resolves setup problems that prevent Copilot from properly configuring the development environment