class Car : Vehicles
{
    public int Speed { get; set; }

    public void on() 
    {
        turn_on++;
    }

    public void off()
    {
        turn_off--;
    }
}