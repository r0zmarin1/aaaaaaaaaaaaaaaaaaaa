﻿// класс для ввода данных
using System.Drawing;

internal class DrawRobotCommand : IRobotCommand
{
    public void Execute()
    {
        //// нарисовать робота по его координатам
        Graphics graphics;
        Paint paint = Paint.GetInstance();
        Robot robot = Robot.GetInstance();
        paint.Graphics.FillRectangle(Brushes.Red, robot.X*50, robot.Y*50, 50, 50);
    }
}

