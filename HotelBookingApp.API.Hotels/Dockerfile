#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["HotelBookingApp.API.Hotels/HotelBookingApp.API.Hotels.csproj", "HotelBookingApp.API.Hotels/"]
RUN dotnet restore "HotelBookingApp.API.Hotels/HotelBookingApp.API.Hotels.csproj"
COPY . .
WORKDIR "/src/HotelBookingApp.API.Hotels"
RUN dotnet build "HotelBookingApp.API.Hotels.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HotelBookingApp.API.Hotels.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HotelBookingApp.API.Hotels.dll"]
