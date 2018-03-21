using Refactoring.ReplaceTypeCodeWithClass;
using Xunit;

namespace Refactoring.Tests.ReplaceTypeCodeWithClass
{
    public class StudentFact
    {
        [Fact]
        void should_return__active_after_create_new_student()
        {
            Student student = new Student("Lily", Student.Active);
            Assert.Equal(Student.Active, student.status);
        }

        [Fact]
        void should_return__deleted_after_call_archive()
        {
            Student student = new Student("Lily", Student.Active);
            student.Archive();
            Assert.Equal(Student.Deleted, student.status);
        }

        [Fact]
        void should_return__sleep_after_call_sleep()
        {
            Student student = new Student("Lily", Student.Active);
            student.Sleep();
            Assert.Equal(Student.Sleepd, student.status);
        }
    }
}
