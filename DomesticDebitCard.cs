public class DomesticDebitCard
{
    private string typecard;
    public string Typecard { get; set; }
    private decimal cardbalance;
    public static decimal CardBalance { get; set; }
    static public decimal hanMucRutTienTrenNgay;
    static public decimal hanMucChuyenKhoanTrenNgayCungNH;
    static public decimal hanMucChuyenKhoanTrenNgayKhacNH;
    public decimal hanMucRutTienTrenLanKhacNH;
    public decimal hanMucChuyenKhoanTrenLan;
    public decimal hanMucRutTienTrenLanCungNH;
    private decimal annualFees;
    public decimal AnnualFees { get; set; }
    public int PIN;
    private decimal internetlimit;
    public decimal InternetLimit { get; set; }

    private DateTime open;
    public DateTime Open { get; set; }
    public void RutTien(decimal x)
    {
        CardBalance -= x;
    }
    public void Ktratraikhoan()
    {
        Console.WriteLine(CardBalance);
    }
}

class NapasSuccessCard : DomesticDebitCard
{
    public NapasSuccessCard()
    {
        Typecard = "Napas Success";
        hanMucRutTienTrenNgay = 25000000;
        hanMucChuyenKhoanTrenNgayCungNH = 50000000;
        hanMucChuyenKhoanTrenNgayKhacNH = 25000000;
        hanMucRutTienTrenLanCungNH = 5000000;
        hanMucRutTienTrenLanKhacNH = 3000000;
        Open = DateTime.Now;

        CardBalance = 100;
    }

    ~NapasSuccessCard() { }
}
class NapasSuccessPlusCard : DomesticDebitCard
{
    public NapasSuccessPlusCard()
    {
        Typecard = "Napas Success Plus";
        hanMucRutTienTrenNgay = 50000000;
        hanMucChuyenKhoanTrenNgayCungNH = 100000000;
        hanMucChuyenKhoanTrenNgayKhacNH = 100000000;
        hanMucRutTienTrenLanCungNH = 5000000;
        hanMucRutTienTrenLanKhacNH = 3000000;
        hanMucChuyenKhoanTrenLan = 25000000;
        AnnualFees = 12000;
        InternetLimit = 5000000;
        Open = DateTime.Now;

        CardBalance = 100;

    }
    ~NapasSuccessPlusCard() { }
}