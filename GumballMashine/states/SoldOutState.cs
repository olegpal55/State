namespace GumballMashine
{
    public class SoldState : State
    {
        GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine) 
        {
            this.gamballMashine = gumballMachine;
        }

        public void insertQuarter()
        {
            Console.WriteLine("Please wait, we’re already giving you a gumball");
        }
        public void ejectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }
        public void turnCrank()
        {
            Console.WriteLine("Turning twice doesn’t get you another gumball!");
        }
        public void dispense()
        {
            gumballMachine.releaseBall();
            if (gumballMachine.getCount() > 0)
            {
                gumballMachine.setState(gumballMachine.getNoQuarterState());
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs!");
                gumballMachine.setState(gumballMachine.getSoldOutState());
            }
        }
    }
}