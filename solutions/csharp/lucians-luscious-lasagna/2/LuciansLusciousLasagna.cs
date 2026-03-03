class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        
        return 40;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int timeAlreadyInOven)
    {
        int TimeAlreadyInOven = timeAlreadyInOven;
        int TimeLeft = 40 - TimeAlreadyInOven; 
        return TimeLeft;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int amountOfLayers)
    {
        int AmountOfLayers = amountOfLayers;
        int PrepTime = 2 * AmountOfLayers;
        return PrepTime;
        
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numberOfLayers, int timeLasagnaHasBeenInOven)
    {
        int NumberOfLayers = numberOfLayers;
        int TimeLasagnaHasBeenInOven = timeLasagnaHasBeenInOven;
        int ElapsedTimeInMinutes = ((NumberOfLayers * 2) + TimeLasagnaHasBeenInOven);
        return ElapsedTimeInMinutes;
    }
}
