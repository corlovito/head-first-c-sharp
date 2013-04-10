using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlannerCh5
{
    class DinnerParty
    {
        const int CostOfFoodPerPerson = 25;
        private int numberOfPeople;
       
        private decimal CostOfBeveragesPerPerson;
        private decimal CostOfDecorations;

        // added by me
        public void SetPartyOptions(int people, bool fancy)
        {
            numberOfPeople = people;
            CalculateCostOfDecorations(fancy);
        }

        // added by me
        public int GetNumberOfPeople()
        {
            return numberOfPeople;
        }

        public void SetHealthyOption(bool healthyOption) 
        {
            if (healthyOption)
                CostOfBeveragesPerPerson = 5.00M;
            else
                CostOfBeveragesPerPerson = 20.00M;
        }
        
        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
                CostOfDecorations = (numberOfPeople * 15.00M) + 50M;
            else
                CostOfDecorations = (numberOfPeople * 7.50M) + 30M;        
        }
        
        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * numberOfPeople);

            if (healthyOption)
                return totalCost * .95M;
            else
                return totalCost;
        }
    }
}
