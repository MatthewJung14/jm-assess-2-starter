using Skills2;

// User Tests
var user = new User("mjung", "hunter2");
Console.WriteLine($"User created: {user.Username} / {user.Password}");

user.ProcessChangePassword("hunter2", "newPassword123");
Console.WriteLine($"Password after correct change: {user.Password}");

try
{
    user.ProcessChangePassword("wrongPassword", "shouldNotBeSet");
    Console.WriteLine("ERROR: expected ArgumentException was not thrown.");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Got expected exception: {ex.Message}");
}

// Library Tests
var library = new Library();
library.CreateAndAddBook("The Hobbit", "J.R.R. Tolkien");
library.CreateAndAddBook("Dune", "Frank Herbert");

var found = library.GetBookByTitle("Dune");
Console.WriteLine(found is not null
    ? $"Found book: {found.Title} by {found.Author}"
    : "ERROR: expected to find 'Dune'.");

var notFound = library.GetBookByTitle("Nonexistent Book");
Console.WriteLine(notFound is null
    ? "Correctly returned null for a missing title."
    : "ERROR: expected null for a missing title.");

// Rectangle and Square Tests
var rectangle = new Rectangle(4, 6);
Console.WriteLine($"Rectangle area: {rectangle.GetArea()} (expected 24)");
Console.WriteLine($"Rectangle perimeter: {rectangle.GetPerimeter()} (expected 20)");

var square = new Square(5);
Console.WriteLine($"Square area: {square.GetArea()} (expected 25)");
Console.WriteLine($"Square perimeter: {square.GetPerimeter()} (expected 20)");