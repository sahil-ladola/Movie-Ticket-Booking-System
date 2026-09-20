# Movie Ticket Booking System

A Windows desktop application for booking cinema tickets at a three-screen
multiplex: sign in, pick a movie, pick a date and show time, select seats from a
seating chart priced by class, and get an invoice you can keep or cancel.

Built as an academic project with C# and Windows Forms over SQL Server.

## Stack

- **C#**, **Windows Forms**, .NET Framework **4.7.2**
- **SQL Server Express** via ADO.NET (`SqlConnection` / `SqlCommand`)
- `Microsoft.ReportViewer.Runtime.WinForms` 12.0 (NuGet) plus a typed dataset,
  `Booking_masterDataSet`, for the invoice screen

The Visual Studio project and assembly are both named `Login`, after the form
the application starts on.

## Screens

| Form | Role |
| --- | --- |
| `Form1.cs` (`Login`) | Entry point. Credentials are **hardcoded** as `Sahil` / `SAHIL`; anything else shows an error label |
| `Home.cs` | Picks one of three screens, each tied to a fixed film — Screen 1 *RRR*, Screen 2 *Attack*, Screen 3 *Beast*. The choice is stored in the static `Home.MovieName` |
| `Screen1.cs`, `Screen2.cs`, `Screen3.cs` | Date buttons (the 12th to the 15th) reveal a time panel with show times from 8am to 12am. The selection is kept in each form's static `date` and `Time` fields |
| `Seates.cs` | Seating chart in three classes — Platinum ₹300, Gold ₹170, Silver ₹110 a seat. Each seat button adds its price to the running total. Confirming inserts the booking and shows the invoice |
| `PrintInvoice.cs` (`Invoice`) | Enter the invoice id to display the booking — movie, screen, date, time and total — then **Done** to finish or **Cancel** to delete the row from `Booking_Details` |

State moves between forms through `public static` fields rather than
constructor arguments or a session object, which is why `Seates` and `Invoice`
read `Screen3.date`, then `Screen2.date`, then `Screen1.date` to work out where
you came from.

## Database

`App.config` holds:

```xml
<add name="Login.Properties.Settings.Booking_masterConnectionString"
     connectionString="Data Source=DESKTOP-HBMGQQD\SQLEXPRESS;Initial Catalog=Booking_master;Integrated Security=True"
     providerName="System.Data.SqlClient" />
```

`Screen1.cs`, `Seates.cs` and `PrintInvoice.cs` each build the same connection
string inline as well, so **changing the server means editing those files too**,
not just `App.config`.

One table is used, `Booking_Details`, with the columns inserted in this order:
movie name, date, time, total amount, invoice id. The invoice id is a random
number below 1000 generated at booking time.

**No schema script ships with the repository** — create the `Booking_master`
database and the `Booking_Details` table before running.

## Running it

1. Open `Login.sln` in Visual Studio (2019 or 2022, .NET desktop workload).
2. Create the `Booking_master` database in SQL Server Express and add the
   `Booking_Details` table described above.
3. Update the connection string in `App.config` **and** the inline ones in
   `Screen1.cs`, `Seates.cs` and `PrintInvoice.cs`.
4. Restore NuGet packages (ReportViewer) and press F5.
5. Sign in as `Sahil` / `SAHIL`.

## Known limitations

- **Login is hardcoded in source**, with no user table and no password hashing.
- **Seats are not persisted.** A booking stores the movie, date, time, total and
  invoice id only, so the same seat can be sold twice and the seating chart
  always starts empty.
- **Invoice ids are `Random.Next(1000)`** with no uniqueness check, so two
  bookings can collide — and cancelling deletes by that id.
- Movies, screens, dates and show times are all fixed in the UI; nothing is
  read from the database, so changing the listing means editing the forms.
- SQL is assembled by string concatenation.
- `bin/` and `obj/` build output is committed to the repository.
