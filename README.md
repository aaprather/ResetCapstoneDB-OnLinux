# ResetCapstoneDB-OnLinux
.NET Core version of service that resets the live demo database of my senior capstone 'Badge Request' project.
--------------------------------
NuGet packages required:
------

-Microsoft.NETCore.App v2.1.0
-
-System.Data.SqlClient v4.6.0
--------------------------------


--------------------------------------------------------------------------------------------------------------

Generate Linux executable by running 'dotnet publish -c release -r linux-x64' inside Visual Studio console.

Executable path:

-'\ResetCapstoneDB-OnLinux\bin\Release\netcoreapp2.1\linux-x64\publish\ResetCapstoneDB-OnLinux.dll'

--------------------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------

Instructions for running application on Linux Mint 19.1:

-Install dotnet runtime: https://dotnet.microsoft.com/download?initial-os=linux

-Place 'linux-x64' folder in an accessible directory

-Open terminal and 'cd' to the '/linux-x64/publish/'directory

-Execute 'dotnet ResetCapstoneDB-OnLinux.dll'

![ScreenShot](https://github.com/aaprather/ResetCapstoneDB-OnLinux/blob/master/screenshot.png)

![ScreenShot](https://github.com/aaprather/ResetCapstoneDB-OnLinux/blob/master/screenshot2.png)
-------------------------------------------------------------------------------

Currently I have this service being run at system start-up via shell script
