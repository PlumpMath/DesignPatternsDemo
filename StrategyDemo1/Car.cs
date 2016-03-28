namespace StrategyDemo1
{
    using static System.Console;

    /// <summary>
    /// handles the implementation of car.
    /// </summary>
    class Car
    {
        /// <summary>
        /// The car type
        /// </summary>
        string carModel = string.Empty;

        /// <summary>
        /// The current location.
        /// </summary>
        CarLocation currentLocation = null;

        /// <summary>
        /// The turn behavior
        /// </summary>
        ITurnBehavior turnBehaviorStrategy = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="modelofCar">The modelof car.</param>
        public Car(string modelofCar)
        {
            this.carModel = modelofCar;
        }

        /// <summary>
        /// Sets the turn behavior.
        /// </summary>
        /// <param name="turnBehavior">The turn behavior.</param>
        public void SetTurnBehavior(ITurnBehavior turnBehavior)
        {
            this.turnBehaviorStrategy = turnBehavior;
        }

        /// <summary>
        /// Turns the left.
        /// </summary>
        public void TurnLeft()
        {
            WriteLine();
            string message = $"Turn left bavior of - {this.carModel}";
            WriteLine(message);

            this.turnBehaviorStrategy.Turn(this.currentLocation);
            this.ArrangeCarDirection();
            this.turnBehaviorStrategy.ApplyCarDirectionEffects();
        }

        /// <summary>
        /// Arranges the car direction.
        /// </summary>
        private void ArrangeCarDirection()
        {
            WriteLine("Arranage car direction based on current location.");
        }
    }
}
