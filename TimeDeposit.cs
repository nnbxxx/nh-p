
public class TimeDeposit : SavingAccount
{
    // Cac loai ky han
    enum TypeOfTerm
    {
        T2 = 4,
        T5 = 5,
        T7 = 6,
        T10 = 7,
        T12 = 8,
        T14 = 9,
        T16 = 10,
    }
    // Ngay dao han
    private DateTime maturitydate;
    public DateTime MaturityDate { get; set; }
    // Loai ky han
    private int term;
    public int Term { get; set; }
    public TimeDeposit(string Currency, string Branch, DateTime StartedDate, decimal SavingDeposit, int term) : base(Currency, Branch, StartedDate, SavingDeposit)
    {
        if (SavingDeposit < (decimal)Minium.TimeDeposit)
        {
            // Khởi tạo ngoại lệ
            Exception NotAccepted = new Exception($"Tien gui toi thieu la {Minium.TimeDeposit}");
            // phát sinh ngoại lệ, code phía sau throw không được thực thi
            throw NotAccepted;
        }
        else
        {
            Term = term;
            switch (Term)
            {
                case 1:
                case 2:
                    {
                        this.InterestPercent = (float)TypeOfTerm.T2 / 100;
                        break;
                    }
                case 3:
                case 4:
                case 5:
                    {
                        this.InterestPercent = (float)TypeOfTerm.T5 / 100;
                        break;
                    }
                case 6:
                case 7:
                    {
                        this.InterestPercent = (float)TypeOfTerm.T7 / 100;
                        break;
                    }
                case 8:
                case 9:
                case 10:
                    {
                        this.InterestPercent = (float)TypeOfTerm.T10 / 100;
                        break;
                    }
                case 11:
                case 12:
                    {
                        this.InterestPercent = (float)TypeOfTerm.T12 / 100;
                        break;
                    }
                case 13:
                case 14:
                    {
                        this.InterestPercent = (float)TypeOfTerm.T14 / 100;
                        break;
                    }
                case 15:
                case 16:
                    {
                        this.InterestPercent = (float)TypeOfTerm.T16 / 100;
                        break;
                    }
                default:
                    {
                        this.InterestPercent = (float)TypeOfTerm.T16 / 100;
                        break;
                    }
            }
        }

    }
}