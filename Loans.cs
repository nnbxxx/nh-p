public class Loans
{
    private double limit, percent, fico;
    private DateTime timeloan, borrow;
    public double Fico { get { return fico; } set { fico = value; } }
    public double Limit { get { return limit; } set { limit = value; } }
    public double Percent { get { return percent; } set { percent = value; } }
    public DateTime Timeloan { get { return timeloan; } set { timeloan = value; } }
    public DateTime Borrow { get { return borrow; } set { borrow = value; } }

    public Loans(double Limit, double Percent, double Fico, DateTime Timeloan, DateTime Borrow)
    {
        limit = Limit;
        percent = Percent;
        fico = Fico;
        timeloan = Timeloan;
        borrow = Borrow;
    }
    public Loans() { }
    ~Loans() { }

}
class UnLoan : Loans
{
   public UnLoan() : base()
    {
      if (Fico >= 670)
        {
            Limit = 30000000;
            Percent = 0.18;
            Timeloan = DateTime.Now;
            Borrow = DateTime.Now.AddMonths(48);
        }  else if (Fico > 785)
        {
            Limit = 100000000;
            Percent = 0.12;
            Timeloan = DateTime.Now;
            Borrow= DateTime.Now.AddMonths(60);
        }
        else
        {
            Limit = 15000000;
            Percent = 0.2;
            Timeloan = DateTime.Now;
            Borrow = DateTime.Now.AddMonths(36);
        }
    }
    ~UnLoan() { }
}

class Mortage : Loans
{
    private double totalasset;
    public double Totalasset { get { return totalasset; } set { totalasset = value; } }
    public Mortage() : base()
    {
        Limit = Totalasset;
        Percent = 0.125;
        Timeloan = DateTime.Now;
        Borrow = DateTime.Now.AddMonths(120);
    }
    ~Mortage() { }
}


class Overdraft : Loans
{
    private double salary;
    public double Salary { get { return salary; } set { salary = value; } } 

    public Overdraft() : base()
    {
        Limit = 5 * Salary;
        Percent = 0.08;
        Timeloan = DateTime.Now;
        Borrow = DateTime.Now.AddMonths(12);
    }
    ~Overdraft() { }
}

class InsLoan : Loans
{
    public InsLoan() : base()
    {
        Limit = 50000000;
        Percent = 0.15;
        Timeloan = DateTime.Now;
        Borrow = DateTime.Now.AddMonths(12);
    }
    ~InsLoan() { }
}