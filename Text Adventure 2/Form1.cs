using System;
using System.IO;
using System.Windows.Forms;
namespace Text_Adventure_2
{
    /**
* 02/25/2022
* CSC 153
* Noah Hastings
* Second part of text adventure assignment. After this project, there should no longer be any information hardcoded into your program. You will need to create a text file that holds all the information. You may do this in a CSV file or any format you wish.
When the Game starts it should load all the information. Then allow the user to create a player that will then be written to a file with the player’s name.

    This program does exactly that, though missing the gameplay. However, functional gameplay is not required according to this prompt provided.
*/
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            newGame.Visible = false;
            loadButton.Visible = false;

            mainMenuButton.Visible = true;
            areYouSure.Visible = true;
            confirmNewGame.Visible = true;


        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            newGame.Visible = true;
            loadButton.Visible = true;
            nameInput.Visible = false;
            nameLabel.Visible = false;
            mainMenuButton.Visible = false;
            saveName.Visible = false;
            confirmNewGame.Visible = false;
        }

        private void saveName_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            outputFile = File.CreateText("PlayerStats.txt");

            //1 intro completed? y/n
            outputFile.WriteLine("n");
            //2 Char Name
            outputFile.WriteLine(nameInput.Text);
            //3 Level
            outputFile.WriteLine("1");
            //4 HP
            outputFile.WriteLine("8");
            //5 AC
            outputFile.WriteLine("16");


            outputFile.Close();
            // Open new game form
            this.Hide();
            gameplayMain f2 = new gameplayMain();
            f2.ShowDialog();

        }

        private void confirmNewGame_Click(object sender, EventArgs e)
        {
            saveName.Visible = true;
            nameInput.Visible = true;
            areYouSure.Visible = false;
            nameLabel.Visible = true;
            confirmNewGame.Visible = false;
            saveName.Visible = true;

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            gameplayMain f2 = new gameplayMain();
            f2.ShowDialog();

        }
    }
}
