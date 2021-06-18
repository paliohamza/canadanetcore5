using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiDemo.Services
{
    public class VisiteursCompteurPriv : IVisiteursCompteur
    {
        public int counter { get; set; }
        public int getCounter()
        {
            counter+=2;
            return counter;
        }
    }
}
