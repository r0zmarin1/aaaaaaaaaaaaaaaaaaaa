// класс для ввода данных
internal class Controller
{
    private MainCommander mainCommander;

    public Controller(MainCommander mainCommander)
    {
        this.mainCommander = mainCommander;
        mainCommander.SetInterpretator(new FieldCommander());
    }

    // цикл по запросу команды
    internal void StartListner()
    {
        int[] array = new int[25];
        for (int i = 0; i < array.Length; i++)
        {
            int.TryParse(Console.ReadLine(), out int field);
            array[i] = field;
        }

        mainCommander.Execute(array);

        mainCommander.SetInterpretator(new RobotCommander());

        while (true)
        {
            Console.WriteLine("Введите команды");
            int.TryParse(Console.ReadLine(), out int commands);
            mainCommander.Execute(int[] { commands});
        }
        // первый запрос на 25 символов (рисование поля) передается mainCommander в метод Execute
        // смена интерпретатора у mainCommander на RobotCommander
        // остальные запросы передаются туда же (цикл, пока робот не достигнет конечной точки)
    }
}
