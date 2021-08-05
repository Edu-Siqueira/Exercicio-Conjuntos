using System;

namespace ExercicioConjuntos.Entitites
{
    class Student
    {
        public int Id { get; set; }

        public Student()
        {
        }

        public Student(int id)
        {
            Id = id;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Student))
            {
                return false;
            }

            Student other = obj as Student;
            return Id.Equals(other.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
