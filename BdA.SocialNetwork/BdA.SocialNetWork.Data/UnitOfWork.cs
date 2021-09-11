using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BdA.SocialNetWork.Data
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : DbContext
    {
        public T _context;
        public UnitOfWork(string connectionString, string migrationAssemblyName)
        {
            _context = (T)Activator.CreateInstance(typeof(T), connectionString, migrationAssemblyName);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
