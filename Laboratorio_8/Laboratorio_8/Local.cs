using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8
{
    [Serializable]
    public abstract class Local
    {
        public string Dueño { get; set; }
        public string Horario { get; set; }
        public int ID { get;set; }

        public  abstract string ShowInfo();
    }
}
