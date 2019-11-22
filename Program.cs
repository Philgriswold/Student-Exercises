using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var philGriswold = new Student("Phil", "Griswold", "Phil Griswold", 35);
            var arynWeatherly = new Student("Aryn", "Weatherly", "Aryn Weatherly", 35);
            var dylanGriffith = new Student("Dylan", "Griffith", "Dylan Griffith", 35);
            var georgeKWilliamson = new Student("George K", "Williamson", "George K Williamson", 35);

            var cohort35 = new Cohort("Cohort35");
            var cohort36 = new Cohort("Cohort36");
            var cohort37 = new Cohort("Cohort37");
            var cohort38 = new Cohort("Cohort38");

            var adamSheaffer = new Instructor("Adam", "Sheaffer", "Adam Sheaffer", 35, "Back end");
            var brendaLong = new Instructor("Brenda", "Long", "Brenda Long", 35, "Front end");
            var madisonPepper = new Instructor("Madison", "Pepper", "Madison Pepper", 35, "JI-ing");

            var theHeist = new Exercise("The Heist", "C Sharp");
            var dictionaryOfWords = new Exercise("Dictionary of Words", "C Sharp");
            var capstone = new Exercise("Capstone", "React");

            adamSheaffer.assignExercise(cohort35.Students, theHeist);
            brendaLong.assignExercise(cohort35.Students, dictionaryOfWords);
            madisonPepper.assignExercise(cohort35.Students, capstone);

            Cohort cohort1 = new Cohort("Cohort 1000");
            Cohort cohort2 = new Cohort("Cohort 2000");
            Cohort cohort3 = new Cohort("Cohort 3000");

            Exercise exercise1 = new Exercise("Build a Ramen Shop", "React");
            Exercise exercise2 = new Exercise("Build a Record Collector", "C sharp");
            Exercise exercise3 = new Exercise("Pass a note", "Java");
            Exercise exercise4 = new Exercise("Make a music sharing app", "Javascript");

            Student fortuMugnano = new Student("Fortunato", "Mugnano", "Fortu Mugnano", 35);
            Student bigDave = new Student("Big", "Dave", "Big Dave", 35);
            Student nickWeasel = new Student("Nick", "Weasel", "Nick Weasel", 35);
            Student dyranGurifusu = new Student("Dyran", "Gurifusu", "Dyran Gurifusu", 35);

            cohort35.Students.Add(fortuMugnano);
            cohort35.Students.Add(bigDave);
            cohort35.Students.Add(nickWeasel);
            cohort35.Students.Add(dyranGurifusu);

            Instructor moSilvera = new Instructor("Mo", "Silvera", "Mo Silvera", 35, "clear commmunication");
            Instructor smartyJones = new Instructor("Smarty", "Jones", "Smarty Jones", 36, "being smart");
            Instructor sweetpeaSmith = new Instructor("Sweetpea", "Smith", "Sweetpea Smith", 34, "being sweet");

            cohort38.Instructors.Add(moSilvera);
            cohort37.Instructors.Add(smartyJones);
            cohort38.Instructors.Add(sweetpeaSmith);

            moSilvera.assignExercise(cohort35.Students, exercise1);
            smartyJones.assignExercise(cohort36.Students, exercise2);
            sweetpeaSmith.assignExercise(cohort37.Students, exercise3);

            List<Student> students = new List<Student>()
            {
                fortuMugnano,
                bigDave,
                nickWeasel,
                dyranGurifusu
            };

            List<Exercise> exercises = new List<Exercise>()
            {
                exercise1,
                exercise2,
                exercise3,
                exercise4
            };
            List<Instructor> instructors = new List<Instructor>()
            {
                moSilvera,
                smartyJones,
                sweetpeaSmith
            };
            List<Cohort> cohorts = new List<Cohort>()
            {
                cohort35,
                cohort36,
                cohort37,
                cohort38
            };

            List<Exercise> jsExercise = exercises.Where(exercise => exercise.Language == "Javascript").ToList();
            foreach (var item in jsExercise)
            {
                Console.WriteLine(jsExercise);
            }

            var cohort35List = (from student in students where student.Cohort == 35 select student).ToList();
            cohort35.Students.ForEach(student =>
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            });

            var cohort35LastNames = students.OrderBy(student => student.LastName).ToList();
            foreach (var item1 in cohort35LastNames)
            {
                Console.WriteLine(item1.LastName);
            }

            var studentNoExercises = students.Where(student => student.Exercises.Count == 0).ToList();
            foreach (var item2 in studentNoExercises)
            {
                Console.WriteLine($"This student with no exercises is {item2.FirstName} {item2.LastName}");
            }

            var studentWithMostExercises = students.Select(student => new
            {
                firstName = student.FirstName,
                    lastName = student.LastName,
                    exerciseCount = student.Exercises.Count()
            }).OrderByDescending(exercises => exercises.exerciseCount).FirstOrDefault();
            Console.WriteLine($"The student with the most exercises is {studentWithMostExercises.firstName} {studentWithMostExercises.lastName}");

            var numberOfStudents = students.Select(student => new
            {
                name = student.Name,
                    studentInCohort = student.StudentList.Count();
            }).ToList();

            foreach (var item5 in numOfStudents)
            {
                Console.WriteLine($"In {item5.name} there are {item5.numOfStudentsInCohort} students.");
            }

        }
    )

}
}
}