using System;

namespace Lab3
{
    class RBI
    {
        public virtual double CalculateInterest(double principal, double rate, double time)
        {
            return principal * rate * time / 100;
        }
    }

    class HDFC : RBI
    {
        public override double CalculateInterest(double principal, double rate, double time)
        {
            return principal * rate * time / 100 * 1.5; // Example custom calculation for HDFC
        }
    }

    class SBI : RBI
    {
        public override double CalculateInterest(double principal, double rate, double time)
        {
            return principal * rate * time / 100 * 1.2; // Example custom calculation for SBI
        }
    }

    class ICICI : RBI
    {
        public override double CalculateInterest(double principal, double rate, double time)
        {
            return principal * rate * time / 100 * 1.3; // Example custom calculation for ICICI
        }
    }
}