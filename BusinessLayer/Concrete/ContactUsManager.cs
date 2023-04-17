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
    public class ContactUsManager : IContactUsService
    {
        private readonly IContactUsDAL _contactUsDal;

        public ContactUsManager(IContactUsDAL contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void TInsert(ContactUs t)
        {
            _contactUsDal.Insert(t);
        }
        public void TUpdate(ContactUs t)
        {
            _contactUsDal.Update(t);
        }
        public void TDelete(ContactUs t)
        {
            _contactUsDal.Delete(t);
        }

        public ContactUs TGetByID(int id)
        {
            return _contactUsDal.GetByID(id);
        }

        public List<ContactUs> TGetList()
        {
            return _contactUsDal.GetList();
        }

        public List<ContactUs> TGetListByFilter(Expression<Func<ContactUs, bool>> filter)
        {
            return _contactUsDal.GetListByFilter(filter);
        }
    }
}
