
# - ResetCapstoneDB-OnLinux -
This application is a .NET Core service that was used to reset the live demo database for the *Spring 2018* [Badge Request System](https://github.com/BadgeRequestSystem/SRSWebApp) Senior Project.

## NuGet Packages
- Microsoft.NETCore.App v2.10

- System.Data.SqlClient v4.6.0

## How To Build

**Inside the Visual Studio console, generate the Linux executable:**

    'dotnet publish -c release -r linux-x64' 

**Executable path:**

    \ResetCapstoneDB-OnLinux\bin\Release\netcoreapp2.1\linux-x64\publish\ResetCapstoneDBOnLinux.dll

## Instructions

For running application on [Linux Mint 19.1](https://linuxmint.com/release.php?id=34):

-Install [.NET Core Runtime](https://dotnet.microsoft.com/download?initial-os=linux)

-Place 'linux-x64' folder in an accessible directory

-Open terminal and locate directory -  `/linux-x64/publish/` 

-Execute `dotnet ResetCapstoneDB-OnLinux.dll`

![ScreenShot](https://raw.githubusercontent.com/aaprather/ResetCapstoneDB-OnLinux/master/screenshot.png)
## Additional Notes

Historically this application was ran at system start-up via shell script.
