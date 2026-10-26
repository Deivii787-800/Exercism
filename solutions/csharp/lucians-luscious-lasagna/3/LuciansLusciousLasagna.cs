class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int x)
    {
        int remaining = ExpectedMinutesInOven();
        return remaining - x;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int lasagna_layers) => lasagna_layers * 2;

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers_used, int minutes)
    {
        int layers = PreparationTimeInMinutes(layers_used);
        return layers + minutes;
    }
}
