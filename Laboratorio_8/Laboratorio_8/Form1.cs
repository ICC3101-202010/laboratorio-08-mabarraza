using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_8
{
    public partial class Form1 : Form
    {
        Form2 Storetypes;
        List<Panel> stackpanels = new List<Panel>();
        Dictionary<string, Panel> panels = new Dictionary<string, Panel>();
        public delegate void FormsEventHandler(object source, FormsEventArgs args);
        public delegate void SearchEventHandler(object source , SearchEventArgs args);
        public event FormsEventHandler AllStoresWindowOpen;
        public event SearchEventHandler SSButtonClicked;
        public Form1(Form2 Storetypes)
        {
            InitializeComponent();
            panels.Add("MainPanel",MainPanel);
            panels.Add("SSPanel",SSPanel);
            stackpanels.Add(panels["MainPanel"]);
            ShowLastPanel();
            this.Storetypes = Storetypes as Form2;
        }

        private void NewStoreButton_Click(object sender, EventArgs e)
        {
            Storetypes.ShowDialog();
        }

        private void StoreFinderButton_Click(object sender, EventArgs e)
        {
            stackpanels.Add(panels["SSPanel"]);
            ShowLastPanel();
        }

        private void EveryStoreButton_Click(object sender, EventArgs e)
        {
            OnAllStoresWindowOpen();
        }

        protected virtual void OnAllStoresWindowOpen()
        {
            if (AllStoresWindowOpen != null)
            {
                AllStoresWindowOpen(this, new FormsEventArgs());
            }
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

        private void SSButton_Click(object sender, EventArgs e)
        {
            if (SSTextBox.Text == "")
                MessageBox.Show("Porfavor rellene el campo");
            else
            {
                OnSSButtonClicked(SSTextBox.Text);
                SSTextBox.ResetText();
                stackpanels.RemoveAt(stackpanels.Count - 1);
                ShowLastPanel();
            }
        }

        protected virtual void OnSSButtonClicked(string info)
        {
            if(SSButtonClicked != null)
            {
                SSButtonClicked(this,new SearchEventArgs() {info = info });
            }
        }
    }
}
