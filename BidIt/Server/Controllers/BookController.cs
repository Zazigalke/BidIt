using BidIt.Server.Services;
using BidIt.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BidIt.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
       /* private readonly IDataBaseOperations _database;

        public BookController(IDataBaseOperations database)
        {
            _database = database;
        }

        [HttpGet]
        public async Task<IEnumerable<Book>> Get()
        {
            return await _database.ReadListAsync<Book>($"SELECT * FROM Book");
        }

        [HttpGet("{id}")]
        public async Task<Book?> Get(int id)
        {
            return await _database.ReadItemAsync<Book?>($"SELECT * FROM Book WHERE Id = {id}");
        }

        [HttpPost]
        public async Task Create([FromBody] Book Book)
        {
            await _database.ExecuteAsync($"INSERT into Book(name,lastname,date,document_id) values('{Book.Name}', '{Book.LastName}', '{Book.Date}','{Book.Document_id}')");
        }

        [HttpPut]
        public async Task Update([FromBody] Book Book)
        {
            await _database.ExecuteAsync($"UPDATE Book set name = '{Book.Name}', lastname = '{Book.LastName}', date = '{Book.Date}', document_id ='{Book.Document_id}' WHERE Id = {Book.Id}");
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _database.ExecuteAsync($"DELETE FROM Book WHERE Id = {id}");
        }*/
    }
}
