1.) First Delete Migrations Folder
2.) Configure your docker container server from Microsoft SQL
3.) Configure your connection string in your appsettings.json file
4.) Then Perform a database migration inside of the PfProj folder by running the code: dotnet ef migrations add InitialMigration. Then update the database by running this in terminal: dotnet ef database update.
5.) Run the terminal command "dotnet run" inside PfProj
6.) Open the Class.html file in the folders
