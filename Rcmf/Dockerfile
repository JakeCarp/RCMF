FROM mcr.microsoft.com/dotnet/sdk:6.0 AS base
WORKDIR /app
EXPOSE 80/tcp

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Rcmf.csproj", "./"]
RUN dotnet restore "Rcmf.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Rcmf.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Rcmf.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Rcmf.dll"]
