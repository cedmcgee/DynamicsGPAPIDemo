using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using DynamicsGPJDFAPI.Entities;
namespace DynamicsGPJDFAPI.Services
{
   
    public class GenericEFRepository : IGenericEFFactory
    {

        private JdfDbContext _db;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public GenericEFRepository(JdfDbContext db)
        {
            _db = db;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="item"></param>
        public void Add<TEntity>(TEntity item) where TEntity : class
        {
            _db.Add<TEntity>(item);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="item"></param>
        public void Delete<TEntity>(TEntity item) where TEntity : class
        {
            _db.Set<TEntity>().Remove(item);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Exists<TEntity>(int id) where TEntity : class
        {
            return _db.Set<TEntity>().Find(new object[] { id }) != null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        public IEnumerable<TEntity> Get<TEntity>() where TEntity : class
        {
            return _db.Set<TEntity>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="id"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public TEntity Get<TEntity>(string id, short code) where TEntity : class
        {
            var entity = _db.Set<TEntity>().Find(new object[] { id, code });
            if (entity != null)
            {
                var dbsets = typeof(JdfDbContext)
                    .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .Where(z => z.PropertyType.Name.Contains("DbSet"))
                    .Select(z => z.Name);

                var tables = typeof(TEntity)
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(z => dbsets.Contains(z.Name))
                .Select(z => z.Name);

                if (tables.Count() > 0)
                {
                    foreach (var table in tables)
                        _db.Entry(entity).Collection(table).Load();
                }

            }

            return entity;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="id"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public TEntity Get<TEntity>(string id, string code) where TEntity : class
        {
            var entity = _db.Set<TEntity>().Find(new object[] { id ,code });
            if (entity != null)
            {
                var dbsets = typeof(JdfDbContext)
                    .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .Where(z => z.PropertyType.Name.Contains("DbSet"))
                    .Select(z => z.Name);

                var tables = typeof(TEntity)
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(z => dbsets.Contains(z.Name))
                .Select(z => z.Name);

                if (tables.Count() > 0)
                {
                    foreach (var table in tables)
                        _db.Entry(entity).Collection(table).Load();
                }

            }

            return entity;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        public TEntity Get<TEntity>(string id) where TEntity : class
        {
            var entity = _db.Set<TEntity>().Find(new object[] { id });
            if (entity != null)
            {
                var dbsets = typeof(JdfDbContext)
                    .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .Where(z => z.PropertyType.Name.Contains("DbSet"))
                    .Select(z => z.Name);

                var tables = typeof(TEntity)
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(z => dbsets.Contains(z.Name))
                .Select(z => z.Name);

                if (tables.Count() > 0)
                {
                    foreach (var table in tables)
                        _db.Entry(entity).Collection(table).Load();
                }

            }

            return entity;
        }
        public TEntity Get<TEntity>(int id, bool includeRelatedEntities = false) where TEntity : class
        {
            var entity = _db.Set<TEntity>().Find(new object[] { id });

            if (entity != null && includeRelatedEntities)
            {
                var dbsets = typeof(JdfDbContext)
                    .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .Where(z => z.PropertyType.Name.Contains("DbSet"))
                    .Select(z => z.Name);

                var tables = typeof(TEntity)
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(z => dbsets.Contains(z.Name))
                .Select(z => z.Name);

                if (tables.Count() > 0)
                {
                    foreach (var table in tables)
                        _db.Entry(entity).Collection(table).Load();
                }


            }

            return entity;



        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0;
        }
    }
}
