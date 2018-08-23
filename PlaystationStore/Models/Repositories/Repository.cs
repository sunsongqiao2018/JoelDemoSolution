using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PlaystationStore.Models;

namespace PlaystationStore.Models.Repositories
{
    public class Repository<T> where T : class
    {
        private PSGameStoreDbContext context = null;
        
        protected DbSet<T> DbSet { get; set; }

        public Repository()
        {
            context = new PSGameStoreDbContext();
            DbSet = context.Set<T>();
        }

        public Repository(PSGameStoreDbContext context)
        {
            this.context = context;   //then U could  pass in new context
        }
        
        public List<T> GetAll()
        {
            return DbSet.ToList();
        }

        public T Get(int id)
        {
            return DbSet.Find(id);
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }
        public void Delete(T entity)
        {
            DbSet.Remove(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}