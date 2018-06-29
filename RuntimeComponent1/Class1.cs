using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;

namespace RuntimeComponent1
{
    public sealed class Class1
    {
        public IAsyncOperation<string> GetExample()
        {
            return AsyncInfo.Run(token => Task.Run(getExample));
        }

        private async Task<string> getExample()
        {
            return "It's working";
        }
    }
}
