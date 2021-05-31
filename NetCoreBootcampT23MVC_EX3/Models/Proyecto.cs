using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBootcampT23MVC_EX3.Models
{
    public class Proyecto
    {
        public const int MAXIDLENGTH = 4;
        public const int MAXNOMBRELENGTH = 255;
        public Proyecto() { }
        public Proyecto(string id, string nombre, int horas)
        {
            Id = id;
            Nombre = nombre;
            Horas = horas;
        }

        public string Id { get; set; }
        public string Nombre { get; set; }
        public int Horas { get; set; }
        public override string ToString()
        {
            return string.IsNullOrEmpty(Nombre)?"Empty":Nombre;
        }
    }
}
