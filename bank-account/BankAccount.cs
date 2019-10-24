using System;

public class BankAccount
{
    //To control abnormal behaviour of an object in a multi-threaded environment is called as Thread Safety.
    //In a multi-thread environment it ensures that only one thread to be executed in given moment of time and other threads have to wait till entered thread completes its work/ executes its work.
    private decimal balance;

    private bool isClose;

    //define a lock reference.see https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/lock-statement
    private object _lockObj = new object();

    public void Open()
    {
        isClose = false;
        balance = 0;
    }

    public void Close()
    {
        isClose = true;
    }

    // propertities
    public decimal Balance
    {
        //logic to throw an exception when the account is closed
        get
        {
            if (isClose) throw new InvalidOperationException();
            else return balance;
        }
    }

    public void UpdateBalance(decimal change)
    {
        //While a lock is held, the thread that holds the lock can again acquire and release the lock. Any other thread is blocked from acquiring the lock and waits until the lock is released.
        lock (_lockObj)
        {
            balance += change;
        }
    }
}