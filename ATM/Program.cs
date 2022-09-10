using System;

public class cardHolder{

    string cardNum;
    int pin;
    string firstName;
    string lastName;
    double balance;

    //cardHolder is a constructor that takes in the card number, pin, first name, last name, and balance of the card holder and assigns them to the variables
    public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance){
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }
    //All the below are functions that we will use:
    public string getNum()
    {
        return cardNum;
    }

    public int getPin()
    {
        return pin;
    }

    public string getFirstName()
    {
        return firstName;
    }

    public string getLastName()
    {
        return lastName;
    }

    public double getBalance()
    {
        return balance;
    }
//-----------------------------------------------------------------
    public void setNum(string cardNum)
    {
        cardNum = newCardNum;

    }
    
    public void setPin(int pin)
    {
        pin = newPin;
    }

    public void setFirstName(string firstName)
    {
        firstName = newFirstName;
    }
    public void setLastName(string lastName)
    {
        lastName = newLastName;
    }
    public void setBalance(double balance)
    {
        balance = newBalance;
    }

    public static void Main (string[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Choose one of the following options:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder currentUser){
            Console.WriteLine("How much would you like to deposit?");
            double depositAmount = Convert.ToDouble(Console.ReadLine());
            //Console.ReadLine() reads the input from the user.
            currentUser.setBalance(deposit);
            
        }
        

    }
    
}