using WebApi.ViewModel;
using WebApi.ViewModel.Entities;

namespace WebApi.Services
{
    public interface ITodoRepository
    {
        Task<IReadOnlyList<Todos>> GetAll();
        Task<Todos> Get(int id);
        Task<Todos> Insert(TodoInsert dto);
        Task Delete();
    }
}
