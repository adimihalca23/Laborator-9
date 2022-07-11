using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_9
{
    abstract class Autovehicul
    {
        private readonly string producator;
        private readonly string model;
        private readonly Motor motor;
        public string Producator{ get { return this.producator; } }
        public string Model { get { return this.model; } }
        public Motor Motor { get { return this.motor; } }

        public Autovehicul(string producator, string model, Motor motor)
        {
            this.producator = producator;
            this.model = model;
            this.motor = motor;
        }

        public virtual void Porneste()
        {
            motor.Porneste();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Autovehicul: {producator}, {model}, {motor}");
            return stringBuilder.ToString();
        }
    }
}
