using System;

namespace Tumakov14.Classes
{
    [DeveloperInfo("Энже Аликовна", "01.12.2025")]
    [DeveloperInfo("Дина Сергеевна", "30.11.2025")]
    public class RationalNum
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        private double Value
        {
            get
            {
                return (double)Numerator / Denominator;
            }
        }
        public RationalNum(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен 0");
            }
            Numerator = numerator;
            Denominator = denominator;
        }

        public static bool operator ==(RationalNum rational1, RationalNum rational2)
        {
            if (ReferenceEquals(rational1, rational2)) return true;
            if (rational1 is null || rational2 is null) return false;

            return rational1.Value == rational2.Value;
        }

        public static bool operator !=(RationalNum rational1, RationalNum rational2)
        {
            return !(rational1 == rational2);
        }

        public override bool Equals(object obj)
        {
            return this == obj as RationalNum;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public static bool operator <(RationalNum rational1, RationalNum rational2)
        {
            return rational1.Value < rational2.Value;
        }
        public static bool operator >(RationalNum rational1, RationalNum rational2) 
        {
            return rational1.Value > rational2.Value;
        }
        public static bool operator <=(RationalNum rational1, RationalNum rational2)
        {
            return rational1.Value <= rational2.Value;
        }
        public static bool operator >=(RationalNum rational1, RationalNum rational2)
        {
            return rational1.Value >= rational2.Value;
        }

        public static RationalNum operator +(RationalNum rational1, RationalNum rational2)
        {
            return new RationalNum(rational1.Numerator * rational2.Denominator + rational2.Numerator * rational1.Denominator, rational1.Denominator * rational2.Denominator);
        }
        public static RationalNum operator -(RationalNum rational1, RationalNum rational2)
        {
            return new RationalNum(rational1.Numerator * rational2.Denominator - rational2.Numerator * rational1.Denominator, rational1.Denominator * rational2.Denominator);
        }

        public static RationalNum operator *(RationalNum rational1, RationalNum rational2)
        {
            return new RationalNum(rational1.Numerator * rational2.Numerator, rational1.Denominator * rational2.Denominator);
        }
        public static RationalNum operator /(RationalNum rational1, RationalNum rational2)
        {
            return new RationalNum(rational1.Numerator * rational2.Denominator, rational1.Denominator * rational2.Numerator);
        }
        public static RationalNum operator %(RationalNum rational1, RationalNum rational2)
        {
            return new RationalNum(rational1.Numerator % rational2.Numerator, rational1.Denominator % rational2.Denominator);
        }

        public static RationalNum operator ++(RationalNum rational)
        {
            return new RationalNum(rational.Numerator + rational.Denominator, rational.Denominator);
        }
        public static RationalNum operator --(RationalNum rational)
        {
            return new RationalNum(rational.Numerator - rational.Denominator, rational.Denominator);
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
