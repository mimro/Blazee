#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Blazee/Server/Blazee.Server.csproj", "Blazee/Server/"]
COPY ["Blazee/Client/Blazee.Client.csproj", "Blazee/Client/"]
COPY ["Blazee/Shared/Blazee.Shared.csproj", "Blazee/Shared/"]
RUN dotnet restore "Blazee/Server/Blazee.Server.csproj"
COPY . .
WORKDIR "/src/Blazee/Server"
RUN dotnet build "Blazee.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Blazee.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Blazee.Server.dll"]