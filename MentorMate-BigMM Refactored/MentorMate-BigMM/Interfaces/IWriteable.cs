using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IWriteable
    {
        void Print(IReadOnlyList<string> forOutput);
    }
}
