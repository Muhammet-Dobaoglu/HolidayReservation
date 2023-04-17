using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {

        private readonly IDestinationDAL _destinationDal;

        public DestinationManager(IDestinationDAL destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void TInsert(Destination t)
        {
            _destinationDal.Insert(t);
        }
        public void TUpdate(Destination t)
        {
            _destinationDal.Update(t);
        }
        public void TDelete(Destination t)
        {
            _destinationDal.Delete(t);
        }

        public Destination TGetByID(int id)
        {
            return _destinationDal.GetByID(id);
        }

        public List<Destination> TGetList()
        {
            return _destinationDal.GetList();
        }

        public List<Destination> TGetListByFilter(Expression<Func<Destination, bool>> filter)
        {
            return _destinationDal.GetListByFilter(filter);
        }
    }
}
