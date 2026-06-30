using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio_
{
    public class HabitacionException : Exception
    {
        public HabitacionException(int Numero)
            : base ($"La Habitacion {Numero} esta ocupada")
        {

        }
    }
}
