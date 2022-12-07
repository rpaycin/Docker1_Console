FROM mcr.microsoft.com/dotnet/core/runtime:3.0-buster-slim
WORKDIR /app
COPY /bin/Release/netcoreapp3.0/publish /app
ENTRYPOINT ["dotnet", "WorkAtDocker.dll"]