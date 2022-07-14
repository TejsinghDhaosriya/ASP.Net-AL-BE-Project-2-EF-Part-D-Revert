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

### UnApplied Last migration from db
```
Run database update for migration before last(V3AddYearOfEnrollmentAndRemoveSectionCol) that is for V2SectionCol , by this last migration will be unapplied from db
dotnet ef database update V2SectionCol
```
### Remove last migration from code
```
 dotnet ef migrations remove

```
####  DOCKER-POSTGRES CONTAINER CREATE/UP
```
docker-compose up
```




## Note/Steps: For putting default value in db for new field-
```
Approach 1 :-
1. create a migration 
2. in migration add a default value in section field attribute(defaultValue: "NA") in UP function && add same default in StudentDbContextModelSnapshot in section field .HasDefaultValue("NA")
3. Reflect the migration.

Approach 2 :-
1. create a migration
2. in migration add a default value in section field attribute(defaultValue: "NA") &&  in next migration  where we removed section in up field .add same default value in down function where we are adding section.
3. Reflect the migration.



```