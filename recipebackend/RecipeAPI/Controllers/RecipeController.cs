using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace RecipeAPI
{
    [ApiController]
    [Route("recipes")]
    public class RecipeController : ControllerBase
    {
        private readonly IRepository<Recipe> _recipeRepository;

        public RecipeController(IRepository<Recipe> recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        // [HttpGet]
        // public IEnumerable<Book> GetAll()
        // {

        //     return _bookRepository.GetAll();
        // }

        [HttpGet]
        public IEnumerable<Recipe> Search(string s)
        {
            if (!String.IsNullOrEmpty(s))
            {
                Console.WriteLine("query done");
                return _recipeRepository.Search(s);
            }
            else
            {
                Console.WriteLine("query na");
                return _recipeRepository.GetAll();
            }
        }



        [HttpGet("{id}")]
        public async Task<Recipe> Get(long id)
        {
            return await _recipeRepository.Get(id);
        }

        [HttpDelete("{id}")]
        // public void Delete(long id)
        // {
        //     try
        //     {
        //         var returnType = _bookRepository.Delete(id).ReturnType;
        //         if (returnType == typeof(void))
        //         {
        //             return NotFound($"Book with id {id} not found");
        //         }
        //     }
        // }

        // var returnType = actionDescriptor.MethodInfo.ReturnType;
        //                 if (returnType == typeof(void) || returnType == typeof(Task))
        //                 {
        //                     context.HttpContext.Response.StatusCode = Status204NoContent;
        //                 }


        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Recipe recipe)
        {
            try
            {
                var myRecipe = _recipeRepository.Update(new Recipe { Id = id, Title = recipe.Title });
                return Ok(myRecipe);
            }
            catch (Exception)
            {
                return NotFound($"Recipe with id {id} not found");
            }
        }

        [HttpPost]
        public IActionResult Insert([FromBody] Recipe recipe)
        {
            try
            {
                var myRecipe = _recipeRepository.Insert(recipe);
                return Ok(myRecipe);
            }
            catch (Exception)
            {
                return BadRequest("Data format not valid, it must be JSON format");
            }
        }
    }
}
