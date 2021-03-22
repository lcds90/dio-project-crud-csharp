using System.Collections.Generic;

namespace dio_project_crud_csharp.Interfaces
{
    public interface iRepositorio<T>
    {
         List<T> List();
         T ReturnById(int id);
         void Insert(T entity);
         void Delete(int id);
         void Update(int id, T entity);
         int NextId();
    }
}