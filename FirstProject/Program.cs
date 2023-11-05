using MyFirstProgram;

var date = DateTime.UtcNow;

var games = new List<string>();

string name = Helpers.GetName();

var menu = new Menu();

menu.ShowMenu(name, date);