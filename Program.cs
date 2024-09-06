using LinqJoinPractice;

List<Authors> authors = new List<Authors>
{
    new Authors { AuthorId = 1, Name = "J.K. Rowling" },
    new Authors { AuthorId = 2, Name = "George R.R. Martin" },
    new Authors { AuthorId = 3, Name = "J.R.R. Tolkien" }
};

List<Books> books = new List<Books>
{
    new Books { BookId = 1, Title = "Harry Potter and the Philosopher's Stone", AuthorId = 1 },
    new Books { BookId = 2, Title = "A Game of Thrones", AuthorId = 2 },
    new Books { BookId = 3, Title = "The Hobbit", AuthorId = 3 },
    new Books { BookId = 4, Title = "Harry Potter and the Chamber of Secrets", AuthorId = 1 }
};

var query = from book in books
            join author in authors on book.AuthorId equals author.AuthorId
            select new { book.Title, author.Name };

foreach (var result in query)
{
    Console.WriteLine($"Kitap: {result.Title}, Yazar: {result.Name}");
}
