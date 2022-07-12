# ASP.Net-AL-BE-Project-2-EF-Part-A-Initial
####  CREATE MIGRATIONS
```
dotnet ef migrations add MigrationV1 --project Student-API.csproj

```


#### List Unapplied Migrations
```
 dotnet ef migrations  list --project Student-API.csproj

```
#### Reflect Migrations in Db
```
dotnet ef database update MigrationV1 --project Student-API.csproj

``` 



####  DOCKER-POSTGRES CONTAINER CREATE/UP
```
docker-compose up
```
