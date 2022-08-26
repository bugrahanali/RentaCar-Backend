using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace   Core.DataAccess

{
    public interface IEntityRepository<T> where T:class,IEntity,new() // bu T yerine hem sadece class(yani int ,string vs gibi veri tipi değil) hem de IEntity içinden biri olcak demek ama sonuna new ekliyoruz ki IEntity kullanılamasın
    {

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter );
      
        T GetById(Expression<Func<T, bool>> filter=null);
        
    }
}
