class Client
{

    private string name;
    public string Name { get; set; }
    private DateTime dateofbirth;
    public DateTime DateOfBirth { get; set; }
    private string address;
    public string Address { get; set; }
    private string id;
    public string ID { get; set; }
    private bool sex;
    public bool Sex { get; set; }
    private string workplace;
    public string WorkPlace { get; set; }
    private string position;
    public string Position { get; set; }
    private string nationality;
    public string Nationality { get; set; }
    private string nameuser;
    public string NameUser { get; set; }
    private string password;
    public string Password { get; set; }
    private long CustomerID = 0;
    private DateTime issueddate;
    public DateTime IssuedDate { get; set; }
    private string phonenumber;
    public string PhoneNumber { get; set; }
    private decimal income;
    public decimal Income { get; set; }
    private int fico;
    public int Fico { get { return fico; } set { fico = value; } }

    // public string[] ListCard =
    //         {
    //             "Napas Success", "Napas Success Plus"
    //         };
    public SortedList<string, DomesticDebitCard> listDebit = new SortedList<string, DomesticDebitCard>();
    public SortedList<string, InternationalCreditCard> listCredit = new SortedList<string, InternationalCreditCard>();
    public SortedList<string, SavingAccount> listSaving = new SortedList<string, SavingAccount>();
    public SortedList<string, Loans> listLoans = new SortedList<string, Loans>();
    public Client()
    { }
    public Client(string name, string address, DateTime dateofbirth, string id, string position, string nationality, string workplace, bool sex, string phonenumber, DateTime issueddate, decimal income)
    {
        this.Name = name;
        this.Address = address;
        this.DateOfBirth = dateofbirth;
        this.ID = id;
        this.WorkPlace = workplace;
        this.Position = position;
        this.Nationality = nationality;
        this.NameUser = nameuser;
        this.Password = password;
        this.Sex = sex;
        this.PhoneNumber = phonenumber;
        this.IssuedDate = issueddate;
        this.Income = income;
        Console.WriteLine("Tao tai khoan thanh cong!");

    }
    public void CreateDebitCard(string TypeCard)
    {
        string[] ListCard =
              {
                "Napas Success", "Napas Success Plus"
            };
        if (TypeCard == ListCard[0])
        {
            DomesticDebitCard A = new NapasSuccessCard();
            listDebit.Add(A.Typecard, A);
            Console.WriteLine("Tao the thanh cong!");
        }
        else
        {
            DomesticDebitCard B = new NapasSuccessPlusCard();
            listDebit.Add(B.Typecard, B);
            Console.WriteLine("Tao the thanh cong!");
        }


    }
    public void CreateCreditCard(string TypeCard)
    {
        string[] ListCard =
        {
            "VisaStandard", "VisaGold", "MastercardGold", "MastercardPlatinum", "JCBGold", "JCBUltimate"
        };
        if (TypeCard == ListCard[0])
        {
            InternationalCreditCard A = new VisaStandard();
            listCredit.Add(A.Typecard, A);
            Console.WriteLine("Tao the thanh cong!");
        }
        else
        if(TypeCard == ListCard[1])
        {
            InternationalCreditCard B = new VisaGold();
            listCredit.Add(B.Typecard, B);
            Console.WriteLine("Tao the thanh cong!");
        }
        else
        if (TypeCard == ListCard[2])
        {
            InternationalCreditCard B = new MastercardGold();
            listCredit.Add(B.Typecard, B);
            Console.WriteLine("Tao the thanh cong!");
        }
        else
        if (TypeCard == ListCard[3])
        {
            InternationalCreditCard B = new MastercardPlatinum();
            listCredit.Add(B.Typecard, B);
            Console.WriteLine("Tao the thanh cong!");
        }
        else
        if (TypeCard == ListCard[4])
        {
            InternationalCreditCard B = new JCBGold();
            listCredit.Add(B.Typecard, B);
            Console.WriteLine("Tao the thanh cong!");
        }
        else
        if (TypeCard == ListCard[5])
        {
            InternationalCreditCard B = new JCBUltimate();
            listCredit.Add(B.Typecard, B);
            Console.WriteLine("Tao the thanh cong!");
        }
    }
}