namespace GumballMashine
{
    public class HasQuarterState : State
    {
        GumballMachine gumballMachine;

    public HasQuarterState(GumballMachine gumballMachine)
    {
        this.gumballMachine = gumballMachine;
    }
    public void insertQuarter()
    {
        Console.WriteLine("You can’t insert another quarter");
    }
    public void ejectQuarter()
    {
        Console.WriteLine("Quarter returned");
        gumballMachine.setState(gumballMachine.getNoQuarterState());
    }
    public void turnCrank()
    {
        Console.WriteLine("You turned...");
        gumballMachine.setState(gumballMachine.getSoldState());
    }
    public void dispense()
    {
        Console.WriteLine("No gumball dispensed");
    }
}
}