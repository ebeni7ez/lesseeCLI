FROM microsoft/dotnet:2.1-sdk AS builder
WORKDIR /source
COPY *.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish --output /app/ --configuration Release
FROM microsoft/dotnet:2.1-aspnetcore-runtime-alpine
WORKDIR /app
ENV ASPNETCORE_ENVIRONMENT Development
EXPOSE 80
RUN ls  
COPY --from=builder /app . 
ENTRYPOINT ["dotnet", "LesseeClient.dll"]
