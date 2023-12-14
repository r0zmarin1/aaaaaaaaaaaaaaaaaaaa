// класс для ввода данных
internal class MoveRobotLeftCommand : IRobotCommand
{
    public void Execute()
    {// проверяем, может ли робот двигаться влево, если да, меняем ему координаты
        if (Field.GetInstance().Cells.GetLength(1) > Robot.GetInstance().X + 1)
        {
            int a = Field.GetInstance().Cells[Robot.GetInstance().X, Robot.GetInstance().X + 1];
            if (a != 2)
                Robot.GetInstance().X -= 1;
        }
    }
}