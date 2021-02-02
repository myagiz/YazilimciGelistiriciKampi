using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Contexts;
using Entities;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private YagoDizaynGameContext _db = new YagoDizaynGameContext();

        public void Add(User user)
        {
            _db.User.Add(user);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var deleteUser = _db.User.Where(x => x.Id == id).SingleOrDefault();
            _db.User.Remove(deleteUser);
            _db.SaveChanges();
        }

        public void Updated(int id, User user)
        {
            var updateUser = _db.User.Where(x => x.Id == id).SingleOrDefault();
            updateUser.NickName = user.NickName;
            updateUser.Password = user.Password;
            updateUser.Birthday = user.Birthday;
            updateUser.FirstName = user.FirstName;
            updateUser.LastName = user.LastName;
            updateUser.Birthday = user.Birthday;
            updateUser.TcNo = user.TcNo;
            _db.SaveChanges();

        }

        public void Login(User user)
        {
            var login = _db.User.Where(x => x.NickName == user.NickName).SingleOrDefault();
        }
    }
}
