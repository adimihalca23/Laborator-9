using System;

namespace Laborator_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex1();
        }

        public static void Ex1()
        {
            Autovehicul autovehicul1 = new Autoturism("Tesla", "Model 3", new MotorElectric(), 5);
            Autovehicul autovehicul2 = new Autoturism("Volkswagen", "i8", new MotorHibrid(), 5);
            Autovehicul autovehicul3 = new Cisterna("Roman", "Jet A1", new MotorDiesel());
            Autovehicul autovehicul4 = new Camion("Volvo", "FM  460", new MotorDiesel());

            autovehicul1.Porneste();
            autovehicul2.Porneste();
            autovehicul3.Porneste();
            autovehicul4.Porneste();

            Console.WriteLine(autovehicul1);
            Console.WriteLine(autovehicul2);
            Console.WriteLine(autovehicul3);
            Console.WriteLine(autovehicul4);
        }
    }
}
