using System;
using System.Collections.Generic;
using System.Text;
using NetCoreBootcampT23MVC_EX1;

namespace NetCoreBootcampT23MVC_EX2
{
    public class Video
    {
        public const int MAXTITLE = 250;
        public const int MAXDIRECTOR = 250;
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }

        public Cliente Cliente { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
