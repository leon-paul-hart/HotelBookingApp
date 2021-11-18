#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["HotelBookingApp.API.Bookings/HotelBookingApp.API.Bookings.csproj", "HotelBookingApp.API.Bookings/"]
RUN dotnet restore "HotelBookingApp.API.Bookings/HotelBookingApp.API.Bookings.csproj"
COPY . .
WORKDIR "/src/HotelBookingApp.API.Bookings"
RUN dotnet build "HotelBookingApp.API.Bookings.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HotelBookingApp.API.Bookings.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HotelBookingApp.API.Bookings.dll"]