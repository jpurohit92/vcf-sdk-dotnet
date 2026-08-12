# Step 1: Build stage using .NET 8 SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy project files and restore dependencies
COPY ["vcf-sdk-dotnet.csproj", "./"]
COPY ["InternalOpenApi/", "InternalOpenApi/"]
COPY ["InternalViJson/", "InternalViJson/"]
RUN dotnet restore "vcf-sdk-dotnet.csproj"

# Copy remaining source code
COPY . .

# Pass WarningLevel=0 to prevent warnings from failing publish
RUN dotnet publish "vcf-sdk-dotnet.csproj" -c Release -o /app/publish /p:UseAppHost=false /p:WarningLevel=0 /clp:ErrorsOnly

# Step 2: Final runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "vcf-sdk-dotnet.dll"]