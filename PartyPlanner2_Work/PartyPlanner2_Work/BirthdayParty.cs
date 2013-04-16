using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner2_Work
{
    class BirthdayParty
    {
        public BirthdayParty(string cakeWriting)
        {
            this.CakeWriting = cakeWriting;
        }

        const int costOfFoodPerPerson = 25;
        const int costOfSmallCake = 40;
        const int costOfLargeCake = 75;

        private decimal costOfDecorations;

        private string _cakeWriting;
        private decimal _numberOfPeople;
        private bool _fancyDecorations;
        
        public string CakeWriting
        {
            get { return _cakeWriting; }
            set
            {
                if (this.NumberOfPeople <= 4)   // small cake
                    if (value.Length > 16)
                        System.Windows.Forms.MessageBox.Show("8-inch cake may contain no more than 16 characters");
                    else
                        _cakeWriting = value;
                else                            // large cake
                    if (value.Length > 40)
                        System.Windows.Forms.MessageBox.Show("16-inch cake may contain no more than 40 characters");
                    else
                        _cakeWriting = value;
            }
        }

        public decimal NumberOfPeople 
        {
            get { return _numberOfPeople; }
            set
            {
                _numberOfPeople = value;
                calculateCostOfDecorations();
            }
        }

        public bool FancyDecorations
        {
            get { return _fancyDecorations; }
            set
            {
                _fancyDecorations = value;
                calculateCostOfDecorations();
            }
        }



        private void calculateCostOfDecorations()
        {
            if (this.FancyDecorations) costOfDecorations = (this.NumberOfPeople * 15.00M) + 50M;
            else costOfDecorations = (this.NumberOfPeople * 7.50M) + 30M;
        }

        public decimal CalculateCost()
        {
            decimal totalCost = costOfDecorations + (( + costOfFoodPerPerson) * NumberOfPeople);

            if (this.NumberOfPeople <= 4)
                return totalCost + costOfSmallCake + (CakeWriting.Length * 0.25M);
            else
                return totalCost + costOfLargeCake + (CakeWriting.Length * 0.25M);
        }

        

    }
}
