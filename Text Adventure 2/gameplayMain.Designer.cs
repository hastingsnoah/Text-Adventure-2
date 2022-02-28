
namespace Text_Adventure_2
{
    partial class gameplayMain
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
            this.nextStory = new System.Windows.Forms.Button();
            this.storyBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nextStory
            // 
            this.nextStory.Location = new System.Drawing.Point(325, 203);
            this.nextStory.Name = "nextStory";
            this.nextStory.Size = new System.Drawing.Size(75, 23);
            this.nextStory.TabIndex = 1;
            this.nextStory.Text = "Continue";
            this.nextStory.UseVisualStyleBackColor = true;
            this.nextStory.Click += new System.EventHandler(this.nextStory_Click);
            // 
            // storyBox
            // 
            this.storyBox.FormattingEnabled = true;
            this.storyBox.Location = new System.Drawing.Point(191, 24);
            this.storyBox.Name = "storyBox";
            this.storyBox.Size = new System.Drawing.Size(356, 173);
            this.storyBox.TabIndex = 2;
            // 
            // gameplayMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.storyBox);
            this.Controls.Add(this.nextStory);
            this.Name = "gameplayMain";
            this.Text = "gameplayMain";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button nextStory;
        private System.Windows.Forms.ListBox storyBox;
    }
}