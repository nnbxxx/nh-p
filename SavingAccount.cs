
public class SavingAccount
{
    // So tien gui toi thieu doi voi moi loai
    public enum Minium
    {
        DemandDeposit = 500000,
        TimeDeposit = 1000000,

    }
    // Loai tien te
    private string currency;
    public string Currency { get; set; }
    // Chi nhanh: mot so ngan hang nhu Agribank se thu them phi tu 0.02 - 0.07% neu rut tien khac chi nhanh
    private string branch;
    public string Branch { get; set; }
    // Lien ket bang sorted list
    // Tai khoan thu huong: la so tai khoan cua khach hang
    // Doi voi khach hang khong co Payment Account van co the mo tai khoan tiet kiem,khong bat buoc phai co tai khoan thanh tona tai ngan hang
    // Ngay bat dau mo tai khoan tiet kiem
    private DateTime starteddate;
    public DateTime StartedDate { get; set; }
    // Lai suat 1 nam
    private double interestpercent;
    public double InterestPercent { get; set; }
    // So tien gui
    private decimal savingdeposit;
    public decimal SavingDeposit { get; set; }
    public SavingAccount(string currency, string branch, DateTime starteddate, decimal savingdeposit)
    {

        Currency = currency;
        Branch = branch;
        StartedDate = starteddate;
        SavingDeposit = savingdeposit;

    }
    ~SavingAccount()
    {

    }

}