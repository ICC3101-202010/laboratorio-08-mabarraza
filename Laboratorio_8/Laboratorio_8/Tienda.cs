using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8
{
    [Serializable]
    public class Tienda : Local
    {
        public string Tipo { get; set; }
        public Tienda(string Dueño, string Horario, int ID,string Tipo)
        {
            this.Dueño = Dueño;
            this.Horario = Horario;
            this.ID = ID;
            this.Tipo = Tipo;
        }

        public override string ShowInfo()
        {
            return "Dueño:" + Dueño + "//" + "Horario:" + Horario + "//" + "ID:" + ID + "//" + "Tipo:" + Tipo + "\n";
        }
    }
}
