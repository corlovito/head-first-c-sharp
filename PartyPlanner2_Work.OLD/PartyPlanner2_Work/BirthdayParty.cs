using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner2_Work
{
    class BirthdayParty : Party
    {
        public BirthdayParty(string cakeWriting, bool fancyDecorations, int numberOfPeople)
            : base(numberOfPeople, fancyDecorations)
        {
            this.CakeWriting = cakeWriting;
//            this.FancyDecorations = fancy;
//            this.NumberOfPeople = numberOfPeople;
        }

//        const int costOfFoodPerPerson = 25;
        const int costOfSmallCake = 40;
        const int costOfLargeCake = 75;

        //private decimal costOfDecorations;

        private string _cakeWriting;
//        private decimal _numberOfPeople;
//        private bool _fancyDecorations;
        
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

        //public decimal NumberOfPeople 
        //{
        //    get { return _numberOfPeople; }
        //    set
        //    {
        //        _numberOfPeople = value;
        //        calculateCostOfDecorations();
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



        //private void calculateCostOfDecorations()
        //{
        //    if (this.FancyDecorations) costOfDecorations = (this.NumberOfPeople * 15.00M) + 50M;
        //    else costOfDecorations = (this.NumberOfPeople * 7.50M) + 30M;
        //}

        public override decimal CalculateCost()
        {
            decimal cakeCost;

            if (this.NumberOfPeople <= 4)
                cakeCost = costOfSmallCake + (CakeWriting.Length * 0.25M);
            else
                cakeCost = costOfLargeCake + (CakeWriting.Length * 0.25M);
            return base.CalculateCost() + cakeCost;
        }

        

    }
}
