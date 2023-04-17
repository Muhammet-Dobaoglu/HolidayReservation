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
    public class FeaturedManager : IFeaturedService
    {
        IFeaturedDAL _featuredDal;

        public FeaturedManager(IFeaturedDAL featuredDal)
        {
            _featuredDal = featuredDal;
        }

        public void TInsert(Featured t)
        {
            _featuredDal.Insert(t);
        }
        public void TUpdate(Featured t)
        {
            _featuredDal.Update(t);
        }
        public void TDelete(Featured t)
        {
            _featuredDal.Delete(t);
        }

        public Featured TGetByID(int id)
        {
            return _featuredDal.GetByID(id);
        }

        public List<Featured> TGetList()
        {
            return _featuredDal.GetList();
        }

        public List<Featured> TGetListByFilter(Expression<Func<Featured, bool>> filter)
        {
            return _featuredDal.GetListByFilter(filter);
        }
    }
}
