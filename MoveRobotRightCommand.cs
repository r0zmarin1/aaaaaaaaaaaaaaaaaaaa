// класс для ввода данных
internal class MoveRobotRightCommand : IRobotCommand
{
    public void Execute()
    {// проверяем, может ли робот двигаться вправо, если да, меняем ему координаты
        if (Robot.GetInstance().X - 1 >= 0)
        {
            int a = Field.GetInstance().Cells[Robot.GetInstance().X, Robot.GetInstance().X - 1];
            if (a != 2)
                Robot.GetInstance().X -= 1;
        }
    }
}