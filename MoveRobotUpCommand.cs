// класс для ввода данных
internal class MoveRobotUpCommand : IRobotCommand
{
    public void Execute()
    {// проверяем, может ли робот двигаться вверх, если да, меняем ему координаты
        if (Robot.GetInstance().Y - 1 >= 0)
        {
            int a = Field.GetInstance().Cells[Robot.GetInstance().X, Robot.GetInstance().Y - 1];
            if (a != 2)
                Robot.GetInstance().Y -= 1;
        }
    }
}