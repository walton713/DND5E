namespace DND5E
{
    partial class CharacterCreation
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
            this.abilityScoresBtn = new System.Windows.Forms.Button();
            this.abilityScoreTextOne = new System.Windows.Forms.TextBox();
            this.abilityScoreTextTwo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // abilityScoresBtn
            // 
            this.abilityScoresBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.abilityScoresBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.abilityScoresBtn.Location = new System.Drawing.Point(32, 26);
            this.abilityScoresBtn.Name = "abilityScoresBtn";
            this.abilityScoresBtn.Size = new System.Drawing.Size(112, 46);
            this.abilityScoresBtn.TabIndex = 0;
            this.abilityScoresBtn.Text = "Roll Ability Scores";
            this.abilityScoresBtn.UseVisualStyleBackColor = false;
            this.abilityScoresBtn.Click += new System.EventHandler(this.abilityScoresBtn_Click);
            // 
            // abilityScoreTextOne
            // 
            this.abilityScoreTextOne.BackColor = System.Drawing.SystemColors.Window;
            this.abilityScoreTextOne.Enabled = false;
            this.abilityScoreTextOne.Location = new System.Drawing.Point(32, 90);
            this.abilityScoreTextOne.Name = "abilityScoreTextOne";
            this.abilityScoreTextOne.Size = new System.Drawing.Size(45, 20);
            this.abilityScoreTextOne.TabIndex = 2;
            // 
            // abilityScoreTextTwo
            // 
            this.abilityScoreTextTwo.BackColor = System.Drawing.SystemColors.Window;
            this.abilityScoreTextTwo.Enabled = false;
            this.abilityScoreTextTwo.Location = new System.Drawing.Point(32, 116);
            this.abilityScoreTextTwo.Name = "abilityScoreTextTwo";
            this.abilityScoreTextTwo.Size = new System.Drawing.Size(45, 20);
            this.abilityScoreTextTwo.TabIndex = 3;
            // 
            // CharacterCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1313, 771);
            this.Controls.Add(this.abilityScoreTextTwo);
            this.Controls.Add(this.abilityScoreTextOne);
            this.Controls.Add(this.abilityScoresBtn);
            this.Name = "CharacterCreation";
            this.Text = "Character Creation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button abilityScoresBtn;
        private System.Windows.Forms.TextBox abilityScoreTextOne;
        private System.Windows.Forms.TextBox abilityScoreTextTwo;
    }
}