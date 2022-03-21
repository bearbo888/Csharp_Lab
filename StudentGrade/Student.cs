using System;

namespace StudentGrade
{
    class Student
    {
        public double chn { get; set; }
        public double eng { get; set; }
        public double math { get; set; }
        public double tol { get; set; }
        public double avg { get; set; }

        public void CalculateTol()
        {
            tol = (chn + eng + math);
        }

        public void CalculateAvg()
        {
            avg = Math.Round((chn + eng + math) / 3);
        }
    }

    class Sort
    {
        public static void BubbleSort(double[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < list.Length - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        double temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }
        public static void BubbleSort(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < list.Length - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }

        public static void BubbleSort(string[,] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < list.GetLength(0) - 1; j++)
                {
                    if (int.Parse(list[j, 0]) > int.Parse(list[j + 1, 0]))
                    {
                        for (int x = 0; x < 2; x++)
                        {
                            var temp = list[j, x];
                            list[j, x] = list[j + 1, x];
                            list[j + 1, x] = temp;
                        }
                    }
                }

            }
        }
    }

}
