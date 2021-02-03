#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Presentation/YK.Item.API/YK.Item.API.csproj", "Presentation/YK.Item.API/"]
RUN dotnet restore "Presentation/YK.Item.API/YK.Item.API.csproj"
COPY . .
WORKDIR "/src/Presentation/YK.Item.API"
RUN dotnet build "YK.Item.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "YK.Item.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "YK.Item.API.dll"]