using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Business.Abstract
{
    public interface ISalesService
    {
        void Add(Sales sales);
        void List();
        void Delete(int id);
        void GetById(int id);
    }
}
