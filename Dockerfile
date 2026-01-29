# 1. Build Stage: Isme hum code compile karenge
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Project file copy karke dependencies restore karenge
COPY ["TaskManagerApp.csproj", "./"]
RUN dotnet restore

# Baaki sara code copy karke publish karenge
COPY . .
RUN dotnet publish -c Release -o /app/publish

# 2. Runtime Stage: Isme sirf final app chalegi (Lightweight)
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .

# App port 80 par chalegi
EXPOSE 80
ENTRYPOINT ["dotnet", "TaskManagerApp.dll"]
