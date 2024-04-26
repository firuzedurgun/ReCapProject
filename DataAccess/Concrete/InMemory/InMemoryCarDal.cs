﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car { Id = 1,BrandId=1, ColorId=1,DailyPrice=2000, ModelYear=2012, Description="Renault Clio"},
                new Car { Id = 2,BrandId=1, ColorId=2,DailyPrice=1500, ModelYear=2008, Description="Renault Fluence"},
                new Car { Id = 3,BrandId=2, ColorId=3,DailyPrice=2500, ModelYear=2018, Description="BMW 320"},
                new Car { Id = 4,BrandId=3, ColorId=1,DailyPrice=3500, ModelYear=2022, Description="Mercedes Vito"},
                new Car { Id = 5,BrandId=3, ColorId=2,DailyPrice=3000, ModelYear=2021, Description="Mercedes E200"}
            };
        }
        public void Add(Car car)
        {
           _cars.Add(car);
        }

        public void Delete(int id)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == id);
            _cars.Remove(carToDelete);
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
