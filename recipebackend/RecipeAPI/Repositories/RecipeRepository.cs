using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Threading.Tasks;

namespace RecipeAPI
{
    public class RecipeRepository : BaseRepository, IRepository<Recipe>
    {

        public RecipeRepository(IConfiguration configuration) : base(configuration) { }

        public IEnumerable<Recipe> GetAll()
        {
            using var connection = CreateConnection();
            IEnumerable<Recipe> recipes = connection.Query<Recipe>("SELECT * FROM Recipes;");
            return recipes;
        }

        public void Delete(long id)
        {
            using var connection = CreateConnection();
            connection.Execute("DELETE FROM Recipes WHERE Id = @Id;", new { Id = id });
        }

        public async Task<Recipe> Get(long id)
        {
            using var connection = CreateConnection();
            return await connection.QuerySingleAsync<Recipe>("SELECT * FROM Recipes WHERE Id = @Id;", new { Id = id });
        }

        public Recipe Update(Recipe recipe)
        {
            using var connection = CreateConnection();
            return connection.QuerySingle<Recipe>("UPDATE Recipes SET Title = @Title WHERE Id = @Id RETURNING *", recipe);
        }

        public Recipe Insert(Recipe recipe)
        {
            using var connection = CreateConnection();
            return connection.QuerySingle<Recipe>("INSERT INTO Recipes (CategoryDish, Title, Theme, PrepTime, CookingTime, Portion, Ingredient, Instruction, Picture) VALUES (@CategoryDish, @Title, @Theme, @PrepTime, @CookingTime, @Portion, @Ingredient, @Instruction, @Picture) RETURNING *;", recipe);
        }
        public IEnumerable<Recipe> Search(string s)
        {
            using var connection = CreateConnection();
            return connection.Query<Recipe>("SELECT * FROM Recipes WHERE Title LIKE @s;", new { s = "%" + s + "%" });
        }
    }
}