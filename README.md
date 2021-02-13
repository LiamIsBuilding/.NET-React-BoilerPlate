# Custom .NET React Boiler Plate

## Installation

Feel free to Git Clone this boilerplate and use it for whatever. You may need to run npm install or dotnet restore to grab the needed packages but go wild! I mainly made this to save myself time when making new ASP.NET React projects

## The Process

first i will create a new .NET project with the React frontend. This boilerplate is great but we can add some extras.

```
dotnet new react
```

<br/>

## Files Added

### IRepository - Interface to ensure Repo includes all needed Func

### RepositoryClass - Run our sql querys using Dapper

### BaseRepository - set up Npgsql connection + use env var to link hosted DB

### table.sql - simple sql file

<br/>

## Packages Added

### Dapper - [A high performance Micro-ORM supporting SQL Server, MySQL, Sqlite, SqlCE, Firebird etc..](https://www.nuget.org/packages/Dapper/)

### Npgsql - [Npgsql is the open source .NET data provider for PostgreSQL.](https://www.nuget.org/packages/Npgsql)
