using System;
using System.Collections;
using System.Collections.Generic;

namespace BdA.SocialNetwork.Data
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
