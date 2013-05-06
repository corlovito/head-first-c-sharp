using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner_Ch6_Mods
{
    abstract class Party
    {
        private decimal costOfDecorations = 0;
        const int CostOfFoodPerPerson = 25;

        public Party(int numberOfPeople, bool fancyDecorations)
        {
            FancyDecorations = fancyDecorations;
            NumberOfPeople = numberOfPeople;
        }

        private int _numberOfPeople;
        public int NumberOfPeople
        {
            get { return _numberOfPeople; }
            set
            {
                _numberOfPeople = value;
                CalculateCostOfDecorations();
            }
        }

        private bool _fancyDecorations;
        public bool FancyDecorations
        {
            get { return _fancyDecorations; }
            set
            {
                _fancyDecorations = value;
                CalculateCostOfDecorations();
            }
        }

        public virtual void CalculateCostOfDecorations()
        {
            if (FancyDecorations) costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
        }

        public virtual decimal CalculateCost()
        {
            decimal totalCost = costOfDecorations + (CostOfFoodPerPerson * NumberOfPeople);

            if (NumberOfPeople > 12)
                return totalCost += 100M;   
            else
                return totalCost;
        }
    }
}
