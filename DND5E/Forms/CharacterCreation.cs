using DND5E.Utils;
using System.Windows.Forms;

namespace DND5E
{
    public partial class CharacterCreation : Form
    {
        DiceRoller dr;

        public CharacterCreation()
        {
            InitializeComponent();
            dr = new DiceRoller();
        }

        private void abilityScoresBtn_Click(object sender, System.EventArgs e)
        {
            abilityScoreTextOne.Text = dr.RollAbilityScore().ToString();
            abilityScoreTextTwo.Text = dr.RollAbilityScore().ToString();
        }
    }
}
