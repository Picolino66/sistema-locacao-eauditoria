using Locadora.WebAPI.Data.Interfaces;
using Locadora.WebAPI.Models;

namespace Locadora.WebAPI.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly SmartContext _context;
        public ClienteRepository(SmartContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
            SaveChanges();
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
            SaveChanges();
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
            SaveChanges();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0 );
        }

        public Cliente[] GetAllClientes()
        {
            IQueryable<Cliente> query = _context.Clientes;
            query = query.OrderBy(c => c.Id);
            return query.ToArray();
        }

        public Cliente GetClienteById(int id)
        {
            IQueryable<Cliente> query = _context.Clientes;
            query = query.Where(c => c.Id == id);
            if (query.Count() > 0)
                return query.First();
            return null;
        }

        public Locacao[] GetAllLocacoes()
        {
            throw new NotImplementedException();
        }

        public Locacao GetLocacaoById(int id)
        {
            throw new NotImplementedException();
        }
    }
}