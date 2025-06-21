# This Dockerfile is for rockstarapi folder
FROM mcr.microsoft.com/dotnet/nightly/sdk:10.0-preview AS build
WORKDIR /source

# Copy project file and restore as distinct layers
COPY --link rockstarapi/*.csproj .
RUN dotnet restore

# Copy source code and publish app
COPY --link rockstarapi/. .
RUN dotnet publish --no-restore -o /app


# Runtime stage
FROM mcr.microsoft.com/dotnet/nightly/aspnet:10.0-preview
EXPOSE 8080
WORKDIR /app
COPY --link --from=build /app .
COPY rockstarapi/faith.txt .
COPY rockstarapi/rocketman.txt .
USER $APP_UID
ENTRYPOINT ["./rockstarwebapi"]
