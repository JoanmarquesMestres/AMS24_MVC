class AirPlane : Vehicles
{
    public int Latitude { get; set; }

    public void on()
    {
        turn_onn++;
    }

    public void off()
    {
        turn_off--;
    }

}