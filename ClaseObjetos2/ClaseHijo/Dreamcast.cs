using ClaseObjetos2.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseObjetos2.ClaseHijo
{
    internal class Dreamcast:ClsConsola
    {
        public bool Pantallita { get; set; }
        public string Mostrardetalledreamcast()
        {
            return MostrarDetalles + " Tiene pantalla: " + Pantallita;
        }
    }
}
