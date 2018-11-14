using MaterialsManagement.UI.CustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialsManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            mainPanel.Controls.Add(new QkUC());
            
        }
    }
}
