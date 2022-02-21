using System;

namespace ConsoleApplication
{
    class Name
    {
        public string customer;
        public int brand;
    }

    interface MyInterface
    {
      string customer {get; set; }
      int brand {get; set; }

    }

    class Name : MyInterface
    {
      public string customer {get; set; }
    }

    public class App
    {
      public string Set;
    }


    public class AppSet
    {
      public delegate void AppSetterEventHandler(object source, EventArgss args);

      public event AppSetterEventHandler AppSetter;

      public void ReadyApp(Order order)
      {
          Console.WriteLine($"Preparing your car '{order.Set}, hold on a moment...:) '");
          Thread.Sleep(4000);

          OnAppSetter();
      }

      protected virtual void OnAppSetter()
      {
          if (AppSetter != null)
              AppSetter(this, null);
      }


     }

     public class AppDone
     {
       public void OnAppSetter(object source, EventArgs eventArgs)
       {
         Console.WriteLine("Your car is ready for pickup");
       }
     }


    class Program
    {
        static void Main(string[] args)
        {

            var Supra = new Name{Set = "SuperCar in red"};
            var orderCar = new AppSet();
            var appSer = new AppDone();
            orderCar.AppSetter += appSer.OnAppSetter;
            orderCar.OnAppSetter(name);
            Console.Readkey();
            Supra.customer = "Supra";
            Supra.brand = 1;

            var BMW = new Name();
            BMW.customer = "BMW";
            BMW.brand = 2;

            var Toyota = new Name();
            Toyota.customer = "Toyota";
            Toyota.brand = 3;

        }
    }

}
