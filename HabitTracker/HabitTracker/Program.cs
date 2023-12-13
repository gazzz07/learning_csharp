using Microsoft.Data.Sqlite;
using System.Globalization;

string connectionString = @"Data Source=habit-Tracker.db";

using (var connection = new SqliteConnection(connectionString))
{
    connection.Open();
    var tableCmd = connection.CreateCommand();

    tableCmd.CommandText = @"CREATE TABLE IF NOT EXISTS coding_hours (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Date TEXT,
                                Quantity INTEGER
                                )";

    tableCmd.ExecuteNonQuery();

    connection.Close();
}

UserMenu();

void UserMenu()
{
    Console.Clear();
    bool closeApp = false;
    while (closeApp == false)
    {


        Console.WriteLine("Habit Tracker Main Menu\n------------\nPlease select an option: ");
        Console.WriteLine("'1' - Create A New Record\n'2' - Read Records\n'3' - Update Records\n'4' - Delete Records\n'0' - Exit Application");
        Console.WriteLine("-----\nYour choice: ");
        string userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                Create();
                break;
            case "2":
                Read();
                break;
            case "3":
                Update();
                break;
            case "4":
               Delete();
                break;
            case "0":
                Console.WriteLine("Goodbye");
                closeApp = true;
                break;
            default:
                Console.Clear();
                Console.WriteLine("Invalid, please select an option.");
                break;
        }
    }
}
void Create()
{
    Console.Clear();
    string date = GetDateInput();

    int quantity = GetNumberInput("\n\nPlease insert the number of hours (to the nearest hour) spent learning C# with The C# Academy today!");

    using (var connection = new SqliteConnection(connectionString))
    {
        connection.Open();
        var tableCmd = connection.CreateCommand();
        tableCmd.CommandText = 
            $"INSERT INTO coding_hours(date, quantity) VALUES('{date}', {quantity})";
        tableCmd.ExecuteNonQuery();

        connection.Close();
    }
}
void Read()
{
    Console.Clear();
    using (var connection = new SqliteConnection(connectionString))
    {
        connection.Open();
        var tableCmd = connection.CreateCommand();
        tableCmd.CommandText =
            $"SELECT * FROM coding_hours";
        List<CodingHours> tableData = new();

        SqliteDataReader reader = tableCmd.ExecuteReader();

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                tableData.Add(
                    new CodingHours()
                    {
                        Id = reader.GetInt32(0),
                        Date = DateTime.ParseExact(reader.GetString(1), "dd-MM-yy", new CultureInfo("en-US")),
                        Quantity = reader.GetInt32(2)
                    }); ;
            }
        } else
        {
            Console.WriteLine("Database has no rows, please create some rows!");
        }

        connection.Close();

        Console.WriteLine("------------\n");
        foreach (var dw in tableData)
        {
            Console.WriteLine($"{dw.Id} - {dw.Date.ToString("dd-MMM-yyyy")} - Quantity: {dw.Quantity}");
        }
        Console.WriteLine("---------------\n");
    }
    
}
void Update()
{
    Console.Clear();
    Console.WriteLine("Update Table");
}
void Delete()
{
    Console.Clear();
    Read();

    var recordId = GetNumberInput("\n\nPlease type the Id of the record you wish to delete, or press 0 to return to the main menu.");

    using (var connection = new SqliteConnection(connectionString))
    {
        connection.Open();
        var tableCmd = connection.CreateCommand();
        tableCmd.CommandText =
            $"DELETE FROM coding_hours WHERE Id = '{recordId}'";

        int rowCount = tableCmd.ExecuteNonQuery();

        if (rowCount == 0)
        {
            Console.WriteLine($"\n\nRecord with Id {recordId} doesn't exist. \n\n");
            Delete();
        }

    }
    Console.WriteLine($"\n\nRecord with {recordId} was deleted. \n\n");
}
string GetDateInput()
{
    Console.WriteLine("\n\nPlease insert the date: (Format: dd-mm-yy). Type 0 to return to the main menu.");

    string dateInput = Console.ReadLine();

    if (dateInput == "0") UserMenu();

    return dateInput;
}

int GetNumberInput(string message)
{
    Console.WriteLine(message);

    string numberInput = Console.ReadLine();

    if (numberInput == "0") UserMenu();

    int finalInput = Convert.ToInt32(numberInput);

    return finalInput;
}
public class CodingHours
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int Quantity { get; set; }

}