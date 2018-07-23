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

        /// <summary>
        /// Does some calculation and return some value
        /// </summary>
        /// <param name="value1">First value</param>
        /// <param name="value2">Second value</param>
        /// <returns>Some answer</returns>
        public int DoSomeMaths(int value1, int value2)
        {
            var result1 = value1 + value2;
            var result2 = value1 * value2;
            return result1 + result2;
        }
    }
}