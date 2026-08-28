namespace Skills2;

public class User
{
    public string Username { get; set; }
    // The setter is private since we already have a public 
    // method that changes the password. 
    public string Password { get; private set; }

    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }

    public void ProcessChangePassword(string currentPassword, string newPassword)
    {
        if (currentPassword != Password)
        {
            throw new ArgumentException("Current password is incorrect.");
        }

        Password = newPassword;
    }
}

public class Book(string title, string author)
{
    public string Title { get; set; } = title;
    public string Author { get; set; } = author;
}

public class Library
{
    private List<Book> _books = new();

    public void CreateAndAddBook(string title, string author)
    {
        Book book = new Book(title, author);

        _books.Add(book);
    }

    public Book? GetBookByTitle(string title)
    {
        foreach (Book book in _books)
        {
            if (book.Title == title)
            {
                return book;
            }
        }

        return null;
    }
}

public class Rectangle(double length, double width)
{
    public double Length { get; set; } = length;
    public double Width { get; set; } = width;

    public virtual double GetArea()
    {
        return Length * Width;
    }

    public virtual double GetPerimeter()
    {
        return 2 * (Length + Width);
    }
}

public class Square : Rectangle
{
    // The square's length is passed into the Rectangle's constructor. 
    public Square(double length) : base(length, length)
    {
    }

    public override double GetArea()
    {
        return Length * Length;
    }

    public override double GetPerimeter()
    {
        return 4 * Length;
    }
}
