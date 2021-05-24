dotnet pack -c Release -p:PackageVersion=%1
dotnet nuget push .\bin\Release\Mcma.Modules.Templates.%1.nupkg -k %NUGET_API_KEY%
echo %1 > version