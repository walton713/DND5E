using System;
using System.Windows.Forms;

namespace DND5E
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void characterCreateBtn_Click(object sender, EventArgs e)
        {
            Form characterCreationForm = new CharacterCreation();
            characterCreationForm.Show();
        }
    }
}
