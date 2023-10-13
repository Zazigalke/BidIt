using BidIt.Server.Services;
using BidIt.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BidIt.Server.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly IDataBaseOperations _database;

        public UserController(IDataBaseOperations database)
        {
            _database = database;
        }

        [HttpGet("SelectUsers")]
        public async Task<IEnumerable<User>> Get()
        {
            return await _database.ReadListAsync<User>($"SELECT * FROM User");
        }

        [HttpGet("SelectUser")]
        public async Task<User?> Get(int id)
        {
            return await _database.ReadItemAsync<User?>($"SELECT * FROM User WHERE Id = {id}");
        }

        [HttpPost("InsertUser")]
        public async Task Create([FromBody] User User)
        {
            await _database.ExecuteAsync($"INSERT into User(firstname,lastname,email) values('{User.FirstName}', '{User.LastName}', '{User.Email}')");
        }

        [HttpPut("UpdateUser")]
        public async Task Update([FromBody] User User)
        {
            await _database.ExecuteAsync($"UPDATE User set name = '{User.FirstName}', lastname = '{User.LastName}', email = '{User.Email}' WHERE Id = {User.Id}");
        }

        [HttpDelete("DeleteUser")]
        public async Task Delete(int id)
        {
            await _database.ExecuteAsync($"DELETE FROM User WHERE Id = {id}");
        }
    }
}
