namespace StrategyDemo1
{
    using static System.Console;

    /// <summary>
    /// Wobbling turn behavior.
    /// </summary>
    /// <seealso cref="StrategySampleApp1.ITurnBehavior" />
    class WobblingTurn : ITurnBehavior
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
            WriteLine("Apply car direction effects based on the evaluation of wobbling turn location");
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
                currentLocation.PositionY += 4;

                this.carLocation = currentLocation;
            }

            WriteLine("Wobbling turn behavior");

            return currentLocation;
        }
    }
}
