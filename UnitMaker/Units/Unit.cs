using System;
using System.Collections.Generic;
using System.Text;
using UnitMaker.Quantities;

namespace UnitMaker.Units
{
    public abstract class Unit
    {
        public abstract bool IsBase { get; }
        public bool IsDerived => !IsBase;

        public abstract Unit GetBase();
        public abstract bool Equals(Unit? other);
        public abstract bool HasSameDimensions(Unit other);
        public abstract double GetBaseFactor();
        public bool FactorTo(Unit other, out double factor)
        {
            if (!HasSameDimensions(other))
            {
                factor = 0;
                return false;
            }
            factor = GetBaseFactor() * other.GetBaseFactor();
            return true;
        }
        public double FactorTo(Unit other)
        {
            if(FactorTo(other, out var result))
                return result;
            throw new InvalidOperationException("The units have diferent dimensions");
        }

        public static Quantity operator *(double number, Unit unit) => new Quantity(number, unit);
        public static Quantity operator *(Unit unit, double number) => number * unit;
    }
}
