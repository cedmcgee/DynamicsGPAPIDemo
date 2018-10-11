using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicsGPAPI.Entities;
using DynamicsGPAPI.Services;
using DynamicsGPAPI.Models;
using AutoMapper;

namespace DynamicsGPAPI.Services
{

    public interface IGenericEFFactory
    {
        IEnumerable<TEntity> Get<TEntity>() where TEntity : class;
        TEntity Get<TEntity>(int id, bool includeRelatedEntities = false) where TEntity : class;
        void Add<TEntity>(TEntity item) where TEntity : class;
        bool Exists<TEntity>(int id) where TEntity : class;
        void Delete<TEntity>(TEntity item) where TEntity : class;
        bool Save();
    }
}
