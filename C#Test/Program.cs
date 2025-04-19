//Loop in C#
using System.Security.Cryptography.X509Certificates;

string J= "I Give You Something";
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(J);

}

//if condition in C#
if (J == "I like you")
{
    Console.WriteLine("I like you");
}
else if(J == "I Give You Something")
{
    Console.WriteLine("I Give You Something");
}
else
{
    Console.WriteLine("Invalid Case");
}

//switch condition in C#
switch (J)
{
    case "I Give You Something":
    Console.WriteLine("Your answer is Right");break;

    case "I like You":
        Console.WriteLine("Your answer is wrong");break;

     default:break;
}

//Array Loop in C#
//1. Normal Loop
int[] num = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10,];
for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine(num[i]);
}
;
//2. Array Loop
foreach (int i in num)
{
    Console.WriteLine(i);
}
//Class in C#
idCard stu1 = new idCard("2223CS-107","Nay Zaw Oo",18);
//stu1.idNum = "2223-CS-107";
//stu1.Name = "Nay Zaw Oo";
//stu1.Age = 18;
//Console.WriteLine(stu1.idNum);
//Console.WriteLine(stu1.Name);
//Console.WriteLine(stu1.Age);
Console.WriteLine(stu1.idNum);
Console.WriteLine(stu1.Name);
Console.WriteLine(stu1.itWas18);
stu1.setID("2223CS-108");



Dog dog = new Dog();
dog.Eat();
dog.Bite();


moneyTransfer moneyTransfer = new moneyTransfer();
moneyTransfer.Deposite1 = 5000;
Console.WriteLine(moneyTransfer.Deposite1);
moneyTransfer.Deposit2(5000);
moneyTransfer.Deposit2(5000);

Iresume res = new idCard("2223CS", "Nay Zaw Oo", 18);
res = new idCard2("2223CS", "Nay Zaw Oo", 18);
public interface Iresume
{

}
//Console.WriteLine(stu1.itWas18());
public class idCard : Iresume
{ //Constructor Type
   public idCard(string idnum, string name, int age) {
    idNum = idnum;
    Name = name;
    Age = age;
    }
    //Normal Type 
    public string idNum { get;
        private set; }//getter setter method
    public void setID(string idnum)
    {
        Console.WriteLine($"Before {idNum}");
        idNum = idnum;
        Console.WriteLine($"After {idNum}");
    }


  public  string Name;


  public  int Age;
  //private bool Is18;
  public int itWas18 {  get
        {
            int result = Age;
            return Age;
        } }
    

}
public class idCard2 : Iresume
{ //Constructor Type
    public idCard(string idnum, string name, int age)
    {
        idNum = idnum;
        Name = name;
        Age = age;
    }
    //Normal Type 
    public string idNum
    {
        get;
        private set;
    }//getter setter method
    public void setID(string idnum)
    {
        Console.WriteLine($"Before {idNum}");
        idNum = idnum;
        Console.WriteLine($"After {idNum}");
    }


    public string Name;


    public int Age;
    //private bool Is18;
    public int itWas18
    {
        get
        {
            int result = Age;
            return Age;
        }
    }


}

// example of Inheritence
public class NationalCard : idCard
{
    public NationalCard(string idnum, string name, int age) : base(idnum, name, age)
    {

    }
}




public class Animal
{
    public virtual void Eat() {
        Console.WriteLine("It Can Eat");
    }
}


public class Dog : Animal
{
    public void Bite()
    {
        Console.WriteLine("It Can Bite");
    }
    public override void Eat()
    {
        Console.WriteLine("It Can Only Eat Meat");
    }
}

public interface iTransfer
{
    void Create();
    void Read();
    void Update();
    void Delete();
}

public class kPay : iTransfer
{
    public void Create()
    {
        throw new NotImplementedException();
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }

    public void Read()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }
}

public class moneyTransfer
{
    private int balance;

    public int Deposite1 { get { return balance; } set 
        {
            if (value > 0) 
            {
                balance += value;
            }
            else
            {
                Console.WriteLine("Your Amount is not enough");
            }
        } }

    public void Deposit2(int v)
    {
        balance += v;
        Console.WriteLine($"You Transfer Money {balance}");
    }
}

//Console.ReadLine();


