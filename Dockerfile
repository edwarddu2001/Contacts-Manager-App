#Docker load instructions
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out


FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
COPY --from=build-env /app/out .


EXPOSE 5100/tcp

ENV WEBSITE_SITE_NAME ContactsManagerApp

ENTRYPOINT ["dotnet", "BrazorwasmDotNetCoreHostedWithDocker.Server.dll"]