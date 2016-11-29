using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echelon
{
    public class RNumber
    {
        private int p_Numerator;
        private int p_Denominator;
        public int Numerator {
            get { return p_Numerator; }
        }
        public int Denominator
        {
            get { return p_Denominator; }
        }
        public RNumber(int n, int d = 1)
        {
            this.Set(n, d);
        }
        public void Set(int n,int d = 1)
        {
            if (d == 0) { throw new ArgumentException("Denominator = 0 is undefined"); }
            if (n == 0) { d = 1; }
            p_Numerator = n;
            p_Denominator = d;
            Simplify();
        }
        public RNumber Clone()
        {
            return new RNumber(this.Numerator, this.Denominator);
        }
        public void Simplify()
        {
            if (this.Denominator == 1 || this.Numerator == 1) { return; }
            if (this.Numerator == this.Denominator) { p_Numerator = 1; p_Denominator = 1; return; }
            if(this.Denominator < 0)
            {
                p_Numerator = -this.Numerator;
                p_Denominator = -this.Denominator;
            }
            List<int> NumaratorDivisors = this.Numerator.GetDivisors();
            if (NumaratorDivisors.Count() == 0) { return; }
            NumaratorDivisors.Sort();
            for (int i = NumaratorDivisors.Count() - 1; i >= 0; i--)
            {
                int divisor = NumaratorDivisors[i];
                if (this.Denominator.CanBeDivided(divisor))
                {
                    p_Numerator /= divisor;
                    p_Denominator /= divisor;
                    Simplify();
                    return;
                }
            }
        }
    }
}
