class InternationalCreditCard 
{
    private decimal Creditlimit;
    #region CreditLimit
    //Hạn mức giao dịch tín dụng
    #endregion
    public decimal CreditLimit
    {
        get; set;
    }
    private decimal poslimit;
    #region CreditLimit
    //Hạn mức giao dịch tại pos atm
    #endregion
    public decimal POSLimit
    {
        get; set;
    }
    private decimal atmlimit;
    #region ATMLimit
    //Hạn mức giao dịch tại pos atm
    #endregion
    public decimal ATMLimit
    {
        get; set;
    }
    private decimal Ipolimit;
    #region Initial Public Offering
    //Phát hành công khai lần đầu, còn gọi là IPO
    #endregion
    public decimal IPOLimit
    {
        get; set;
    }
    private decimal Poglimit;
    #region Payment of good
    //Thanh toán hàng hóa/dịch vụ
    #endregion
    public decimal POGLimit
    {
        get; set;
    }
    private decimal Annualfees;
    #region Annual fees
    //Phí thường niên
    #endregion
    public decimal AnnualFees
    {
        get; set;
    }
    private decimal internetlimit;
    #region Deal Internet/Moto
    //Giao dịch Internet/MOTO
    #endregion
    public decimal InternetLimit
    {
        get; set;
    }
    private string typecard;
    public string Typecard
    {
        get; set;
    }
    private float creditinterestrate;
    public float CreditInterestRate
    {
        get; set;
    }
    private decimal creditcardbalance;
    public decimal CreditCardBalance
    {
        get; set;
    }
    private DateTime duedate;
    public DateTime Duedate
    {
        get; set;
    }
    private decimal minimumpayment;
    public decimal Minimumpayment
    {
        get; set;
    }
    ~InternationalCreditCard()
    { }
}
class VisaStandard : InternationalCreditCard
{
    public VisaStandard()
    {
        this.AnnualFees = 100000;

        this.CreditLimit = 30000000;
        this.POSLimit = this.CreditLimit / 2;
        this.POGLimit = 30000000;
        this.ATMLimit = 15000000;
        this.InternetLimit = 5000000;
        this.IPOLimit = 100000;

        this.Typecard = "Visa Standard";
        this.CreditCardBalance = 0;
        this.CreditInterestRate = 0;
        this.Duedate = DateTime.Now;
        this.Minimumpayment = 0;

    }
    ~VisaStandard()
    { }

}
class VisaGold : InternationalCreditCard
{
    public VisaGold() 
    {
        this.AnnualFees = 0;

        this.CreditLimit = 100000000;
        this.POSLimit = this.CreditLimit / 2;
        this.POGLimit = 100000000;
        this.ATMLimit = 50000000;
        this.InternetLimit = 5000000;
        this.IPOLimit = 200000;

        this.Typecard = "VisaGold";
        this.CreditCardBalance = 0;
        this.CreditInterestRate = 0;
        this.Duedate = DateTime.Now;
        this.Minimumpayment = 0;

    }
    ~VisaGold()
    { }
}

class MastercardGold : InternationalCreditCard
{
    public MastercardGold()
    {
        this.AnnualFees = 0;

        this.CreditLimit = 100000000;
        this.POSLimit = this.CreditLimit / 2;
        this.POGLimit = 100000000;
        this.ATMLimit = 50000000;
        this.InternetLimit = 5000000;
        this.IPOLimit = 200000;

        this.Typecard = "MastercardGold";
        this.CreditCardBalance = 0;
        this.CreditInterestRate = 0;
        this.Duedate = DateTime.Now;
        this.Minimumpayment = 0;

    }
    ~MastercardGold()
    { }
}
class MastercardPlatinum : InternationalCreditCard
{
    public MastercardPlatinum()
    {
        this.AnnualFees = 100000;

        this.CreditLimit = 200000000;
        this.POSLimit = this.CreditLimit / 2;
        this.POGLimit = 200000000;
        this.ATMLimit = 100000000;
        this.InternetLimit = 5000000;
        this.IPOLimit = 300000;

        this.Typecard = "MastercardPlatinum";
        this.CreditCardBalance = 0;
        this.CreditInterestRate = 0;
        this.Duedate = DateTime.Now;
        this.Minimumpayment = 0;

    }
    ~MastercardPlatinum()
    { }
}
class JCBGold : InternationalCreditCard
{
    public JCBGold()
    {
        this.AnnualFees = 0;

        this.CreditLimit = 100000000;
        this.POSLimit = this.CreditLimit / 2;
        this.POGLimit = 100000000;
        this.ATMLimit = 50000000;
        this.InternetLimit = 5000000;
        this.IPOLimit = 300000;

        this.Typecard = "JCBUltimate";
        this.CreditCardBalance = 0;
        this.CreditInterestRate = 0;
        this.Duedate = DateTime.Now;
        this.Minimumpayment = 0;

    }
    ~JCBGold()
    { }
}
class JCBUltimate : InternationalCreditCard
{
    public JCBUltimate()
    {
        this.AnnualFees = 0;

        this.CreditLimit = 200000000;
        this.POSLimit = this.CreditLimit / 2;
        this.POGLimit = 200000000;
        this.ATMLimit = 50000000;
        this.InternetLimit = 100000000;
        this.IPOLimit = 0;

        this.Typecard = "JCBUltimate";
        this.CreditCardBalance = 0;
        this.CreditInterestRate = 0;
        this.Duedate = DateTime.Now;
        this.Minimumpayment = 0;

    }
    ~JCBUltimate()
    { }
}