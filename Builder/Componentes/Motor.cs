using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUILDER.Componentes
{
    public class Motor
    {
        private int power;
        public Motor(int power)
        {
            this.Power = power;
        }

        public int Power {
            get => power; 
            set => power = value;
        }

    }
}
