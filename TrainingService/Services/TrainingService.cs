using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;
using TrainingService.Model;

namespace TrainingService.Services
{
    public class TrainingService : ITrainingService
    {
        public IList<Course> GetAllCourse()
        {
            var trainingData = new TrainingData();

            var location = new Uri(Assembly.GetEntryAssembly().CodeBase).LocalPath;
            var path = Path.GetDirectoryName(location);
            var filePath = Path.Combine(path, "Resource\\TrainingData.xml"); // windows path
            if (!File.Exists(filePath))
            {
                filePath = "/app/CommonPACCatalog.xml"; // hardcoded linux path defined in docker file.
            }

            XDocument doc = XDocument.Load(filePath);

            foreach (var courseelement in doc.XPathSelectElements("//Courses"))
            {
                var course = new Course(courseelement.Attribute("name").Value);
                foreach (var item in courseelement.Elements("Training"))
                {
                    course.Trainings.Add(new Training(item.Attribute("name").Value));
                }

                trainingData.Courses.Add(course);
            }

            return trainingData.Courses;
        }

        public IList<Training> GetAllTrainings()
        {
            return GetAllCourse().SelectMany(s => s.Trainings).ToList();
        }
    }
}
