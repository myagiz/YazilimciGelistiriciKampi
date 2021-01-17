using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceEntities.Entity;

namespace ECommerceBusiness.Abstract
{
    public interface ICustomerService
    {
        void Add();
        void Delete();
        void Update();
        void GetById();
    }
} 
