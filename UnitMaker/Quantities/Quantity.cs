using System;
using System.Collections.Generic;
using System.Text;
using UnitMaker.Units;

namespace UnitMaker.Quantities
{
    public class Quantity
    {
        public double Amount { get; set; }
        public Unit Unit { get; set; }

        public Quantity(double amount, Unit unit)
        {
            Amount = amount;
            Unit = unit;
        }

        public override string ToString()
        {
            return Amount.ToString() + Unit.ToString();
        }

        public static Quantity operator *(double number, Quantity quantity)
        {
            return new Quantity(number * quantity.Amount, quantity.Unit);
        }
        public static Quantity operator *(Quantity quantity, double number) => number * quantity;

        public static Quantity operator /(Quantity quantity, double number)
        {
            return new Quantity(quantity.Amount / number, quantity.Unit);
        }
    }
}
