using Refactoring.Conditional_ConsolidateConditionalExpression;
using Xunit;

namespace Refactoring.Tests.Conditional_DecomposeConditional
{
    public class TaxCalculatorFacts
    {
        [Theory]
        [InlineData(3, 11, false, 2000)]
        [InlineData(3, 11, true, 0)]
        [InlineData(3, 14, false, 0)]
        [InlineData(1, 1, false, 0)]
        public void should_get_DisabilityAmount(int seniority, int monthsDisabled, bool isPartTime, double expcetedResult)
        {
            var taxCalculator = new TaxCalculator();
            var actualResult = taxCalculator.DisabilityAmount(seniority, monthsDisabled, isPartTime);
            Assert.Equal(actualResult, expcetedResult);
        }
    }
}
