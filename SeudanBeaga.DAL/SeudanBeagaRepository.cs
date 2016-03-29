using SeudanBeaga.DAL;
using SeudanBeaga.DAL.Interfaces;
using SeudanBeaga.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SeudanBeaga.DAL
{
    public class SeudanBeagaRepository<T> : IRepository<T> where T : class, IEntity
    {
        SeudanBeagaContext _context;

        public SeudanBeagaRepository()
        {
            _context = new SeudanBeagaContext();
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public T FindById(int Id)
        {
            return _context.Set<T>().FirstOrDefault(x => x.Id == Id);
        }

        public void Update(T entity)
        {
            _context.Entry<T>(entity).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public IQueryable<T> FindBy(Expression<Func<T,bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }
    }
}
