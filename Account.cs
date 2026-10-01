


public class Account
{
    private double _balanse;
    public Account(double balance)
    {
        _balanse = balance;
    }
    public void Deposite(double deposite)
    {
        _balanse += deposite;
    }
    public void TopUp(double topup)
    {
        if(topup < _balanse)
        {
            _balanse -= topup;
            return;
        }
        System.Console.WriteLine("Sorry but you can't substract more than balance");
    }
    public void PrintBalance()
    {
        System.Console.WriteLine(_balanse);
    }
}