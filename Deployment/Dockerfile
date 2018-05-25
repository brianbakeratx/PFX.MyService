FROM microsoft/aspnetcore:2.0
WORKDIR /app
EXPOSE 80

COPY Build/output/service/publish .
ENTRYPOINT ["dotnet", "PFX.MyService.dll"]