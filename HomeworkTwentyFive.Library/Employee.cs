using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkTwentyFive.Library
{
    public abstract class Employee : IProfession
    {
        public string Industry { get; set; }
        public int NumberOfExperience { get; set; }
    }
}
