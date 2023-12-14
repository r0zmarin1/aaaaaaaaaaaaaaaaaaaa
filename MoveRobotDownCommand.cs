// класс для ввода данных
internal class MoveRobotDownCommand : IRobotCommand
{
    public void Execute()
    {// проверяем, может ли робот двигаться вниз, если да, меняем ему координаты
        if (Field.GetInstance().Cells.GetLength(1) > Robot.GetInstance().Y + 1)
        {
            int a = Field.GetInstance().Cells[Robot.GetInstance().X, Robot.GetInstance().Y + 1];
            if (a != 2)
                Robot.GetInstance().Y += 1;
        }
    }
}