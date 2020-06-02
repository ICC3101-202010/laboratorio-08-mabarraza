using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8
{
    [Serializable]
    public class Recreacional : Local
    {
        public Recreacional(string Dueño , string Horario , int ID) 
        {
            this.Dueño = Dueño;
            this.Horario = Horario;
            this.ID = ID;
        }

        public override string ShowInfo()
        {
            return "Dueño:" + Dueño + "//" + "Horario:" + Horario+"//" + "ID:" + ID + "\n";
        }
    }
}
