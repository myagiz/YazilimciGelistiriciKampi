using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Contexts;
using Entities;

namespace Business.Concrete
{
    public class SalesManager : ISalesService
    {
        YagoDizaynGameContext _db = new YagoDizaynGameContext();
        public void Add(Sales sales)
        {
            _db.Sales.Add(sales);
            _db.SaveChanges();
        }

        public void List()
        {
            var listOfSales = _db.Sales.ToList();
        }

        public void Delete(int id)
        {
            var deleteSale = _db.Sales.Find(id);
            _db.Sales.Remove(deleteSale);
            _db.SaveChanges();
        }

        public void GetById(int id)
        {
            if (id != null)
            {
                Sales checkSales = _db.Sales.Find(id);
            }
        }
    }
}
