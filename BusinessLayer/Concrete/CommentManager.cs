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
    public class CommentManager : ICommentService
    {
        private readonly ICommentDAL _commentDal;

        public CommentManager(ICommentDAL commentDal)
        {
            _commentDal = commentDal;
        }

        public void TInsert(Comment t)
        {
            _commentDal.Insert(t);
        }
        public void TUpdate(Comment t)
        {
            _commentDal.Update(t);
        }
        public void TDelete(Comment t)
        {
            _commentDal.Delete(t);
        }

        public Comment TGetByID(int id)
        {
            return _commentDal.GetByID(id);
        }

        public List<Comment> TGetList()
        {
            return _commentDal.GetList();
        }

        public List<Comment> TGetListByFilter(Expression<Func<Comment, bool>> filter)
        {
            return _commentDal.GetListByFilter(filter);
        }
    }
}
