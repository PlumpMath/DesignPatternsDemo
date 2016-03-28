namespace StrategyDemo1
{
    using static System.Console;

    /// <summary>
    /// Sliding turn behavior.
    /// </summary>
    /// <seealso cref="StrategySampleApp1.ITurnBehavior" />
    class SlidingTurn : ITurnBehavior
    {
        /// <summary>
        /// The car location.
        /// </summary>
        CarLocation carLocation = null;

        /// <summary>
        /// Apply the car direction effects.
        /// </summary>
        public void ApplyCarDirectionEffects()
        {
            WriteLine("Apply car direction effects based on the evaluation of sliding turn location");
        }

        /// <summary>
        /// Turns the specified current location.
        /// </summary>
        /// <param name="currentLocation">The current location.</param>
        /// <returns>
        /// The new car location.
        /// </returns>
        public CarLocation Turn(CarLocation currentLocation)
        {
            if (currentLocation != null)
            {
                currentLocation.Positionx -= 2;
                currentLocation.PositionY += 6;

                this.carLocation = currentLocation;
            }

            WriteLine("Sliding turn behavior");

            return currentLocation;
        }
    }
}
