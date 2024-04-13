using ClaseObjetos2.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseObjetos2.ClaseHijo
{
    internal class Playstation:ClsConsola
    {
        public string ModeloControlador {  get; set; }
        public string MostrarDetallePlay()
        {
            return MostrarDetalles() + "Controlador:" + ModeloControlador;
        }
    }
}
