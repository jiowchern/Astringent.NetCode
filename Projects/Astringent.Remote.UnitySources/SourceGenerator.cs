using Microsoft.CodeAnalysis;
using System;
using System.Diagnostics;

namespace Astringent.Remote.UnitySources
{
    [Generator]
    public class SourceGenerator : ISourceGenerator
    {
        void ISourceGenerator.Execute(GeneratorExecutionContext context)
        {


            context.AddSource("asfffffff.cs", @"
namespace AAAA
{
    public class TestClasss 
    {
        public TestClasss(int x,int y )
        {
        }
    }
}

");
        }



        void ISourceGenerator.Initialize(GeneratorInitializationContext context)
        {

#if DEBUG
            if (!Debugger.IsAttached)
            {
                //Debugger.Launch();
            }
#endif

        }
    }
}
