using Locadora.WebAPI.Models;

namespace Locadora.WebAPI.Data.Interfaces
{
    public interface IClienteRepository : IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Cliente[] GetAllClientes();
        Cliente GetClienteById(int id);
    }
}