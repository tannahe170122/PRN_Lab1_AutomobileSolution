using AutomobileLibrary.BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.DataAccess
{
    public class CarDBContext
    {
        private static List<Car> CarList = new List<Car>()
        {
            new Car{ CarId =1, CarName="CRV", Manufacturer="Honda", Price=30000, ReleaseYear=2021},
            new Car{ CarId =2, CarName="Ford Focus", Manufacturer="Ford", Price=15000, ReleaseYear=2020},
        };

        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext() { }
        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }

            }
        }
        //-------------------------------------------------------------------------
        public List<Car> GetCarList => CarList;
        //--------------------------------------------------------------------------

        //search car by id
        public Car GetCarById(int CarId)
        {
            Car car = CarList.SingleOrDefault(pro => pro.CarId == CarId);
            return car;
        }
        // add car
        public void AddNew(Car car)
        {
            Car pro = GetCarById(car.CarId);
            if(pro == null)
            {
                CarList.Add(car);
            }
            else
            {
                throw new Exception("Car is ready exits.");
            }
        }
        // Update car 
        public void Update(Car car) { 
            Car pro = GetCarById(car.CarId);
        if (pro != null)
            {
                var index = CarList.IndexOf(pro);
                CarList[index] = car;
            }else
            {
                throw new Exception("Car does not already exists.");
            }
        }

        //remove car 
        public void Remove(int CarId)
        {
            Car car = GetCarById(CarId);
            if(car != null)
            {
                CarList.Remove(car);
            }else
            {
                throw new Exception("Car does not already exists.");
            }
        }

    }
}
