using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Text_Adventure_2
{
    public partial class gameplayMain : Form
    {
        public gameplayMain()
        {
            InitializeComponent();
            string f = "playerStats.txt";
            //Import Player stats from saved Text file
            List<string> playerStats = System.IO.File.ReadAllLines(@"playerStats.txt").ToList();

            
            
            if (playerStats[0]=="n")
            {
                //Read through intro Text file/ play video if we're feeling extra.
                const string intro = "introText.txt";
                List<string> introText = System.IO.File.ReadAllLines(@"introText.txt").ToList();
                foreach (string line in   introText)
                {

                    storyBox.Items.Add(line);
                    
                }
                nextStory.Visible = true;
                // set intro completion to y
                playerStats[0] = "y";
                nextStory.Visible = true;
            }
            else
            {
                this.Hide();

            }
            
                
                
        }

        private void nextStory_Click(object sender, EventArgs e)
        {
            storyBox.Visible = false;
            nextStory.Visible = false;
        }
    }
}
