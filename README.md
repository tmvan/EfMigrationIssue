# HOWTO

## Prerequisites

* Open file **IocConfig.cs** to update `CONNECTION_STRING` and `BADCONTEXT_CONNECTION_STRING` constants to your local connection strings (They must be 2 different databases).

## Test bad migration

* Open **`cmd`** or **`PowerShell`** at project folder.
* Run command: `dotnet ef database update -c BadSampleContext`
* Run command (*this one should cause error*): `dotnet ef database update 20180905010435_InitialMigration -c BadSampleContext`

## Test good migration

* Open **`cmd`** or **`PowerShell`** at project folder.
* Run command: `dotnet ef database update -c SampleContext`
* Run command: `dotnet ef database update 20180905011428_InitialMigration -c SampleContext`
