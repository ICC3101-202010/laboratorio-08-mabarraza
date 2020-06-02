using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Net.Mail;
using System.Drawing;
using System.Drawing.Text;

namespace Laboratorio_8
{
    class LocalController
    {
        List<Local> Mall = new List<Local>();
        Form1 form1;
        Form2 form2;

        public LocalController(Form1 form1 , Form2 form2 ) 
        {
            this.form1 = form1 as Form1;
            this.form2 = form2 as Form2;
            this.form2.AddButtonClicked += OnAddButtonClicked;
            this.form2.CAddButtonClicked += OnCAddButtonClicked;
            this.form2.RAddButtonClicked += OnRAddButtonClicked;
            this.form2.REAddButtonClicked += OnReAddButtonClicked;
            this.form1.AllStoresWindowOpen += OnAllStoresWindowOpen;
            this.form1.SSButtonClicked += OnSSButtonClicked;
        }

        private  void OnAddButtonClicked(object server , StoresEventArgs e)
        {
            int idusado=0;
            foreach(Local local in Mall)
            {
                if (e.NTienda.ID == local.ID)
                {
                    idusado = 1;
                }
            }
            if (idusado == 0)
            {
                Mall.Add(e.NTienda);
                MessageBox.Show("Tienda agregada exitosamente!");
            }
            else
                MessageBox.Show("El ID ingresado ya ha sido usado por favor intente con otro.");
        }
        private void OnCAddButtonClicked(object server , StoresEventArgs e)
        {
            int idusado = 0;
            foreach (Local local in Mall)
            {
                if (e.NCine.ID == local.ID)
                {
                    idusado = 1;
                }
            }
            if (idusado == 0)
            {
                Mall.Add(e.NCine);
                MessageBox.Show("Cine agregado existosamente!");
            }
            else
                MessageBox.Show("El ID ingresado ya ha sido usado por favor intente con otro.");
        }

        private void OnRAddButtonClicked(object server , StoresEventArgs e)
        {
            int idusado = 0;
            foreach (Local local in Mall)
            {
                if (e.NRestaurant.ID == local.ID)
                {
                    idusado = 1;
                }
            }
            if (idusado == 0)
            {
                Mall.Add(e.NRestaurant);
                MessageBox.Show("Restaurant agregado existosamente!");
            }
            else
                MessageBox.Show("El ID ingresado ya ha sido usado por favor intente con otro.");
        }

        private void OnReAddButtonClicked(object server, StoresEventArgs e)
        {
            int idusado = 0;
            foreach (Local local in Mall)
            {
                if (e.NRecreacional.ID == local.ID)
                {
                    idusado = 1;
                }
            }
            if (idusado == 0)
            {
                Mall.Add(e.NRecreacional);
                MessageBox.Show("Recreacional agregado existosamente!");
            }
            else
                MessageBox.Show("El ID ingresado ya ha sido usado por favor intente con otro.");
        }


        private void OnAllStoresWindowOpen(object server , FormsEventArgs e) 
        {
            string tiendas = "";
            if (Mall.Count == 0)
            {
                MessageBox.Show("Aun no se han creado tiendas!");

            }
            else
            {
                foreach(Local local in Mall)
                {
                    tiendas += local.ShowInfo();
                }
                MessageBox.Show(tiendas);
            }
        }

        private void OnSSButtonClicked(object server , SearchEventArgs e)
        {
            string info = "";
            foreach(Local local in Mall)
            {
                if((e.info==local.Dueño)||(e.info==local.Horario))
                    info += local.ShowInfo();
                else {
                    try
                    {
                        if (Convert.ToInt32(e.info) == local.ID)
                        {
                            info += local.ShowInfo();
                        }
                    }
                    catch(SystemException)
                    {
                    }
                }
            }
            if (info == "")
                MessageBox.Show("No se encontraron resultados para su busqueda");
            else
                MessageBox.Show(info);
        }
    }
}
