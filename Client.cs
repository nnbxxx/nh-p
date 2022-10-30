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

    // thêm thuộc tính ngày đăng ký thẻ

    private DateTime registerdate;
    public DateTime RegisterDate { get; set; }

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
    public Client(string name, string address, DateTime dateofbirth, 
        string id, string position, string nationality, string workplace, 
        bool sex, string phonenumber, DateTime issueddate, decimal income)
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

        // vì cái fico dựa vào thu nhập nên ta có thể tính luôn ở lúc khởi tạo
        int tmp = 0;
        if (Income < 5000000) 
            tmp = 1;
        else
            if (Income >= 5000000 && Income < 10000000)
            tmp = 2;
        else
            if (Income >= 10000000 && Income < 20000000)
            tmp = 4;
        else
            if (Income >= 20000000 && Income < 50000000)
            tmp = 7;
        else
            if (Income >= 50000000 )
            tmp = 10;


        this.Fico = tmp;

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

    //methods
    public void CreateLoans(string TypeCard)
    {

    }

    public void CreatePaymentAccount(string TypeCard)
    {

    }

    public void CreateSavingAccount(string TypeCard)
    {

    }
    public bool AgeCheck()
    {
        #region Hàm AgeCheck
        /*
             Trả về kiểu giá trị bool 
             True: đủ 18 tuổi
             False: ko đủ 18 tuổi
         */
        #endregion
        DateTime A = this.DateOfBirth;
        DateTime B = DateTime.Now;
        TimeSpan Elapsed = B.Subtract(A);// tính khoảng cách giữa thời điểm B và A
        double daysAgo = Elapsed.TotalDays;
        if (daysAgo / 365 >= 18)
        {
            //Console.WriteLine("đủ tuổi");
            return true;
        }
        else
        {
            return false;
        } 
            
    }

    public bool IDCheck(DateTime ExpirationDate)
    {
        #region Hàm IDCheck
        /*
             Trả về kiểu giá trị bool 
             True: còn hạn
             False: hết hạn
         */
        #endregion

        if (ExpirationDate < DateTime.Now)
        {
            return true;
        }    
        else
        {
            return false;
        }
    }
    public void SignUp(string name, string password)
    {
        this.NameUser = name;
        this.Password = password;
    }
    public bool SignIn(string name, string password)
    {
        #region hàm SignIn
        /*
         Trả về kiểu dữ liệu bool 
        True đăng nhập thành công
        False đăng nhập thất bại
         */ 
        #endregion
        return (this.NameUser == name) && (this.Password == password);
    }

    public bool ChangePassword(string OldPassword,string NewPassWord)
    {
        if(this.Password == OldPassword)
        {
            this.Password = NewPassWord;
            return true;
        }    
        else
        {
            return false;
        }    
    }

    public void ForgotPassword()
    {
        // chưa hiểu lắm
    }

    public void UpdateFico()
    {
        // ko nên để ở đây mà nên để trong từng loại thẻ có hàm update;
    }    

    public string ClassificationCustomer()
    {
        string[] TypeCustumer =
        {
            "Cooper","Silver","Gold","Platinum","Diamond"
        };
        int time = DateTime.Now.Year - this.RegisterDate.Year;
        if (Fico > 20 && time > 1) return TypeCustumer[0];
        if (Fico > 50 && time > 3) return TypeCustumer[1];
        if (Fico > 80 && time > 4) return TypeCustumer[2];
        if (Fico > 100 && time > 5) return TypeCustumer[3];
        if (Fico > 2000 && time > 8) return TypeCustumer[4];
        return "";

    }

    public void ExportInformation()
    {
        // xuất thông tin 
    }


}