using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8
{
    public class StoresEventArgs : EventArgs
    {
        public Tienda NTienda { get; set; }
        public Cine NCine { get; set; }
        public Restaurant NRestaurant { get ; set;}
        public Recreacional NRecreacional { get; set; }
    }
}
