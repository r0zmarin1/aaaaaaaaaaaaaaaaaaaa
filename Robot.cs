// класс робота
using System.Xml.Linq;

internal class Robot
{
    // организовать синглтон и хранение текущих координат
    static Robot instance;

    private Robot()
    {

    }

    static object locker = new object();

    internal int[] robotCoordinates { get; set; }
    public int X { get; set; }
    public int Y { get; set; }


    public static Robot GetInstance()
    {
        lock (locker)
        {
            if (instance == null)
                instance = new Robot();
            return instance;
        }
    }
}

