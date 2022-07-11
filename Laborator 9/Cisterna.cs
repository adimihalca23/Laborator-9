using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_9
{
    class Cisterna : Autoutilitara
    {
        private const int capacitateMaxima = 10000;

        public Cisterna(string producator, string model, MotorDiesel motor) : base(producator, model, motor, capacitateMaxima)
        {
        }

        public override void IncarcaMarfa(int cantitateMarfa)
        {
            if(cantitateMarfa > capacitateMaxima)
            {
                Console.WriteLine("Capacitatea maxima este depasita!");
            }
            else
            {
                Console.WriteLine("Marfa a fost incarcata!");
            }
        }

        public override string ToString()
        {
            string descriere = base.ToString();

            return descriere + ", " + capacitateMaxima + "mc";
        }
    }
}
