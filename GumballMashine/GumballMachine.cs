using GumballMashine.states;

namespace GumballMashine
{
    public class GumballMachine
    {
        public static State soldOutState;
        public static State noQuarterState;
        public static State hasQuarterState;
        public static State soldState;

        State state;


        int count = 0;

        public GumballMachine(int numberGumballs)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            this.count = numberGumballs;
            if (numberGumballs > 0)
            {
                state = noQuarterState;
            }
            else
            {
                state = soldOutState;
            }
        }
        public void insertQuarter()
        {
            state.insertQuarter();
        }
        public void ejectQuarter()
        {
            state.ejectQuarter();
        }
        public void turnCrank()
        {
            state.turnCrank();
            state.dispense();
        }
        public void setState(State state)
        {
            this.state = state;
        }
        public void releaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (count != 0)
            {
                count--;
            }
        }
    }
}