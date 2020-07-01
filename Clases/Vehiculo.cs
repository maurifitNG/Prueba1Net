using System;
using System.Collections.Generic;
using System.Text;

namespace aplicacion.Clases
{
   abstract class Vehiculo
    {
        public Estanque estanque { get; set; }
        public Mezclador mezclador { get; set; }
        public Motor motor { get; set; }
        public Rueda rueda { get; set; }
    }
}
