using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            if (MyBet != null)
                MyLabel.Text = MyBet.GetDescription();
            else
                MyLabel.Text = Name + " hasn't placed a bet";
            MyRadioButton.Text = Name + " has " + Cash + " bucks"; ;
        }

        public void ClearBet() 
        {
            MyBet.Amount = 0;
            UpdateLabels();
        }

        public bool PlaceBet(int Amount, int Dog)
        {
            if (Cash >= Amount)
            {
                MyBet = new Bet() { Amount = Amount, Bettor = this, Dog = Dog };
                UpdateLabels();
                return true;
            }
            else
            {
                UpdateLabels();
                return false;
            }
        }

        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
        }
    }
}
