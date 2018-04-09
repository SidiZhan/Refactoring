namespace Refactoring.Conditional_ConsolidateConditionalExpression
{
    public class TaxCalculator
    {
        public double DisabilityAmount(int seniority, int monthsDisabled, bool isPartTime)
        {
            if (seniority < 2) return 0;
            if (monthsDisabled > 12) return 0;
            if (isPartTime) return 0;
            return GetRegularAmount();
        }

        double GetRegularAmount()
        {
            // some other codes.
            return 2000;
        }

        public double GetRate()
        {
            if (OnVocation())
            {
                if (LengthOfService() > 10)
                {
                    return 1;
                }
            }
            return 0.5;
        }


        private int LengthOfService()
        {
            // some other code
            return 0;
        }

        private bool OnVocation()
        {
            // some other code
            return false;
        }
    }
}
