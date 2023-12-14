// класс для рисования поля
using System.Diagnostics;
using System.Drawing;

internal class FieldCommander : ICommander
{
    Robot robot = Robot.GetInstance();
    private MainCommander mainCommander;
    public FieldCommander()
    {
    }

    public void Execute(int[] value)
    {
        Paint paint = Paint.GetInstance();

        int a = 0;
        int[,] array1 = new int[5, 5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                array1[i, j] = value[a];
                a++;
                Console.WriteLine(array1[i, j]);
            }
        }

        Field.GetInstance().Cells = array1;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (array1[i, j] == 1)
                    paint.Graphics.FillRectangle(Brushes.Blue, j * 50, i * 50, 50, 50);
                if (array1[i, j] == 2)
                    paint.Graphics.FillRectangle(Brushes.Pink, j * 50, i * 50, 50, 50);
                if (array1[i, j] == 3)
                {
                    robot.X = j;
                    robot.Y = i;
                }      

                if (array1[i, j] == 4)
                {
                    paint.Graphics.FillRectangle(Brushes.BlueViolet, j * 50, i * 50, 50, 50);
                    Field.GetInstance().X = j;
                    Field.GetInstance().Y = i;
                }  
            }
        }


        int[] robotcoor = new int[2];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
                Console.WriteLine(array1[i, j] + " ");
            Console.WriteLine();
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (array1[i, j] == 3)
                {
                    robotcoor[0] = i;
                    robotcoor[1] = j;
                    robot.robotCoordinates = robotcoor;
                }
            }
        }

        // происходит рисование поля, цифры заносятся
        // в объект Field заносятся цифры (одномерный массив
        // в 25 ячеек преобразовываем в двумерный массив 5х5)
        // в объект Robot заносятся координаты



    }
}