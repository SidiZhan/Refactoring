using System.Linq;

namespace Refactoring.ReplaceNestedConditionalWithGuardClauses
{
    public class FruitShop
    {
        readonly FruitType[] fruitTypes;

        public FruitShop(params FruitType[] fruitTypes)
        {
            this.fruitTypes = fruitTypes ?? new FruitType[] { };
        }

        public FruitType? WhatShouldBuy()
        {
            FruitType? type;

            if (fruitTypes.Contains(FruitType.Pomelo))
            {
                type = FruitType.Pomelo;
            }
            else if (fruitTypes.Contains(FruitType.Grape))
            {
                type = FruitType.Grape;
            }
            else if (fruitTypes.Contains(FruitType.Orange))
            {
                type = FruitType.Orange;
            }
            else
            {
                type = null;
            }

            return type;
        }
    }
}
