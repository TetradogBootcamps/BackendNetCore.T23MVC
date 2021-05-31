using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBootcampT23MVC_EX3.Models
{
    public class Cientifico
    {
        public Cientifico() { }
        public Cientifico(string dNI, string nombreCompleto)
        {
            DNI = dNI;
            NombreCompleto = nombreCompleto;
        }

        public string DNI { get; set; }
        public string NombreCompleto { get; set; }
        public override string ToString()
        {
            return string.IsNullOrEmpty(NombreCompleto) ? "Empty" : NombreCompleto;
        }
    }
}
