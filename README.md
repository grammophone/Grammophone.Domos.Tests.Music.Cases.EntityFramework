# Grammophone.Domos.Tests.Music.Cases.EntityFramework

Entity Framework 6 MSTest project for the Domos music test application.

This project runs the shared music test cases against the EF6 provider, using LocalDB and Unity configuration from `App.config`.

## Target Framework

- `net472`

## Required Projects

This project expects these sibling projects to be available when building from the solution or from extracted submodules:

Direct project references:

- `Grammophone.Domos.Tests.Music.Cases`
- `Grammophone.Domos.Tests.Music.DataAccess.EntityFramework`

Additional transitive project references:

- `Grammophone.Caching`
- `Grammophone.Configuration`
- `Grammophone.DataAccess`
- `Grammophone.DataAccess.EntityFramework`
- `Grammophone.DataAccess.EntityFramework.Plus`
- `Grammophone.Domos.AccessChecking`
- `Grammophone.Domos.Accounting`
- `Grammophone.Domos.DataAccess`
- `Grammophone.Domos.DataAccess.EntityFramework`
- `Grammophone.Domos.Domain`
- `Grammophone.Domos.Environment`
- `Grammophone.Domos.Logic`
- `Grammophone.Domos.Tests.Music.DataAccess`
- `Grammophone.Domos.Tests.Music.Domain`
- `Grammophone.Domos.Tests.Music.Logic`
- `Grammophone.Email`
- `Grammophone.GenericContentModel`
- `Grammophone.Logging`
- `Grammophone.Serialization`
- `Grammophone.Setup`
- `Grammophone.Storage`
- `Grammophone.Tasks`
- `Grammophone.TemplateRendering`

## Runtime Notes

- Requires SQL Server LocalDB.
- Uses `App.config` for the EF6 connection string and Unity `musicLogic` configuration section.
