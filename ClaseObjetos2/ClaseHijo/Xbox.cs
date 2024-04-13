using ClaseObjetos2.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseObjetos2.ClaseHijo
{
    internal class Xbox:ClsConsola
    {
        public bool Kinect {  get; set; }   
        public string MostrardetalleXbox()
        {
            return MostrarDetalles() + " Tiene kinect: " + Kinect;
        }
    }
}
