FROM microsoft/dotnet:sdk AS build-env
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

FROM microsoft/dotnet:aspnetcore-runtime
WORKDIR /app
ARG PROJETO=TESTE
ENV PROJETO=${PROJETO}
COPY --from=build-env /app/out .
COPY entry.sh .
ENTRYPOINT ./entry.sh