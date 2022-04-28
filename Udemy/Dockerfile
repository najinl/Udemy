FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Udemy/Udemy.csproj", "Udemy/"]
RUN dotnet restore "Udemy/Udemy.csproj"
COPY . .
WORKDIR "/src/Udemy"
RUN dotnet build "Udemy.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Udemy.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Udemy.dll"]
