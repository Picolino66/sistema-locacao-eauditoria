using Locadora.WebAPI.Data.Interfaces;
using Locadora.WebAPI.Models;

namespace Locadora.WebAPI.Data.Repositories
{
    public class Repository : IRepository
    {   
        private readonly SmartContext _context;
        public Repository(SmartContext context)
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

        public Locacao[] GetAllLocacoes()
        {
            IQueryable<Locacao> query = _context.Locacoes;
            query = query.OrderBy(l => l.Id);
            return query.ToArray();
        }

        public Locacao GetLocacaoById(int id)
        {
            IQueryable<Locacao> query = _context.Locacoes;
            query = query.Where(l => l.Id == id);
            if (query.Count() > 0)
                return query.First();
            return null;
        }
    }
}