#!/bin/bash

dotnet new webapp -o $1

cp Dockerfile $1
#sed -i s/PROJETO/$1/g $1/Dockerfile
cp entry.sh $1

cd $1

docker build --build-arg PROJETO=$1 -t $1 .

docker run -it --rm -e PROJETO=$1 -p 5000:80 --name $1_sample $1