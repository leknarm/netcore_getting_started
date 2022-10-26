using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using WebApi.Services;
using WebApi.ViewModel;
using WebApi.ViewModel.Entities;

namespace WebApi.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly SqlConnection _connection;

        public TodoRepository(IOptions<ConnectionStrings> connectionString)
        {
            _connection = new SqlConnection(connectionString.Value.PrimaryDatabaseConnectionString);
        }

        public async Task Delete()
        {
            var sql = @"DELETE FROM Todos";
            await _connection.ExecuteAsync(sql);
        }

        public async Task<Todos> Get(int id)
        {
            var entity = await _connection.GetAsync<Todos>(id);
            return entity;
        }

        public async Task<IReadOnlyList<Todos>> GetAll()
        {
            var entities = await _connection.GetAllAsync<Todos>();
            return entities.ToList();
        }

        public async Task<Todos> Insert(TodoInsert dto)
        {
            var todo = new Todos()
            {
                Todo = dto.Todo,
                DueDate = dto.DueDate,
                CreatedDate = DateTime.Now
            };
            todo.Id = await _connection.InsertAsync(todo);
            return todo;
        }
    }
}
