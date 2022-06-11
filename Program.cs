using System;

namespace FurnitureBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sum = 0;
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                float width = random.Next(200,2800);
                float length = random.Next(200, 2800);
                int edgeW = random.Next(0, 3);
                int edgeL = random.Next(0, 3);
                Board board = new Board(length, width, 18, edgeW, edgeL);
                float cost = board.CostOfEdgeband();
                Console.WriteLine("Płyta {0}: \nD = {1} mm, {3}\nS = {2} mm, {4}\nCena oklejania: {5} zł\n",
                                           i+1, length, width, edgeL, edgeW, cost);
                sum += cost;
            }
            Console.WriteLine("Suma kosztów: {0} zł",sum);
        }
    }
}
