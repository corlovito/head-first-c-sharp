using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlannerFixedCh5
{
    class DinnerParty
    {
        const int CostOfFoodPerPerson = 25;

        // Fields
        private decimal costOfBeveragesPerPerson;
        private decimal CostOfDecorations = 0;

        // Backing fields
        private int numberOfPeople;
        private bool fancyDecorations;
        private bool healthyOption;

        // Constructor
        public DinnerParty(bool healthyOption, bool fancyDecorations, int numberOfPeople)
        {
            this.NumberOfPeople = numberOfPeople;
            this.FancyDecorations = fancyDecorations;
            this.HealthyOption = healthyOption;
        }

        public int NumberOfPeople 
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations();
            }
        }

        public bool FancyDecorations
        {
            get { return fancyDecorations; }
            set
            {
                fancyDecorations = value;
                CalculateCostOfDecorations();
            }
        }

        public bool HealthyOption
        {
            set
            {
                if (value)
                {
                    costOfBeveragesPerPerson = 5.00M;
                    healthyOption = true;
                }
                else
                {
                    costOfBeveragesPerPerson = 20.00M;
                    healthyOption = false;
                }
            }
        }
        
        public void CalculateCostOfDecorations()
        {
            if (fancyDecorations) CostOfDecorations = (numberOfPeople * 15.00M) + 50M;
            else CostOfDecorations = (numberOfPeople * 7.50M) + 30M;
        }

        public decimal CalculateCost()
        {
            decimal totalCost = CostOfDecorations + ((costOfBeveragesPerPerson + CostOfFoodPerPerson) * numberOfPeople);

            if (healthyOption)
                return totalCost * 0.95M;   // 5% discount applied
            else
                return totalCost;
        }



    }
}
