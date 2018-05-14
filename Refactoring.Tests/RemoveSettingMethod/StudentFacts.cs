using System;
using System.Collections.Generic;
using System.Linq;
using Refactoring.RemoveSettingMethod;
using Xunit;

namespace Refactoring.Tests.RemoveSettingMethod
{
    public class StudentFacts
    {
        readonly Guid id;
        readonly Student student;

        public StudentFacts()
        {
            id = Guid.NewGuid();
            student = new Student
            {
                Id = id,
                Courses = new HashSet<string>
                {
                    "English",
                    "Math"
                }
            };
        }

        [Fact]
        void should_get_student()
        {
            Assert.Equal(id, student.Id);
            Assert.Equal(new []{"English", "Math"}, student.Courses.OrderBy(e => e).ToArray());
        }
    }
}
