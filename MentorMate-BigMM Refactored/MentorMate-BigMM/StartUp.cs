using MainEngine.Core;
using MainEngine.Interfaces;
using Interfaces;
using InputReader;
using System.Collections.Generic;
using OutputWriter;

namespace MentorMate_BigMM
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IReadable reader = new Input();
            IDrawable engine = new Engine(reader.GetNumber());
            IWriteable write = new Display();
            write.Print(engine.Run());
        }
    }
}