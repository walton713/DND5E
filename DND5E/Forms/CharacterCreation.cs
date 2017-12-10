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
            abilityScoreTextThree.Text = dr.RollAbilityScore().ToString();
            abilityScoreTextFour.Text = dr.RollAbilityScore().ToString();
            abilityScoreTextFive.Text = dr.RollAbilityScore().ToString();
            abilityScoreTextSix.Text = dr.RollAbilityScore().ToString();
        }
    }
}
