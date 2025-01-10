using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmatics.Test
{
    public class AdvancedMathTestFixture : IDisposable
    {
        private AdvancedMath _testObject;
        public AdvancedMath TestObject { get => _testObject; }

        public AdvancedMathTestFixture()
        {
            _testObject = new AdvancedMath();
        }
        public void Dispose()
        {

        }
    }
}
