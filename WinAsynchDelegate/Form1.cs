using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAsynchDelegate
{
    public partial class Form1 : Form
    {
        private delegate void TimeConsumingMethodDelegate(int seconds);
        public Form1()
        {
            InitializeComponent();
        }
        private void TimeConsumingMethod(int seconds)
        {
            for(int j=1;j<=seconds;j++)
                System.Threading.Thread.Sleep(1000);
        }

    }
}
