# modrx-backend
Backend for modrx

## Running locally for the first time
1.) Run postgresql database locally with `docker-compose up`

2.) Login into pgadmin and connect to the db, default user: `modrxdev`, default pass: `localhost`

3.) Run `dotnet restore` to ensure all dependencies are restored

4.) Run initial migration with `dotnet ef database update InitialMigration`

5.) Run in watch mode `dotnet watch run`, starts server on port 5000
