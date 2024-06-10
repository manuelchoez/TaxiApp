# Establece la imagen base
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

# Establece el directorio de trabajo
WORKDIR /app

EXPOSE 80
EXPOSE 5026

# Copia cada csproj y restaura las dependencias
COPY *.sln .
COPY TaxiApp.API/*.csproj ./TaxiApp.API/
COPY TaxiApp.Application/*.csproj ./TaxiApp.Application/
COPY TaxiApp.Model/*.csproj ./TaxiApp.Domain/
COPY TaxiApp.Infraestructure/*.csproj ./TaxiApp.Infraestructure/


RUN dotnet restore TaxiApp.API/TaxiApp.API.csproj

# Copia todo el resto y construye
COPY . .
WORKDIR /app/TaxiApp.API
RUN dotnet publish -c Release -o out

# Genera la imagen de tiempo de ejecución
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/TaxiApp.API/out .
ENTRYPOINT ["dotnet", "TaxiApp.API.dll"]
