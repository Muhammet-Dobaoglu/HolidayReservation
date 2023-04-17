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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDAL _testimonialDal;

        public TestimonialManager(ITestimonialDAL testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TInsert(Testimonial t)
        {
            _testimonialDal.Insert(t);
        }
        public void TUpdate(Testimonial t)
        {
            _testimonialDal.Update(t);
        }
        public void TDelete(Testimonial t)
        {
            _testimonialDal.Delete(t);
        }

        public Testimonial TGetByID(int id)
        {
            return _testimonialDal.GetByID(id);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialDal.GetList();
        }

        public List<Testimonial> TGetListByFilter(Expression<Func<Testimonial, bool>> filter)
        {
            return _testimonialDal.GetListByFilter(filter);
        }
    }
}
