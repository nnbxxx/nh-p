public class DemandDeposit : SavingAccount
{
    public DemandDeposit(string Currency, string Branch, DateTime StartedDate, decimal SavingDeposit) : base(Currency, Branch, StartedDate, SavingDeposit)
    {
        if (SavingDeposit < (decimal)Minium.DemandDeposit)
        {
            // Khởi tạo ngoại lệ
            Exception NotAccepted = new Exception($"Tien gui toi thieu la {Minium.DemandDeposit}");
            // phát sinh ngoại lệ, code phía sau throw không được thực thi
            throw NotAccepted;
        }
        this.InterestPercent = 0.01;

    }
}