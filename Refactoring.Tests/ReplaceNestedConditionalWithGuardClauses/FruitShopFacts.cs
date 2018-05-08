using Refactoring.ReplaceNestedConditionalWithGuardClauses;
using Xunit;

namespace Refactoring.Tests.ReplaceNestedConditionalWithGuardClauses
{
    public class FruitShopFacts
    {
        [Theory]
        [InlineData(null, null)]
        [InlineData(null, FruitType.Watermelon)]
        [InlineData(FruitType.Pomelo, FruitType.Pomelo)]
        [InlineData(FruitType.Grape, FruitType.Grape)]
        [InlineData(FruitType.Orange, FruitType.Orange)]
        [InlineData(FruitType.Pomelo, FruitType.Pomelo, FruitType.Grape, FruitType.Orange)]
        [InlineData(FruitType.Grape, FruitType.Grape, FruitType.Orange)]
        [InlineData(FruitType.Orange, FruitType.Orange, FruitType.Watermelon)]
        void should_buy_something(FruitType? expected, params FruitType[] fruitTypes)
        {
            Assert.Equal(expected, new FruitShop(fruitTypes).WhatShouldBuy());
        }
    }
}
