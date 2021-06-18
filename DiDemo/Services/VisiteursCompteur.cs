using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiDemo.Services
{
    public class VisiteursCompteur : IVisiteursCompteur
    {
        public int counter { get; set; }
        public int getCounter()
        {
            counter++;
            return counter;
        }
    }
}
