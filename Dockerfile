FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . .
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app/out .

# Run the app on container startup
# Use your project name for the second parameter
# e.g. MyProject.dll
# For runnig application on localhost 
ENTRYPOINT [ "dotnet", "contentstack-dotnet-starter-app.dll" ]
# Comment ENTRYPOINT and uncomment below line for deploying on heroku or azure and 
# CMD ASPNETCORE_URLS=http://*:$PORT dotnet contentstack-dotnet-starter-app.dll
