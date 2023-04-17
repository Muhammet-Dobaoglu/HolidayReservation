﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> 
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);   
        T GetByID(int id);
        List<T> GetList();
        List<T> GetListByFilter(Expression<Func<T, bool>> filter);
        T GetListByFilterByD(Expression<Func<T, bool>> filter);

    }
}
