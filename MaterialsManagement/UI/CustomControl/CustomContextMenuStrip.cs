using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialsManagement.UI.CustomControl
{
    public partial class CustomContextMenuStrip<T> : System.Windows.Forms.ContextMenuStrip
    {
        public T obj { get; set; }

        public CustomContextMenuStrip()
        {
        }
    }
}
