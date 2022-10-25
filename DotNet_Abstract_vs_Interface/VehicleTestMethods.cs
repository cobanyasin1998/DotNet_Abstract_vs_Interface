namespace DotNet_Abstract_vs_Interface
{
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

    public class Car : IVehicle
    {
        public void Go()
        {
            throw new System.NotImplementedException();
        }

        public void Stop()
        {
            throw new System.NotImplementedException();
        }
    }
    public class Bike : IVehicle, IRideable
    {
        public void Go()
        {
            throw new System.NotImplementedException();
        }

        public void Ride()
        {
            throw new System.NotImplementedException();
        }

        public void Stop()
        {
            throw new System.NotImplementedException();
        }
    }
}
