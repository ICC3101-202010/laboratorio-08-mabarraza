using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8
{
    [Serializable]
    public class Cine : Local
    {
        public int Nsalas { get; set; }
        public Cine(string Dueño, string Horario, int ID , int Nsalas)
        {
            this.Dueño = Dueño;
            this.Horario = Horario;
            this.ID = ID;
            this.Nsalas = Nsalas;
        }

        public override string ShowInfo()
        {
            return "Dueño:" + Dueño + "//" + "Horario:" + Horario + "//" + "ID:" + ID  + "//" + "Numero de salas:" + Nsalas +  "\n";
        }
    }
}
