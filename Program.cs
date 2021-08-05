using ExercicioConjuntos.Entitites;
using System;
using System.Collections.Generic;

namespace ExercicioConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> StudentList = new();

            Console.Write("How many students in course A? ");
            int countA = int.Parse(Console.ReadLine());
            for (int i = 1; i <= countA; i++)
            {
                int studentIdA = int.Parse(Console.ReadLine());
                Student A = new Student(studentIdA);
                StudentList.Add(A);
            }

            Console.Write("How many students in course B? ");
            int countB = int.Parse(Console.ReadLine());
            for (int i = 1; i <= countB; i++)
            {
                int studentIdB = int.Parse(Console.ReadLine());
                Student B = new Student(studentIdB);
                StudentList.Add(B);
            }

            Console.Write("How many students in course C? ");
            int countC = int.Parse(Console.ReadLine());
            for (int i = 1; i <= countC; i++)
            {
                int studentIdC = int.Parse(Console.ReadLine());
                Student C = new Student(studentIdC);
                StudentList.Add(C);
            }

            Console.WriteLine($"Total students: {StudentList.Count}");
        }
    }
}                                   