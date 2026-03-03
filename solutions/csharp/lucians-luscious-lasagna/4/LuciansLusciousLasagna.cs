class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()=> 40;
    
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int timeAlreadyInOven)
    {
        int TimeAlreadyInOven = timeAlreadyInOven;         
        return 40 - TimeAlreadyInOven; 
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int amountOfLayers)
    {
        int AmountOfLayers = amountOfLayers;         
        return 2 * AmountOfLayers;
        
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numberOfLayers, int timeLasagnaHasBeenInOven)
    {
        int NumberOfLayers = numberOfLayers;
        int TimeLasagnaHasBeenInOven = timeLasagnaHasBeenInOven;        
        return NumberOfLayers * 2 + TimeLasagnaHasBeenInOven;
    }
}
