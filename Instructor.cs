using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public int Cohort { get; set; }
        public string Specialty { get; set; }

        public Instructor(string firstName, string lastName, string slackHandle, int cohort, string specialty)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort = cohort;
            Specialty = specialty;
        }

        public void assignExercise(List<Student> studentList, Exercise exercise)
        {
            foreach (Student student in studentList)
            {
                student.Exercises.Add(exercise);
            }
        }

    }
}