using Microsoft.Data.Sqlite;
string connectionString = @"Data Source=habitTracker.db";
using (var connection = new SqliteConnection(connectionString))
{
    connection.Open();
    var tableCmd = connection.CreateCommand();

    tableCmd.CommandText = "";

    tableCmd.ExecuteNonQuery();
}

Console.WriteLine("Habit Tracker Main Menu\n------------\nPlease select an option: ");
Console.WriteLine("'1' - Create A New Record\n'2' - Read Records\n'3' - Update Records\n'4' - Delete Records\n'0' - Exit Application");
Console.WriteLine("-----\nYour choice: ");
string userInput = Console.ReadLine();

switch (userInput)
{
    case "1":
        Console.WriteLine("Create");
        break;
    case "2":
        Console.WriteLine("Read");
        break;
    case "3":
        Console.WriteLine("Update");
        break;
    case "4":
        Console.WriteLine("Delete");
        break;
    case "0":
        Console.WriteLine("Exit");
        break;
    default:
        Console.WriteLine("Invalid, please select an option.");
    break;
}