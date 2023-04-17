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
    public class CityManager : ICityService
    {
        private readonly ICityDAL _cityDal;

        public CityManager(ICityDAL cityDal)
        {
            _cityDal = cityDal;
        }

        public void TInsert(City t)
        {
            _cityDal.Insert(t);
        }
        public void TUpdate(City t)
        {
            _cityDal.Update(t);
        }
        public void TDelete(City t)
        {
            _cityDal.Delete(t);
        }

        public City TGetByID(int id)
        {
            return _cityDal.GetByID(id);
        }

        public List<City> TGetList()
        {
            return _cityDal.GetList();
        }

        public List<City> TGetListByFilter(Expression<Func<City, bool>> filter)
        {
            return _cityDal.GetListByFilter(filter);
        }
    }
}
