Book[] books = {
    new("Suç ve Ceza", "Dostoyevski", 687),
    new("1984", "George Orwell", 328),
    new("Simyacı", "Paulo Coelho", 184)
};

foreach (var b in books)
    Console.WriteLine(b.Info());

var maxBook = books[0];
foreach (var b in books)
    if (b.Pages > maxBook.Pages) maxBook = b;

Console.WriteLine($"\nEn kalın kitap: {maxBook.Info()}");

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    private int pages;
    public int Pages
    {
        get => pages;
        set => pages = value > 0 ? value : throw new ArgumentException("Pages > 0 olmalı");
    }

    public Book(string title, string author, int pages) => (Title, Author, Pages) = (title, author, pages);
    public string Info() => $"{Title} by {Author}, {Pages} pages";
}
