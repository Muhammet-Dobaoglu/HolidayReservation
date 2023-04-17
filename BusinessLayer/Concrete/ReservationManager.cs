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
    public class ReservationManager : IReservationService
    {
        private readonly IReservationDAL _reservationDal;

        public ReservationManager(IReservationDAL reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public void TInsert(Reservation t)
        {
            _reservationDal.Insert(t);
        }
        public void TUpdate(Reservation t)
        {
            _reservationDal.Update(t);
        }
        public void TDelete(Reservation t)
        {
            _reservationDal.Delete(t);
        }

        public Reservation TGetByID(int id)
        {
            return _reservationDal.GetByID(id);
        }

        public List<Reservation> TGetList()
        {
            return _reservationDal.GetList();
        }

        public List<Reservation> TGetListByFilter(Expression<Func<Reservation, bool>> filter)
        {
            return _reservationDal.GetListByFilter(filter);
        }
    }
}
