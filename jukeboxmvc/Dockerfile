# This Dockerfile is for rockstarmvc folder
FROM mcr.microsoft.com/dotnet/nightly/sdk:10.0-preview AS build
WORKDIR /source

# Copy project file and restore as distinct layers
COPY --link rockstarmvc/*.csproj .
RUN dotnet restore

# Copy source code and publish app
COPY --link rockstarmvc/. .
RUN dotnet publish --no-restore -o /app


# Runtime stage
FROM mcr.microsoft.com/dotnet/nightly/aspnet:10.0-preview
EXPOSE 8080
WORKDIR /app
COPY --link --from=build /app .
USER $APP_UID
ENTRYPOINT ["./rockstarmvc"]
