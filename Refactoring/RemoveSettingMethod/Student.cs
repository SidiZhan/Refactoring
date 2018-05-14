using System;
using System.Collections.Generic;

namespace Refactoring.RemoveSettingMethod
{
    public class Student
    {
        public Guid Id { get; set; }

        public ISet<string> Courses { get; set; }
    }
}
