using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBootcampT23MVC_EX3.Models
{
    public class AsignadoA
    {
        public AsignadoA() { }
        public AsignadoA(Cientifico cientifico, Proyecto proyecto)
        {
            Cientifico = cientifico;
            Proyecto = proyecto;
        }

        public string CientificoId { get; set; }
        public Cientifico Cientifico { get; set; }
        public string ProyectoId { get; set; }
        public Proyecto Proyecto { get; set; }
        public override string ToString()
        {
            return Cientifico.ToString();
        }
    }
}
