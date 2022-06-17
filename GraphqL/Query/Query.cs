using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphqL.Query
{
    public record Book(string Title, Author Author);
    public record Author(string AuthorName);
    public class Query
    {

        public List<Book> GetBooks() => _books;
        public Book GetBook(string title) =>
            _books.FirstOrDefault(x => x.Title == title);

        public Author? GetAuthor(string name) =>
            _books.FirstOrDefault(x => x.Author?.AuthorName == name)?.Author;

        readonly List<Book> _books = new()
        {
            new Book("I Love GraphQL", new Author("Alaa")),
            new Book("GrphQL is the future", new Author("Mohamed")),
            new Book("I hate SOAP", new Author("Mohamed"))
        };
    }
}
