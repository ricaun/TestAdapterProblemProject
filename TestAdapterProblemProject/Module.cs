#if NETFRAMEWORK
using System;
using System.Linq;
using System.Runtime.CompilerServices;
class Module
{
    [ModuleInitializer]
    internal static void Initialize()
    {
        if (AppDomain.CurrentDomain.GetAssemblies().Any(e => e.GetName().Name.Contains("RevitTest")))
            throw new NotSupportedException("This module should not be used by RevitTest.");
    }
}
namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    internal sealed class ModuleInitializerAttribute : Attribute { }
}
#endif
