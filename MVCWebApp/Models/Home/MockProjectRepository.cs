using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApp.Models.Home
{
    class MockProjectRepository : IProjectRepository
    {
        public IEnumerable<Project> GetAllProjects =>
            new List<Project>
            {
                new Project {Title = "Calculator", Info = "A simple console calculator", Path = "https://github.com/kembAB/BasicCalculator"},
               new Project {Title = "Calculator", Info = "simple calculator with csharp",Path="https://github.com/kembAB/BasicCalculator"},
                new Project {Title = "sokoban", Info = "sokoban game simulation with javascript",  Path = "https://github.com/kembAB/socobanTrial"},

                new Project{Title = "Calculatorxunit", Info = "calculator with xunit testing ",Path = "https://github.com/kembAB/xunittestCalculator"}
            };
    }
}
