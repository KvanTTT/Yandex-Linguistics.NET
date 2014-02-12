@cd YandexLinguistics.NET
..\.nuget\nuget.exe pack YandexLinguistics.NET.csproj -Version 1.1 -Prop Configuration=Release -OutputDirectory bin
..\.nuget\nuget.exe push bin\YandexLinguistics.NET.1.1.nupkg -ApiKey
@pause
