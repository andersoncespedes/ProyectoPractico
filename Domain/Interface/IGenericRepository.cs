using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interface;
public interface IGenericRepository<T> where T: BaseEntity
{
    void Add(T entity);
    void AddRange(IEnumerable<T> entities);
    void Update(T entity);
    void Remove(T entity);
    IEnumerable<T> Find(Expression<Func<T,bool>> expression);
    Task<T> GetById(int id);
    Task<IEnumerable<T>> GetAll();
    Task<(int totalRegistros, IEnumerable<T>)> Paginacion(int pageIndex, int pageSize, string search);    
}
