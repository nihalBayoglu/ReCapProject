using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
   public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 10, Description = "BMW", ModelYear = "yeni araba" } ,
                new Car { Id = 2, BrandId = 2, ColorId = 1, DailyPrice = 20, Description = "AUDI", ModelYear = "süper araba" } 
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            _cars.Remove(_cars.FirstOrDefault(w => w.Id == car.Id));
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.FirstOrDefault(w => w.Id == id);
        }

        public void Update(Car car)
        {
            var updatedCar = _cars.FirstOrDefault(w => w.Id == car.Id);
            updatedCar.Id = car.Id;
            updatedCar.ModelYear = car.ModelYear;
        }
    }
}
