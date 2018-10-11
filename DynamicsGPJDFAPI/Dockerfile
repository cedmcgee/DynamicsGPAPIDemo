#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/aspnetcore:1.1 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:1.1 AS build
WORKDIR /src
COPY ["DynamicsGPJDFAPI/DynamicsGPJDFAPI.csproj", "DynamicsGPJDFAPI/"]
RUN dotnet restore "DynamicsGPJDFAPI/DynamicsGPJDFAPI.csproj"
COPY . .
WORKDIR "/src/DynamicsGPJDFAPI"
RUN dotnet build "DynamicsGPJDFAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "DynamicsGPJDFAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DynamicsGPJDFAPI.dll"]