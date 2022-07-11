using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_9
{
    abstract class Autoutilitara : Autovehicul
    {
        private readonly int capacitateMaxima;

        public Autoutilitara(string producator, string model, MotorDiesel motor, int capacitateMaxima) : base(producator, model, motor)
        {
            this.capacitateMaxima = capacitateMaxima;
        }

        public int CapacitateMaxima { get {return capacitateMaxima;} }

        public abstract void IncarcaMarfa(int cantitateMarfa);
    }
}
