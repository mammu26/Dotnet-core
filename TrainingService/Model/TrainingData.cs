using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingService.Model
{
    public class TrainingData
    {
        public IList<Course> Courses { get; set; }

        public TrainingData()
        {
            Courses = new List<Course>();
        }
    }

    public class Course
    {
        public IList<Training> Trainings { get; set; }

        public string Name { get; set; }

        public Course(string name)
        {
            Name = name;
            Trainings = new List<Training>();
        }
    }
    public class Training
    {
        public string Name { get; set; }

        public Training(string name)
        {
            Name = name;
        }
    }
}
