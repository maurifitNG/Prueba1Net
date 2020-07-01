using System;
using System.Collections.Generic;
using System.Text;

namespace aplicacion.Clases
{
    class Estanque: VehiculoComponente
    {
        //retorne un booleano en el caso de que los litros sean mayores a 10.5 % de la capacidad 
            // y menor o igual al 50.0 % de la capacidad.
        public float litros { get; set; }
        public int capacidad { get; set; }

        public bool mitadCombustible(){
            //(2/10) * 100 sacar porcentaje ej
            if ((litros/capacidad) * 100 > 10.5 && (litros / capacidad) * 100 <= 50) {
                return true;
            } else {
                return false;
            }

        }
        public bool bajoCombustible() {
            if ((litros / capacidad) * 100 <= 10.5 ) {
                return true;
            } else {
                return false;
            }
        }
    
    }
}
