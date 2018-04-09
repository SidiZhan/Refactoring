using System;
using Refactoring.Conditional_ConsolidateConditionalExpression;
using Xunit;

namespace Refactoring.Tests.Conditional_ConsolidateConditionalExpression
{
    public class ZooTicketPriceCalculatorFacts
    {
        [Fact]
        public void should_return_summer_ticket_price()
        {
            var calculator = new ZooTicketPriceCalculator();
            var ticketPrice = calculator.GetTicketPrice(new DateTime(2018, 8, 4), 1);
            Assert.Equal(ticketPrice, 30);
        }

        [Fact]
        public void should_return_winter_ticket_price()
        {
            var calculator = new ZooTicketPriceCalculator();
            var ticketPrice = calculator.GetTicketPrice(new DateTime(2018, 4, 4), 1);
            Assert.Equal(ticketPrice, 22);
        }

    }
}
