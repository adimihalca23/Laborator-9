using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_9
{
    class Autoturism : Autovehicul
    {
        private readonly int nrLocuri;

        public Autoturism(string producator, string model, MotorEco motor, int nrLocuri):base(producator, model, motor)
        {
            this.nrLocuri = nrLocuri;
        }

        public override void Porneste()
        {
            base.Porneste();
            Console.WriteLine("Usile sunt inchise!");
        }

        public override string ToString()
        {
            string descriere = base.ToString();
            return descriere + ", " + nrLocuri + " locuri.";
        }
    }
}
