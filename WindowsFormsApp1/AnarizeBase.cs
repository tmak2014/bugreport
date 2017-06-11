using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AnarizeBase : Form
    {
        private string _report;
        public AnarizeBase(String fileName)
        {
            InitializeComponent();
            string report = System.IO.File.ReadAllText(@fileName);
            _report = report;
            // System.Console.WriteLine("Contents of file = {0}", report);
        }
            
    }
}
