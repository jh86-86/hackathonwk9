using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Threading.Tasks;

namespace RecipeAPI
{
    public class BookRepository : BaseRepository, IRepository<Book>
    {

        public BookRepository(IConfiguration configuration) : base(configuration) { }

        public IEnumerable<Book> GetAll()
        {
            using var connection = CreateConnection();
            IEnumerable<Book> books = connection.Query<Book>("SELECT * FROM Books;");
            return books;
        }

        public void Delete(long id)
        {
            using var connection = CreateConnection();
            connection.Execute("DELETE FROM Books WHERE Id = @Id;", new { Id = id });
        }

        public async Task<Book> Get(long id)
        {
            using var connection = CreateConnection();
            return await connection.QuerySingleAsync<Book>("SELECT * FROM Books WHERE Id = @Id;", new { Id = id });
        }

        public Book Update(Book book)
        {
            using var connection = CreateConnection();
            return connection.QuerySingle<Book>("UPDATE Books SET Title = @Title, Author = @Author WHERE Id = @Id RETURNING *", book);
        }

        public Book Insert(Book book)
        {
            using var connection = CreateConnection();
            return connection.QuerySingle<Book>("INSERT INTO Books (Title, Author) VALUES (@Title, @Author) RETURNING *;", book);
        }
        public IEnumerable<Book> Search(string s)
        {
            using var connection = CreateConnection();
            return connection.Query<Book>("SELECT * FROM Books WHERE Title LIKE @s OR Author LIKE @s;", new { s = "%" + s + "%" });
        }
    }
}