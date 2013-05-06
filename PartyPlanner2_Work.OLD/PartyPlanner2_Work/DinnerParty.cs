using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner2_Work
{
    class DinnerParty : Party
    {
        // Constructor
        public DinnerParty(bool healthyOption, bool fancyDecorations, int numberOfPeople)
            : base(numberOfPeople, fancyDecorations)
        {
//            this.NumberOfPeople = numberOfPeople;
//            this.FancyDecorations = fancyDecorations;
            this.HealthyOption = healthyOption;
        }

        const int CostOfFoodPerPerson = 25;

        // Fields

        private decimal costOfBeveragesPerPerson;
        
        //private decimal CostOfDecorations = 0;

        // Backing fields
//        private int _numberOfPeople;
//        private bool _fancyDecorations;
        private bool _healthyOption;

        //public int NumberOfPeople 
        //{
        //    get { return _numberOfPeople; }
        //    set
        //    {
        //        _numberOfPeople = value;
        //        CalculateCostOfDecorations();
        //    }
        //}

        //public bool FancyDecorations
        //{
        //    get { return _fancyDecorations; }
        //    set
        //    {
        //        _fancyDecorations = value;
        //        CalculateCostOfDecorations();
        //    }
        //}

        public bool HealthyOption
        {
            set
            {
                if (value)
                {
                    costOfBeveragesPerPerson = 5.00M;
                    _healthyOption = true;
                }
                else
                {
                    costOfBeveragesPerPerson = 20.00M;
                    _healthyOption = false;
                }
            }
            get
            {
                return _healthyOption;
            }
        }
        
        //public void CalculateCostOfDecorations()
        //{
        //    if (this.FancyDecorations) CostOfDecorations = (this.NumberOfPeople * 15.00M) + 50M;
        //    else CostOfDecorations = (this.NumberOfPeople * 7.50M) + 30M;
        //}

        public override decimal CalculateCost()
        {
            decimal totalCost = base.CalculateCost() + (costOfBeveragesPerPerson * NumberOfPeople);

            if (HealthyOption)
                return totalCost * 0.95M;   // 5% discount applied
            else
                return totalCost;
        }



    }
}
