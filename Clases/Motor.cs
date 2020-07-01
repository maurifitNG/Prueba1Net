using System;
using System.Collections.Generic;
using System.Text;

namespace aplicacion.Clases
{
    class Motor : VehiculoComponente
    {
        public string tipo { get; set; }
        public int id { get; set; }
        public float cilindrada { get; set; }
    }
}
