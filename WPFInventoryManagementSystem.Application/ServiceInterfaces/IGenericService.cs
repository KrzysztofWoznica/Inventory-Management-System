using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WPFInventoryManagementSystem.Application.ServiceInterfaces
{
    public interface IGenericService<T>
    {
        Task<IEnumerable> GetAll();
        Task<T> GetById(int id);
        Task<T> Create(T entity);
        Task<T> Modify(T entity);
        Task<bool> Remove(int id);
    }
}
