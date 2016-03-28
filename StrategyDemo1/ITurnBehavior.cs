namespace StrategyDemo1
{
    /// <summary>
    /// Exposes the turn behavior related actions.
    /// </summary>
    interface ITurnBehavior
    {
        /// <summary>
        /// Turns the specified current location.
        /// </summary>
        /// <param name="currentLocation">The current location.</param>
        /// <returns>The new car location.</returns>
        CarLocation Turn(CarLocation currentLocation);

        /// <summary>
        /// Apply the car direction effects.
        /// </summary>
        void ApplyCarDirectionEffects();
    }
}
