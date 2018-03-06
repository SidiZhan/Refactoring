using System.Linq;
using Refactoring.ChangeUnidirectionalAssociationToBidirectional;
using Xunit;

namespace Refactoring.Tests.ChangeUnidirectionalAssociationToBidirectional
{
    public class ManyToManyTest
    {
        [Fact]
        public void should_add_teacher_from_student()
        {
            var student = new Student("name");
            student.AddTeacher(new Teacher("t"));
            Assert.Equal(1, student.Teachers.Count());
        }

        [Fact]
        public void should_remove_teacher_from_student()
        {
            var student = new Student("name");
            var teacher = new Teacher("t");
            student.AddTeacher(teacher);
            student.RemoveTeacher(teacher);
            Assert.Equal(0, student.Teachers.Count());
        }

        [Fact]
        public void should_remove_student_from_teacher()
        {
            var teacher = new Teacher("t");
            teacher.AddStudent(new Student("s"));
            Assert.Equal(1, teacher.FriendStudents.Count);
        }
    }
}
