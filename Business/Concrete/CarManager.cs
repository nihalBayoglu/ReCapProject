using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }


        public void Add(Car car)
        {
            //rules
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            //rules
            _carDal.Delete(car);

        }

        public List<Car> GetAll()
        {
            //rules
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
            //rules
            return _carDal.GetById(id);
        }

        public void Update(Car car)
        {
            //rules
            _carDal.Update(car);
        }
    }
}
