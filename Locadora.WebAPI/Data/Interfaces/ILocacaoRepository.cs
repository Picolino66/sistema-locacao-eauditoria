using Locadora.WebAPI.Models;

namespace Locadora.WebAPI.Data.Interfaces
{
    public interface ILocacaoRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Locacao[] GetAllLocacoes();
        Locacao GetLocacaoById(int id);
    }
}