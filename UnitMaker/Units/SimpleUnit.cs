using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace UnitMaker.Units
{
    public class SimpleUnit : Unit
    {
        public UnitType Type { get; init; }
        public string Symbol { get; init; }
        public double Factor { get; init; } = 1;
        
        public override bool IsBase => Factor == 1;

        public SimpleUnit(UnitType type, string symbol)
        {
            Type = type;
            Symbol = symbol;
        }
        
        public override Unit GetBase()
        {
            if (IsBase) 
                    return this;

            return UnitFactory.GetBaseUnit(Type);
        }
        public override bool HasSameDimensions(Unit other)
        {
            if (other is not SimpleUnit o)
                return false;

            return o.Type == Type;
        }

        public override double GetBaseFactor() => Factor;

        public override bool Equals(Unit? other)
        {
            if (other is null)
                return false;

            if (other is not SimpleUnit o)
                return false;

            return o.Type == Type && o.Factor == Factor;
        }
        public override string ToString()
        {
            return Symbol;
        }

        
    }
}
