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
//-------------------------------------------------------------------------------------------
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
            currentUser.setBalance(depositAmount + currentUser.getBalance()); //CHECK THIS
            Console.WriteLine("Your new balance is: " + currentUser.getBalance());
            
        }

        //we also need a fucntion to manage withdrawals
        void withdrawals(cardHolder currentUser){
            Console.WriteLine("How much would you like to withdraw?");
            double withdrawAmount = Convert.ToDouble(Console.ReadLine());
            if (withdrawAmount > currentUser.getBalance()){
                Console.WriteLine("You do not have enough money in your account to withdraw that amount.");
            }
            else{
                currentUser.setBalance(currentUser.getBalance() - withdrawAmount);
                Console.WriteLine("Your new balance is: " + currentUser.getBalance());
            }
        
        void balance (cardHolder currentUser){
            Console.WriteLine ("Current balance: " + currentUser.getBalance());
        }

        
        List<cardHolder> cardHolders = new List<cardHolder> ();
        cardHolders.Add(new cardHolder("41744678989854", 2396, "Mario", "Chiavaro", 852.98));
        cardHolders.Add(new cardHolder("4135234244368849",2232,"John", "Travolta", 132.22));
        cardHolders.Add(new cardHolder("4135234244368849", 4259, "Dennis", "Jones", 999.99));
        cardHolders.Add(new cardHolder("4135234244368849", 9429, "Alexis", "Sanchez", 300000.12));
        
        //prompt the user to enter their card number
        Console.WriteLine("Please enter your card number: ");
        string cardNum = "";
        cardHolder currentUser; 

       //now we want some exception handling:
       //any code that we think will break the program we put it in the try blockand if indeed it breaks it
       //then it will go and execute everything we include in the catch block

       while(true){
           try{
               cardNum = Console.ReadLine();
               //check against our database (above) to see if the card number is valid
               
           }
           catch{
               Console.WriteLine("Invalid card number. Please try again.");
               // return the first element of a sequence or a default value if element isn't there
               currentUser = cardHolders.FirstorDefault(x => x.getNum() == cardNum);
                if(currentUser == null){
                     Console.WriteLine("Invalid card number. Please try again.");
                     continue;
                }
                else{
                     break;
                }
           }
       }

        Console.WriteLine("Please enter your pin: ");
        int userPin = 0;
        
        while(true){
            try{
                userPin = int.Parse(Console.ReadLine());
                if(userPin != currentUser.getPin()){
                    Console.WriteLine("Invalid pin. Please try again.");
                }
                else{
                    break;
                }
            }
            catch{
                Console.WriteLine("Invalid pin. Please try again.");
            }
        }

        Console.WriteLine("Welcome" + currentUser.getFirstName() + " " + currentUser.getLastName());
        int option = 0;
        do{
            printOptions();
            try{
                option = int.Parse(Console.ReadLine());
            }

            catch
            {
                Console.WriteLine("Invalid option. Please try again.");
            }

            if (option == 1){balance(currentUser);}
            else if (option ==2) {withdrawals(currentUser);}
            else if (option ==3) {deposit(currentUser);}
            else if (option ==4) {break ;}
            else { option = 0;}
        }

        while (option != 4);
    
        Console.WriteLine("Thank you for using our ATM. Have a nice day!");



       }

    }
    
}