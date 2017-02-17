using PleimecProject.Core.Interfaces;

namespace PleimecProject.Core.Services
{
    public class CustomService : ICustomService
    {
        public string ProcessInput(string someInput) => string.IsNullOrEmpty(someInput) ? "" : "Process completed";
    }
}
