using System;
using System.Threading.Tasks;
using Windows.Security.ExchangeActiveSyncProvisioning;

namespace MyClassLibrary
{
    public class SomeLibraryClass
    {
        public static Task<Guid> DoSomeWork()
        {
            // Use some UWP specific API that unavaliable in .NETStandard.
            var deviceInfo = new EasClientDeviceInformation();
            return Task.FromResult(deviceInfo.Id);
        }
    }
}
