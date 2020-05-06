using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingService.Model;

namespace TrainingService.Services
{
    public interface ITrainingService
    {
        IList<Training> GetAllTrainings();

        IList<Course> GetAllCourse();
    }
}
