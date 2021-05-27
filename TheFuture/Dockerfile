FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ConsoleApp15/ConsoleApp15.csproj", "ConsoleApp15/"]
RUN dotnet restore "ConsoleApp15/ConsoleApp15.csproj"
COPY . .
WORKDIR "/src/ConsoleApp15"
RUN dotnet build "ConsoleApp15.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ConsoleApp15.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConsoleApp15.dll"]
