jukeboxmvc: attempted to modernize, but does not run natively.
Use sibling rockstarmvc instead!

Native:
dotnet build
dotnet run

Dockerized:
docker build --pull -t dinonu/rockstarmvc10 .
docker build --platform linux/amd64 -t dinonu/rockstarmvc10amd64 .

Unfortunately, automated patform builds (file Dockerfile.bak) don't seem to work:
 => ERROR [build 6/6] RUN dotnet publish -a arm64 --no-restore -o /app                                               0.4s
------                                                                                                                    
 > [build 6/6] RUN dotnet publish -a arm64 --no-restore -o /app:                                                          
0.382 /usr/share/dotnet/sdk/10.0.100-preview.6.25274.104/Sdks/Microsoft.NET.Sdk/targets/Microsoft.NET.RuntimeIdentifierInference.targets(326,5): 
message NETSDK1057: You are using a preview version of .NET. See: https://aka.ms/dotnet-support-policy [/source/rockstarmvc.csproj]
0.424 /usr/share/dotnet/sdk/10.0.100-preview.6.25274.104/Sdks/Microsoft.NET.Sdk/targets/Microsoft.PackageDependencyResolution.targets(266,5): 
error NETSDK1047: Assets file '/source/obj/project.assets.json' doesn't have a target for 'net10.0/linux-arm64'. 
Ensure that restore has run and that you have included 'net10.0' in the TargetFrameworks for your project. 
You may also need to include 'linux-arm64' in your project's RuntimeIdentifiers. [/source/rockstarmvc.csproj]
------
Dockerfile:12
--------------------
  10 |     # Copy source code and publish app
  11 |     COPY --link rockstarmvc/. .
  12 | >>> RUN dotnet publish -a $TARGETARCH --no-restore -o /app
  13 |     
  14 |     
--------------------
ERROR: failed to solve: process "/bin/sh -c dotnet publish -a $TARGETARCH --no-restore -o /app" did not complete successfully: exit code: 1

Note: .NET 8+ container images use port `8080`, by default.

docker login
docker push dinonu/rockstarmvc10
docker push dinonu/rockstarmvc10amd64

test:
docker run --rm -it -p 8000:8080 -e ASPNETCORE_HTTP_PORTS=8080 dinonu/rockstarmvc10