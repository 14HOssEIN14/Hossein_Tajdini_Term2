using EX3_SimpleCRUD;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


List<Book> books = new List<Book>
{
    new Book { Id = 1, Title = "Test1", Author = "Sara Smith" },
    new Book { Id = 2, Title = "Brave New World", Author = "Aldous Huxley" }
};

//C
app.MapPost("/books", (Book book) =>
{
    book.Id = books.Max(b => b.Id) + 1;
    book.Title = "Kimiagar";
    book.Author = "Paulo Coelho";
    books.Add(book);
    return Results.Created($"/books/{book.Id}", book);
});

//R
app.MapGet("/books", () => books);

//U
app.MapPut("/books/{id}", (int id, Book updatedBook) =>
{
    var book = books.FirstOrDefault(b => b.Id == id);
    book.Title = updatedBook.Title;
    book.Author = updatedBook.Author;

    return Results.Ok(book);
});

//D
app.MapDelete("/books/{id}", (int id) =>
{
    var book = books.FirstOrDefault(b => b.Id == id);
    if (book is null) return Results.NotFound();

    books.Remove(book);
    return Results.NoContent();
});



app.Run();





