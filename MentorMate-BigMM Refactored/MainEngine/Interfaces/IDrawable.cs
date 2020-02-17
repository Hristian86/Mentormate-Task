using System;
using System.Collections.Generic;
using System.Text;

namespace MainEngine.Interfaces
{
    public interface IDrawable
    {
        IReadOnlyList<string> Run();
    }
}
