# sistema-locacao-eauditoria
Projeto feito para a prova a técnica do processo seletivo da E-Auditoria.

dotnet ef migrations script
dotnet ef migrations add init
dotnet ef database update

caso o comando n funcione dotnet tool install --global dotnet-ef

mysql no docker
docker pull mysql

docker caso n funcione:
docker run --name repo alpine/git clone https://github.com/docker/getting-started.git
docker cp repo:/git/getting-started/ . 
cd getting-started   
docker build -t docker101tutorial .
docker run -d -p 80:80 --name docker-tutorial docker101tutorial
