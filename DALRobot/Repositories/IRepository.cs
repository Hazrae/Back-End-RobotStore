using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALRobot.Repositories
{
    //basic CRUD
    interface IRepository<TEntity>
    {
        List<TEntity> GetAll();
        TEntity GetOne(int id);
        TEntity Create(TEntity entity);
        void Delete(int id);
    }
}
