using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicsGPJDFAPI.Entities;
using DynamicsGPJDFAPI.Services;
using DynamicsGPJDFAPI.Models;
using AutoMapper;

namespace DynamicsGPJDFAPI.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface IGenericEFFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        IEnumerable<TEntity> Get<TEntity>() where TEntity : class;
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity Get<TEntity>(string id) where TEntity : class;
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="id"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        TEntity Get<TEntity>(string id,string code) where TEntity : class;
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="id"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        TEntity Get<TEntity>(string id, short code) where TEntity : class;
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="item"></param>
        void Add<TEntity>(TEntity item) where TEntity : class;
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Exists<TEntity>(int id) where TEntity : class;
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="item"></param>
        void Delete<TEntity>(TEntity item) where TEntity : class;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        bool Save();
    }
}
