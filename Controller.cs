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
        string command = "";
        int i = 0;

        Console.WriteLine("aaaaa");
        command = Console.ReadLine();
        int[] array = command.Select(x => int.Parse(x.ToString())).ToArray();

        mainCommander.Execute(array);

        mainCommander.SetInterpretator(new RobotCommander());

        while (true)
        {
            Console.WriteLine("Введите команды");
            command = Console.ReadLine();
            int[] g = command.Select(x => int.Parse(x.ToString())).ToArray();
            mainCommander.Execute(g);
        }
        // первый запрос на 25 символов (рисование поля) передается mainCommander в метод Execute
        // смена интерпретатора у mainCommander на RobotCommander
        // остальные запросы передаются туда же (цикл, пока робот не достигнет конечной точки)
    }
}
