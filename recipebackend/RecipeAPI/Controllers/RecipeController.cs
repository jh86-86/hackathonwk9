using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace RecipeAPI
{
    [ApiController]
    [Route("books")]
    public class BookController : ControllerBase
    {
        private readonly IRepository<Book> _bookRepository;

        public BookController(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        // [HttpGet]
        // public IEnumerable<Book> GetAll()
        // {

        //     return _bookRepository.GetAll();
        // }

        [HttpGet]
        public IEnumerable<Book> Search(string s)
        {
            if (!String.IsNullOrEmpty(s))
            {
                Console.WriteLine("query done");
                return _bookRepository.Search(s);
            }
            else
            {
                Console.WriteLine("query na");
                return _bookRepository.GetAll();
            }
        }



        [HttpGet("{id}")]
        public async Task<Book> Get(long id)
        {
            return await _bookRepository.Get(id);
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
        public IActionResult Update(long id, [FromBody] Book book)
        {
            try
            {
                var myBook = _bookRepository.Update(new Book { Id = id, Title = book.Title, Author = book.Author });
                return Ok(myBook);
            }
            catch (Exception)
            {
                return NotFound($"Book with id {id} not found");
            }
        }

        [HttpPost]
        public IActionResult Insert([FromBody] Book book)
        {
            try
            {
                var myBook = _bookRepository.Insert(book);
                return Ok(myBook);
            }
            catch (Exception)
            {
                return BadRequest("Data format not valid, it must be JSON format");
            }
        }
    }
}
