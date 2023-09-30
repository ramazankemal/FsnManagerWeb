using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IComponentService
    {
        bool Add(Component component);
        bool Update(Component component);
        bool Delete(Component component);
        List<Component> GetAll(Expression<Func<Component,bool>> predicate);
        Component GetById(int id);

    }
}
