using Business.Abstract;
using DataAccess.EntityFramework;
using DataAccess.Repository.Abstract;
using DataAccess.Repository.Abstract.UnitOfWork;
using DataAccess.Repository.Concrete;
using DataAccess.Repository.Concrete.UnitOfWork;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ComponentManager : IComponentService
    {
        
        private IUnitOfWork _uow;      

        public ComponentManager(IUnitOfWork uow)
        {     
            _uow= uow;   
        }

        public bool Add(Component component)
        {           
            _uow.GetRepository<Component>().Add(component);      
            int pocess = _uow.SaveChanges();

            return true;
        }

        public bool Delete(Component component)
        {
            throw new NotImplementedException();
        }

        public List<Component> GetAll(Expression<Func<Component, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Component GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
