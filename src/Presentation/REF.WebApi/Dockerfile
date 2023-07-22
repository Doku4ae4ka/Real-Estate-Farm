FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Presentation/REF.WebApi/REF.WebApi.csproj", "REF.WebApi/"]
RUN dotnet restore "src/Presentation/REF.WebApi/REF.WebApi.csproj"
COPY . .
WORKDIR "/src/REF.WebApi"
RUN dotnet build "REF.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "REF.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "REF.WebApi.dll"]
