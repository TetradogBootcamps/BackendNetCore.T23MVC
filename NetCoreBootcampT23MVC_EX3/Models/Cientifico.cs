using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NetCoreBootcampT23MVC_EX3.Models
{
    public class Cientifico
    {
        public const int DNIMAXLENGHT = 8;
        public const int NOMBRECOMPLETOMAXLENGHT = 50;
        public Cientifico() { }
        public Cientifico(string dNI, string nombreCompleto)
        {
            DNI = dNI;
            NombreCompleto = nombreCompleto;
        }
       [Key]
        public string DNI { get; set; }
        public string NombreCompleto { get; set; }
        public override string ToString()
        {
            return string.IsNullOrEmpty(NombreCompleto) ? "Empty" : NombreCompleto;
        }
        public override bool Equals(object obj)
        {
            Cientifico other = obj as Cientifico;
            return !Equals(other, default(Cientifico)) && Equals(DNI, other.DNI);
        }
    }
}
