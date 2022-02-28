
namespace Text_Adventure_2
{
    partial class mainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadButton = new System.Windows.Forms.Button();
            this.newGame = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.saveName = new System.Windows.Forms.Button();
            this.confirmNewGame = new System.Windows.Forms.Button();
            this.areYouSure = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(122, 87);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load Game";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // newGame
            // 
            this.newGame.Location = new System.Drawing.Point(226, 87);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(75, 23);
            this.newGame.TabIndex = 1;
            this.newGame.Text = "New Game";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(212, 87);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 2;
            this.nameInput.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(119, 92);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(87, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Character Name:";
            this.nameLabel.Visible = false;
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(226, 113);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(75, 23);
            this.mainMenuButton.TabIndex = 4;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Visible = false;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // saveName
            // 
            this.saveName.Location = new System.Drawing.Point(122, 113);
            this.saveName.Name = "saveName";
            this.saveName.Size = new System.Drawing.Size(75, 23);
            this.saveName.TabIndex = 5;
            this.saveName.Text = "Submit";
            this.saveName.UseVisualStyleBackColor = true;
            this.saveName.Visible = false;
            this.saveName.Click += new System.EventHandler(this.saveName_Click);
            // 
            // confirmNewGame
            // 
            this.confirmNewGame.Location = new System.Drawing.Point(122, 113);
            this.confirmNewGame.Name = "confirmNewGame";
            this.confirmNewGame.Size = new System.Drawing.Size(75, 23);
            this.confirmNewGame.TabIndex = 6;
            this.confirmNewGame.Text = "I\'m Sure";
            this.confirmNewGame.UseVisualStyleBackColor = true;
            this.confirmNewGame.Visible = false;
            this.confirmNewGame.Click += new System.EventHandler(this.confirmNewGame_Click);
            // 
            // areYouSure
            // 
            this.areYouSure.AutoSize = true;
            this.areYouSure.Location = new System.Drawing.Point(97, 90);
            this.areYouSure.Name = "areYouSure";
            this.areYouSure.Size = new System.Drawing.Size(232, 13);
            this.areYouSure.TabIndex = 7;
            this.areYouSure.Text = "Are you sure? This will delete all prior progress...";
            this.areYouSure.Visible = false;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(439, 275);
            this.Controls.Add(this.areYouSure);
            this.Controls.Add(this.confirmNewGame);
            this.Controls.Add(this.saveName);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.loadButton);
            this.Name = "mainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Button saveName;
        private System.Windows.Forms.Button confirmNewGame;
        private System.Windows.Forms.Label areYouSure;
    }
}

