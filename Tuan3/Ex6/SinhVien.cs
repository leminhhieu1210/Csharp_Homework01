using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6
{
    class SinhVien
    {
        private string id, name;
        private int YoB;
        private float programScores, sqlScores, mediumScores;

        public SinhVien() 
        {
            id = name = null;
            YoB = 0;
            programScores = sqlScores = mediumScores = 0;
        }

        public SinhVien(string id, string name, int YoB, float programScores, float sqlScores)
        {
            this.id = id;
            this.name = name;
            this.YoB = YoB;
            this.programScores = programScores;
            this.sqlScores = sqlScores;
            this.mediumScores = (programScores + sqlScores) / 2;
        }

        public void input()
        {
            Console.Write("Id: ");
            id = Console.ReadLine();

            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("YoB: ");
            YoB = int.Parse(Console.ReadLine());

            Console.Write("programScores: ");
            programScores = float.Parse(Console.ReadLine());

            Console.Write("sqlScores: ");
            sqlScores = float.Parse(Console.ReadLine());

            mediumScores = (programScores + sqlScores) / 2;
        }

        public void output()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("NAME: " + name);
            Console.WriteLine("YEAR OF BIRTH: " + YoB);
            Console.WriteLine("PROGRAM: " + programScores);
            Console.WriteLine("SQL: " + sqlScores);
            Console.WriteLine("MEDIUM: " + mediumScores + "\n");
        }

        public float getterMediumScores()
        {
            return mediumScores;
        }

        public string getterId()
        {
            return id;
        }
    }
}
