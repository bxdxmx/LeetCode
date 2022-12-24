public class ParkingSystem
{
    private int[] counter;

    public ParkingSystem(int big, int medium, int small)
    {
        counter= new int[3] { big, medium, small };
    }

    public bool AddCar(int carType)
    {
        if (counter[carType - 1] == 0)
        {
            return false;
        }
        else
        {
            counter[carType - 1]--;
            return true;
        }
    }
}
