﻿using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ETicaretAPI.Application.Repositories
{
    public  interface IReadReporsitory<T>:IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(); //SORGU ÜZERİNDEN ÇALIŞIR. Bütün verileri getirir.
        IQueryable<T> GetWhere(Expression<Func<T,bool>> method);//
        Task<T> GetSingleAsync(Expression<Func<T,bool>> method);
        Task<T> GetByIdAsync(string id);
    }
}