using System;

namespace DotNet_Abstract_vs_Interface
{
    public class VehicleClass
    {

    }
    //c#8 den sonra interface'lerde statik kod yazabiliriz.
    public interface IVehicle
    {
        void Go();
        void Stop();


        //void OpenWindow(); /* Bu interface de pencereAç metodu olamaz. Çünkü bisikletin penceresi yok vs.*/
    }
    public interface IRideable
    {
        void Ride();


    }
    public interface IFlyable
    {
        void Soar();
    }

    public class Car : BaseVehicle
    {

    }

    public class Bike : BaseVehicle, IRideable//Birden fazla interface kullanılabilirken birden fazla abstract kullanılamaz. //
    {
        public void Ride()
        {
            Console.WriteLine("Bike is riding...");
        }
    }
    public class Plane : IVehicle, IFlyable
    {
        public void Go()
        {
            throw new System.NotImplementedException();
        }

        public void Soar()
        {
            throw new System.NotImplementedException();
        }

        public void Stop()
        {
            throw new System.NotImplementedException();
        }
    }


    //Abstract


    public abstract class BaseVehicle
        : IVehicle
    {
        public void Go()
        {
            Console.WriteLine("Vehicle is going...");
        }

        public void Stop()
        {
            Console.WriteLine("Vehicle is stopped...");
        }
    }



}
