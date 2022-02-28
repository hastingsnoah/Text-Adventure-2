using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Adventure_2
{
    public partial class actualGameplay : Form
    {
        // This area of code is still under development
        public actualGameplay()
        {
            InitializeComponent();
            string f = "playerStats.txt";
            //Import Player stats from saved Text file
            List<string> playerStats = System.IO.File.ReadAllLines(@"playerStats.txt").ToList();
        }
    }
}
