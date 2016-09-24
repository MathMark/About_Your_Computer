using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AYS.BL;
using AboutYourSystem.Properties;

namespace AboutYourSystem
{
   
    public partial class MainForm : Form,IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
            InfoList.Nodes.Add("System");
            InfoList.Nodes.Add("Drives");
            InfoList.Nodes.Add("Video Adapter");
            InfoList.Nodes.Add("Processor");
            InfoList.Nodes.Add("RAM");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormLoad(this, EventArgs.Empty);
        }

       public string infoList
        {
            set
            {
                InfoList.Nodes.Add(value.ToString());
            }
        }

        public string system
        {
            set
            {
                InfoList.Nodes[0].Nodes.Add(value.ToString());
            }
        }
        public string drives
        {
            set
            {
                InfoList.Nodes[1].Nodes.Add(value.ToString());
            }
        }
        public string VideoAdapter
        {
            set
            {
                InfoList.Nodes[2].Nodes.Add(value.ToString());
            }
        }
        public string Processor
        {
            set
            {
                InfoList.Nodes[3].Nodes.Add(value.ToString());
            }
        }
        public string RAM
        {
            set
            {
                InfoList.Nodes[4].Nodes.Add(value.ToString());
            }
        }
        public event EventHandler FormLoad;
    }
}
