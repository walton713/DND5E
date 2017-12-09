namespace DND5E
{
    partial class Main
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
            this.characterCreateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // characterCreateBtn
            // 
            this.characterCreateBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.characterCreateBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.characterCreateBtn.Location = new System.Drawing.Point(101, 67);
            this.characterCreateBtn.Name = "characterCreateBtn";
            this.characterCreateBtn.Size = new System.Drawing.Size(181, 57);
            this.characterCreateBtn.TabIndex = 0;
            this.characterCreateBtn.Text = "Create Character";
            this.characterCreateBtn.UseVisualStyleBackColor = false;
            this.characterCreateBtn.Click += new System.EventHandler(this.characterCreateBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1496, 800);
            this.Controls.Add(this.characterCreateBtn);
            this.Name = "Main";
            this.Text = "DND5E";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button characterCreateBtn;
    }
}

