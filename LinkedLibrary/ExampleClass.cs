using System;
using System.Threading.Tasks;

namespace LinkedLibrary
{
    /// <summary>
    /// Basic example class
    /// </summary>
    public class ExampleClass
    {
        /// <summary>
        /// Wait for a specified amount of time
        /// </summary>
        /// <param name="durationToWait">The time to wait for</param>
        public async Task WaitForMeAsync(TimeSpan durationToWait)
        {
            await Task.Delay(durationToWait);
        }
    }
}