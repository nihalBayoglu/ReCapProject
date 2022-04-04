﻿using Business.Abstract;
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
        public void AddCar(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice>0)
                _carDal.Add(car);
        }

        public List<Car> GetAll()
        {
            //İş kuralları
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            //İş Kuralları

            return _carDal.GetAll(w => w.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            //İş kuralları
            return _carDal.GetAll(w => w.ColorId == id);
        }
    }
}
