# ASP.Net-AL-BE-Project-2-EF-Part-B-Upgrade

####  CREATE MIGRATIONS
```
dotnet ef migrations add V2SectionCol --project Student-API.csproj
```


#### List Unapplied Migrations
```
 dotnet ef migrations  list --project Student-API.csproj
```
#### Reflect Migrations in Db
```
dotnet ef database update V2SectionCol --project Student-API.csproj
``` 
```
For default value approved used is- manually added default value in migration V2SectionCol
```


####  DOCKER-POSTGRES CONTAINER CREATE/UP
```
docker-compose up
```
