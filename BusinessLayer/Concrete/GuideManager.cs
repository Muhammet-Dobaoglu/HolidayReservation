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
    public class GuideManager : IGuideService
    {
        private readonly IGuideDAL _guideDal;

        public GuideManager(IGuideDAL guideDal)
        {
            _guideDal = guideDal;
        }

        public void TInsert(Guide t)
        {
            _guideDal.Insert(t);
        }
        public void TUpdate(Guide t)
        {
            _guideDal.Update(t);
        }
        public void TDelete(Guide t)
        {
            _guideDal.Delete(t);
        }

        public Guide TGetByID(int id)
        {
            return _guideDal.GetByID(id);
        }

        public List<Guide> TGetList()
        {
            return _guideDal.GetList();
        }

        public List<Guide> TGetListByFilter(Expression<Func<Guide, bool>> filter)
        {
            return _guideDal.GetListByFilter(filter);
        }
    }
}
