﻿using ClaseObjetos2.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseObjetos2.ClaseHijo
{
    internal class Nintendo:ClsConsola
    {
        public bool esPortable { get; set; }

        public string MostrarDetalleNintendo()
        {
            string detallePadre = MostrarDetalles();
            return detallePadre + " Es portable" + esPortable;
        }
    }
}
