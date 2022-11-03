

namespace Moneyy
{
    public class Money
    {
        public double money;
        public void Show() {
            if (money >= 0) Console.WriteLine($"money = {money}");
            else { Console.WriteLine("Bancrot"); }
        }

        public Money(double money)
        {
            this.money = money;
        }
        public static Money operator +(Money m, Money m2) { return new Money(m.money + m2.money); }
        public static Money operator -(Money m, Money m2) { return new Money(m.money - m2.money); }
        public static Money operator *(Money m, Money m2) { return new Money(m.money * m2.money); }
        public static Money operator /(Money m, Money m2) { return new Money(m.money + m2.money); }
        public static Money operator ++(Money m) { return new Money(++m.money); }
        public static Money operator --(Money m) { return new Money(--m.money); }
        public static bool operator <(Money m, Money m2) { return m.money < m2.money; }
        public static bool operator >(Money m, Money m2)
        {
             return m.money > m2.money;
            
        }
        public static bool operator ==(Money m, Money m2)
        {
             return m.money==m2.money;

        }
        public static bool operator !=(Money m, Money m2)
        {
            return m.money != m2.money;

        }

    } 
    
}
