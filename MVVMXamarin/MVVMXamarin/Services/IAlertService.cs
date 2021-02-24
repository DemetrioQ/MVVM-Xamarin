using System;
using System.Threading.Tasks;

namespace MVVMXamarin.Services
{
    public interface IAlertService
    {
        Task AlertAsync(string title, string description);
    }
}
