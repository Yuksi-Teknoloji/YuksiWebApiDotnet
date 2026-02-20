ARG DOTNET_VERSION=10.0
ARG PROJECT=./Yuksi/Yuksi.csproj
ARG APP_DLL=Yuksi.dll

FROM mcr.microsoft.com/dotnet/sdk:${DOTNET_VERSION} AS build
WORKDIR /src
COPY . .
RUN dotnet restore "$PROJECT"
RUN dotnet publish "$PROJECT" -c Release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:${DOTNET_VERSION} AS runtime
WORKDIR /app
COPY --from=build /app .

ENV ASPNETCORE_URLS=http://+:80
EXPOSE 80
ENV APP_DLL=${APP_DLL}
ENTRYPOINT ["sh", "-c", "dotnet $APP_DLL"]
