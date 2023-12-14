// класс для ввода данных
internal class RobotCommander : ICommander
{
    Queue<IRobotCommand> robotCommands = new Queue<IRobotCommand>();
    MoveRobotUpCommand moveRobotUpcommand = new MoveRobotUpCommand();
    MoveRobotDownCommand moveRobotDownCommand = new MoveRobotDownCommand();
    MoveRobotLeftCommand moveRobotLeftCommand = new MoveRobotLeftCommand();
    MoveRobotRightCommand moveRobotRightCommand = new MoveRobotRightCommand();
    DrawRobotCommand drawRobotCommand = new DrawRobotCommand();
    Clean clean = new Clean();

    public RobotCommander()
    {
        robotCommands.Enqueue(new DrawRobotCommand());
        Thread thread = new Thread(RunCommand);
        thread.Start();
    }

    public void Execute(int[] value)
    {
        int number = 0;
        for (int i = 0; i < value.Length; i++)
        {
            number = value[i];

            switch (number)
            {
                case 1:
                    robotCommands.Enqueue(clean);
                    robotCommands.Enqueue(moveRobotUpcommand);
                    break;
                case 2:
                    robotCommands.Enqueue(clean);
                    robotCommands.Enqueue(moveRobotDownCommand);
                    break;
                case 3:
                    robotCommands.Enqueue(clean);
                    robotCommands.Enqueue(moveRobotLeftCommand);
                    break;
                case 4:
                    robotCommands.Enqueue(clean);
                    robotCommands.Enqueue(moveRobotRightCommand);
                    break;
            }
            robotCommands.Enqueue(drawRobotCommand);
        }
        // массив value перебирается сначала до конца
        // на каждую цифру создается соответствующая команда
        // и передается в очередь выполнения команд
        // здесь какой-нибудь switch, который по номеру создается команду
        // можно чередовать команды движения и рисования
    }

    void RunCommand(object obj)
    {
        while (!Field.GetInstance().CheckRobotEndGame(Robot.GetInstance())) 
        {
            Thread.Sleep(100);
            if (robotCommands.Count > 0)
            {
                var command = robotCommands.Dequeue();
                command.Execute();
            }
        }
    }
}

