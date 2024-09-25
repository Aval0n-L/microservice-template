# Introduction
This project was created using the Microservice Template Application (`avalonmicroservice`).

To use this template, execute:  
    dotnet new avalonmicroservice --service-name <your-service-name>  

# Getting Started
1.	Implement logic  
2.	Use \*.Tests project to create there unit and narrow integration tests  
3.  Don't forget to update `appsettings.json`  
4.  Don't put secrets in `appsettings.json`  
5.  Describe you microservice in README  

# Project structure:
MicroserviceTemplate/  
├── Dockerfile  
├── src/  
│   └── MicroserviceTemplate/  
│       ├── MicroserviceTemplate.csproj  
│       └── (other project files)  
└── test/  
    └── MicroserviceTemplate.Tests/  
        ├── MicroserviceTemplate.Tests.csproj  
        └── (other test project files)  


# Docker  
## Build  
-t my-template-service:latest — tag (name) for Docker image.  
. — Docker specifies that the context build is in the current directory (where the Dockerfile is located).  

docker build -t my-template-service:latest .  


## Run  
-d — runs a container in the background.  
-p 5000:80 — forwards port 80 inside the container to port 5000 on your machine. You can configure the ports as you wish.  
--name my-template-service — specifies a name for the container.  
  template-service:latest — the name and tag of the Docker image you created in the previous step.  

docker run -d -p 5000:8080 --name template-container my-template-service:latest


## Check 
docker ps  
curl http://localhost:5000/api/ping  

## Logs
docker logs my-template-service  


## Stop and Delete
docker stop template-container  
docker rm template-container  

## Remove Image
docker rmi my-template-service:latest  

# Install curl inside a container
 
1. Go inside the container and run  
        docker exec -it template-container /bin/bash  
2. Install curl  
        apt-get update  
        apt-get install -y curl  
3. Check    
        curl http://localhost:8080/api/ping  
