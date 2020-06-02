using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_8
{
    public partial class Form2 : Form
    {
        List<Panel> stackpanels = new List<Panel>();
        Dictionary<string, Panel> panels = new Dictionary<string, Panel>();
        string privatetable = null;
        public delegate void StoresEventHandler(object source , StoresEventArgs args );
        public event StoresEventHandler AddButtonClicked;
        public event StoresEventHandler CAddButtonClicked;
        public event StoresEventHandler RAddButtonClicked;
        public event StoresEventHandler REAddButtonClicked;
        public Form2()
        {
            InitializeComponent();
            panels.Add("StoreTypesPanel",NewStorePanel);
            panels.Add("TiendaPanel",TiendaPanel);
            panels.Add("CinePanel",CinePanel);
            panels.Add("RestaurantPanel", RestaurantPanel);
            panels.Add("RecreacionalPanel",RecreacionalPanel);
            stackpanels.Add(panels["StoreTypesPanel"]);
            ShowLastPanel();
        }

        private void TiendaButton_Click(object sender, EventArgs e)
        {
            stackpanels.Add(panels["TiendaPanel"]);
            ShowLastPanel();
        }
        

        public void ShowLastPanel()
        {
            foreach (Panel panel in panels.Values)
            {
                if (panel != stackpanels.Last())
                {
                    panel.Visible = false;
                }
                else
                {
                    panel.Visible = true;
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((DueñoTextBox.Text != "")&&(HorarioTextBox.Text!="")&&(IDTextBox.Text!="")&&(TipoTextBox.Text!=""))
                {
                    OnAddButtonClicked(DueñoTextBox.Text, HorarioTextBox.Text, Convert.ToInt32(IDTextBox.Text), TipoTextBox.Text);
                    DueñoTextBox.ResetText();
                    HorarioTextBox.ResetText();
                    IDTextBox.ResetText();
                    TipoTextBox.ResetText();
                    stackpanels.RemoveAt(stackpanels.Count - 1);
                }
                else
                    MessageBox.Show("Porfavor rellene los campos");
            }
            catch(SystemException)
            {
                MessageBox.Show("Error, el valor del ID es numerico.");
            }
            ShowLastPanel();
        }

        protected virtual void OnAddButtonClicked(string Dueño, string Horario, int ID, string tipo)
        {
            if (AddButtonClicked != null)
            {
                AddButtonClicked(this, new StoresEventArgs() { NTienda = new Tienda(Dueño, Horario, ID, tipo)});
            }
        }

        private void CineButton_Click(object sender, EventArgs e)
        {
            stackpanels.Add(panels["CinePanel"]);
            ShowLastPanel();
        }

        protected virtual void OnCAddButtonClicked(string Dueño , string Horario , int ID , int Salas)
        {
            if(CAddButtonClicked != null)
            {
                CAddButtonClicked(this,new StoresEventArgs() { NCine = new Cine(Dueño,Horario,ID,Salas)});
            }
        }

        private void CAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((CDueñoTextBox.Text != "") && (CHorarioTextBox.Text != "") && (CIDTextBox.Text != "") && (NSalasTextBox.Text != ""))
                {
                    OnCAddButtonClicked(CDueñoTextBox.Text, CHorarioTextBox.Text, Convert.ToInt32(CIDTextBox.Text), Convert.ToInt32(NSalasTextBox.Text));
                    CDueñoTextBox.ResetText();
                    CHorarioTextBox.ResetText();
                    CIDTextBox.ResetText();
                    NSalasTextBox.ResetText();
                    stackpanels.RemoveAt(stackpanels.Count - 1);
                }
                else
                    MessageBox.Show("Porfavor rellene los campos");
            }
            catch (SystemException)
            {
                MessageBox.Show("Error, el valor del ID es numerico.");
            }
            ShowLastPanel();
        }

        private void YButton_Click(object sender, EventArgs e)
        {
            privatetable = "Si.";
        }

        private void NButton_Click(object sender, EventArgs e)
        {
            privatetable = "No.";
        }

        private void RAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((privatetable != null)&&(RDueñoTextBox.Text != "") && (RHorarioTextBox.Text != "") && (RIDTextBox.Text != ""))
                {
                    OnRAddButtonClicked(RDueñoTextBox.Text, RHorarioTextBox.Text, Convert.ToInt32(RIDTextBox.Text), privatetable);
                    privatetable = null;
                    RDueñoTextBox.ResetText();
                    RHorarioTextBox.ResetText();
                    RIDTextBox.ResetText();
                    stackpanels.RemoveAt(stackpanels.Count - 1);
                }
                else if (privatetable == null)
                    MessageBox.Show("Elija una de las opciones.");
                else
                    MessageBox.Show("Porfavor rellene los campos");
            }
            catch (SystemException)
            {
                MessageBox.Show("Error, el valor del ID es numerico.");
            }
            ShowLastPanel();
        }

        protected virtual void OnRAddButtonClicked(string Dueño , string Horario , int ID , string Mesas)
        {
            if(RAddButtonClicked != null)
            {
                RAddButtonClicked(this,new StoresEventArgs() {NRestaurant = new Restaurant(Dueño , Horario , ID , Mesas)});
            }
        }

        private void RestaurantButton_Click(object sender, EventArgs e)
        {
            stackpanels.Add(panels["RestaurantPanel"]);
            ShowLastPanel();
        }

        private void RecreacionalButton_Click(object sender, EventArgs e)
        {
            stackpanels.Add(panels["RecreacionalPanel"]);
            ShowLastPanel();
        }

        private void REAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((REDueñoTextBox.Text != "") && (REHorarioTextBox.Text != "") && (REIDTextBox.Text != ""))
                {
                    OnREAddButtonClicked(REDueñoTextBox.Text, REHorarioTextBox.Text, Convert.ToInt32(REIDTextBox.Text));
                    REDueñoTextBox.ResetText();
                    REHorarioTextBox.ResetText();
                    REIDTextBox.ResetText();
                    stackpanels.RemoveAt(stackpanels.Count - 1);
                }
                else
                    MessageBox.Show("Porfavor rellene los campos");
            }
            catch (SystemException)
            {
                MessageBox.Show("Error, el valor del ID es numerico.");
            }
            ShowLastPanel();
        }

        protected virtual void OnREAddButtonClicked(string Dueño , string Horario , int ID)
        {
            if (REAddButtonClicked != null) 
            {
                REAddButtonClicked(this, new StoresEventArgs() { NRecreacional = new Recreacional(Dueño , Horario , ID)});
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            stackpanels.Clear();
            stackpanels.Add(panels["StoreTypesPanel"]);
            ShowLastPanel();
        }
    }
}
