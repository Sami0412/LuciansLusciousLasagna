class Lasagna
{
    private const int OvenTime = 40;
    private const int MinsPerLayer = 2;

    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return OvenTime;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minsPassed)
    {
        var minsRemaining = OvenTime - minsPassed;
        return minsRemaining;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {
        var totalPrepTime = layers * MinsPerLayer;
        return totalPrepTime;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int minsPassed)
    {
        var elapsedTime = PreparationTimeInMinutes(layers) + minsPassed;
        return elapsedTime;
    }
}