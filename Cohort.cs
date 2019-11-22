using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Cohort
    {
        public string Name { get; set; }
        public List<Student> Students = new List<Student>();
        public List<Instructor> Instructors = new List<Instructor>();
        public List<Exercise> AllExercises = new List<Exercise>();

        public Cohort(string name)
        {
            Name = name;
        }
    }
}