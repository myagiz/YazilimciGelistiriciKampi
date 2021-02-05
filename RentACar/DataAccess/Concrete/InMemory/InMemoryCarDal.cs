using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car
                {
                    Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2012, DailyPrice = 78000,
                    Description = "Amazing Car Bmw x5"
                },
                new Car
                {
                    Id = 2, BrandId = 1, ColorId = 3, ModelYear = 2015, DailyPrice = 98000,
                    Description = "Amazing Car Bmw x6"
                },
                new Car
                {
                    Id = 3, BrandId = 2, ColorId = 2, ModelYear = 2020, DailyPrice = 64000,
                    Description = "Amazing Car Mercedes"
                },

            };
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault((x => x.Id == car.Id));
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.Description = car.Description;

        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(x => x.Id == car.Id);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAllByBrand(int BrandId)
        {
            return _cars.Where(x => x.BrandId == BrandId).ToList();
        }
    }
}
