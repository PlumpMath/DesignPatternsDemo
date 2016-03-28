namespace StrategyDemo1
{
    using static System.Console;

    class Program
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Car car1 = new Car("Huracan");
            Car car2 = new Car("Egoista");

            car1.SetTurnBehavior(new WobblingTurn());
            car2.SetTurnBehavior(new SlidingTurn());

            car1.TurnLeft();
            car2.TurnLeft();

            ReadKey();
        }
    }
}
