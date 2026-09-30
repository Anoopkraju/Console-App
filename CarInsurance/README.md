# CarInsurance - ASP.NET Core MVC / Entity Framework Assignment

Implements Parts 1-3: Insuree model, SQL Server EF Core database, CRUD pages, automatic insurance quote calculation, hidden Quote input, and Admin quote list.

## Run in Visual Studio
1. Open `CarInsurance.csproj` in Visual Studio 2022.
2. Allow NuGet packages to restore.
3. Open **Tools > NuGet Package Manager > Package Manager Console**.
4. Run: `Update-Database`
5. Press **F5** or **Ctrl+F5**.

The app starts at `/Insurees`. The administrator page is `/Insurees/Admin`.

## Quote rules
Base $50; age <=18 +$100, 19-25 +$50, 26+ +$25; vehicle before 2000 +$25, after 2015 +$25; Porsche +$25; Porsche 911 Carrera +$25 more; each speeding ticket +$10; DUI adds 25%; full coverage adds 50%.
