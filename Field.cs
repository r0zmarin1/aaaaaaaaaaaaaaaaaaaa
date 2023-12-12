// класс поля
using System.Xml.Linq;
using System;

internal class Field
{
    // тут организовать синглтон и хранение ячеек в свойстве Cells

        public int Width { get; set; }
        public int Height { get; set; }

        public int[,] Cells { get; set; }

        static Field instance;

        public static Field GetInstance()
        {

            if (instance == null)
            instance = new Field();
            return instance;

        }

    internal bool CheckRobotEndGame(Robot robot)
    { 
        // сравнение координат робота с координатами
        // финишной точки
    }
}

