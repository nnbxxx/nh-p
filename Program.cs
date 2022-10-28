using System;
namespace Bank
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] ListCard =
            {
                "Napas Success", "Napas Success Plus"
            };

            Client A = new Client("Duy", "HCM", new DateTime(day: 1, month: 1, year: 1), "21110397", "Sinh vien", "Viet Nam", "HCMUTE", true, "0111", new DateTime(day: 1, month: 1, year: 2018), 1);
            A.CreateDebitCard(ListCard[0]);
            A.CreateDebitCard(ListCard[1]);
            A.listDebit[ListCard[0]].RutTien(20);
            A.listDebit[ListCard[1]].Ktratraikhoan();


        }
    }
}