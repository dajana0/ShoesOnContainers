FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /code

# Copy csproj and restore as distinct layers
WORKDIR /code

COPY . .

RUN dotnet restore

RUN dotnet publish --output /out/ --configuration Release 

# Build runtime image
FROM microsoft/dotnet:2.1-aspnetcore-runtime

COPY --from=build /out /app/

WORKDIR  /app

ENTRYPOINT ["dotnet", "ProductCatalogAPI.dll"]