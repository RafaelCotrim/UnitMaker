using System;

namespace UnitMaker.Units
{
    public class UnitFactory
    {
        public static Unit GetBaseUnit(UnitType type)
        {
            switch (type)
            {
                case UnitType.Length:
                    return new SimpleUnit(UnitType.Length, "m");
                case UnitType.Time:
                    return new SimpleUnit(UnitType.Time, "s");
                case UnitType.Mass:
                    return new SimpleUnit(UnitType.Mass, "kg");
                case UnitType.Substance:
                    return new SimpleUnit(UnitType.Substance, "mol");
                case UnitType.Temperature:
                    return new SimpleUnit(UnitType.Time, "K");
                case UnitType.Luminosity:
                    return new SimpleUnit(UnitType.Luminosity, "cd");
                default:
                    throw new Exception(); // TODO Add specific exception
            }
        }
    }
}