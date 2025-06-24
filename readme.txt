To run with plain docker:
On Mac:
docker run --rm -it -p 8010:8080 -e ASPNETCORE_HTTP_PORTS=8080 dinonu/rockstarapi10
docker run --rm -it -p 8011:8081 -e ASPNETCORE_HTTP_PORTS=8081 dinonu/rockstarmvc10
On Windows:
docker run --rm -it -p 8010:8080 -e ASPNETCORE_HTTP_PORTS=8080 tarunsankhla/rockstarapi10amd64
docker run --rm -it -p 8011:8081 -e ASPNETCORE_HTTP_PORTS=8081 taeunsankhla/rockstarmvc10amd64

Then, open browser at http://localhost:8011/RockStar/Faith?api=http://localhost:8010/rockstar/faith
click Get Lyrics button

git clone https://github.com/dinorows/rockstar.git
// create reppo on github
git remote add origin https://github.com/tarunsankhla/rockstar.git
git push -u origin main

cd rockstar
docker-compose build
docker-compose up

aws ecr create-repository --repository-name rockstar/api --region us-east-1   
public.ecr.aws/g7w0b5t7/rockstar/api
734862070647.dkr.ecr.us-east-1.amazonaws.com/rockstar/api
734862070647.dkr.ecr.us-east-1.amazonaws.com/rockstar/webapp


docker build -f jukeboxapi/Dockerfile -t 734862070647.dkr.ecr.us-east-1.amazonaws.com/rockstar/api:dev ./jukeboxapi
docker build -f jukeboxmvc/Dockerfile -t 734862070647.dkr.ecr.us-east-1.amazonaws.com/rockstar/webapp:dev ./jukeboxmvc

aws ecr get-login-password --region us-east-1 | docker login --username AWS --password-stdin 734862070647.dkr.ecr.us-east-1.amazonaws.com


docker push 734862070647.dkr.ecr.us-east-1.amazonaws.com/rockstar/api:dev
docker push 734862070647.dkr.ecr.us-east-1.amazonaws.com/rockstar/webapp:dev
