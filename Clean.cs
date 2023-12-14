// класс для ввода данных
using System.Drawing;

internal class Clean : IRobotCommand
{
    public void Execute()
    {
        //// нарисовать робота по его координатам
        Graphics graphics;
        Paint paint = Paint.GetInstance();
        Robot robot = Robot.GetInstance();
        paint.Graphics.FillRectangle(Brushes.Blue, robot.X * 50, robot.Y * 50, 50, 50);
    }
}