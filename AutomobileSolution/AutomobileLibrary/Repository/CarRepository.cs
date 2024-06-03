using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public  void DeleteCar(int carId) => CarDBContext.Instance.Remove(carId);
        

        public  IEnumerable<Car> GetCar() => CarDBContext.Instance.GetCarList;

        public  Car GetCarByID(int carId) => CarDBContext.Instance.GetCarById(carId);

        public  void InsertCar(Car car) => CarDBContext.Instance.AddNew(car);


        public  void UpdateCar(Car car) => CarDBContext.Instance.Update(car);

    }
}
