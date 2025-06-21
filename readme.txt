To run with plain docker:
On Mac:
docker run --rm -it -p 8010:8080 -e ASPNETCORE_HTTP_PORTS=8080 dinonu/rockstarapi10
docker run --rm -it -p 8011:8081 -e ASPNETCORE_HTTP_PORTS=8081 dinonu/rockstarmvc10
On Windows:
docker run --rm -it -p 8010:8080 -e ASPNETCORE_HTTP_PORTS=8080 dinonu/rockstarapi10amd64
docker run --rm -it -p 8011:8081 -e ASPNETCORE_HTTP_PORTS=8081 dinonu/rockstarmvc10amd64

Then, open browser at http://localhost:8011/RockStar/Faith?api=http://localhost:8010/rockstar/faith
click Get Lyrics button
