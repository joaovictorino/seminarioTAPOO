#!/bin/bash

dotnet new webapp -o $1 --force

cp Dockerfile $1
cp docker-compose.yaml $1
cp entry.sh $1
cp -rf codigo/* $1

cd $1

export PROJETO=$1

dotnet add package MongoDb.Driver

docker-compose up --build -d