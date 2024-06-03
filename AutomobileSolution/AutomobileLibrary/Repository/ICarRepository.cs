using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.Repository;

namespace AutomobileLibrary.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCar();
        Car GetCarByID(int carId);
         void InsertCar(Car car);
         void UpdateCar(Car car);
         void DeleteCar(int carId);
    }
}
