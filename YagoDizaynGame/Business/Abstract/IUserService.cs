using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Business.Abstract
{
    public interface IUserService
    {
        void Add(User user);
        void Delete(int id);
        void Updated(int id, User user);
        void Login(User user);

    }
}
