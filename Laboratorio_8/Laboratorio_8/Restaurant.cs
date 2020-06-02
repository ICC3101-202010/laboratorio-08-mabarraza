using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8
{
    [Serializable]
    public class Restaurant : Local
    {
        public string Tipos_Mesas { get; set; }
        public Restaurant(string Dueño, string Horario, int ID , string Tipos_Mesas)
        {
            this.Dueño = Dueño;
            this.Horario = Horario;
            this.ID = ID;
            this.Tipos_Mesas = Tipos_Mesas;
        }

        public override string ShowInfo()
        {
            return "Dueño:" + Dueño + "//" + "Horario:" + Horario + "//" + "ID:" + ID + "//" +"Mesas Privadas:" + Tipos_Mesas + "\n";
        }
    }
}
