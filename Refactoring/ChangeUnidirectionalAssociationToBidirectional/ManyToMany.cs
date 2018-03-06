using System.Collections.Generic;

namespace Refactoring.ChangeUnidirectionalAssociationToBidirectional
{
    public class Student
    {
        readonly string name;
        HashSet<Teacher> teachers = new HashSet<Teacher>();

        public Student(string name)
        {
            this.name = name;
        }

        public IEnumerable<Teacher> Teachers
        {
            get { return teachers; }
        }

        public void AddTeacher(Teacher teacher)
        {
            teacher.FriendStudents.Add(this);
            this.teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            teacher.FriendStudents.Remove(this);
            teachers.Remove(teacher);
        }
    }

    public class Teacher
    {
        private readonly HashSet<Student> students = new HashSet<Student>();
        public string name;

        public Teacher(string name)
        {
            this.name = name;
        }

        public HashSet<Student> FriendStudents => students;

        public void AddStudent(Student student)
        {
            student.AddTeacher(this);
        }

        public void RemoveStudent(Student student)
        {
            student.RemoveTeacher(this);
        }
    }
}
