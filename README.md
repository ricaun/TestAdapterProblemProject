# TestAdapterProblemProject

Sample project with 3 test projects with the same `NUnit` in `net48`.

### TestAdapterProblemProject

Project with the `NUnit` `TestAdapter`.

### TestProjectNoAdapter

Project with without `TestAdapter`.

### TestProjectRevitAdapter

Project with `RevitTest` `TestAdapter`.

## `Test Explorer` Problem

When build the solution, the `TestAdapter` trigger for all the projects.

![Image](https://github.com/user-attachments/assets/c3b28817-02f5-4c1e-9650-eccab960faab)

This duplicate the tests in the `Test Explorer` because the solution have two projects with two different `TestAdapter`.

The project without any `TestAdapter` is triggered as well and shows in the `Test Explorer`.

**The duplication tests only happens in net framework**

## Workaround

The workaround is force the `TestAdapter` to fail to discovery the tests.

### `TestAdapterProblemProject` & `TestProjectNoAdapter`

To force `RevitTest` to fail to discovery the tests add the code throw an exception when the assembly is loaded.

**Module.cs**
```C#
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
```

**RevitModule.cs**

To force `NUnit3TestAdapter` to fail to discovery the tests add the code with a `Journaling` attribute or any other Revit API reference.

```C#
#if NETFRAMEWORK
using Autodesk.Revit.Attributes;

[Journaling(JournalingMode.NoCommandData)]
class RevitModule {
    // Class with 'Journaling' Revit reference to prevent 'NUnit3TestAdapter' to discovery tests.
}
#endif
```

### Result

![image](https://github.com/user-attachments/assets/f44e5f90-4955-45c2-8091-acdf86b8f237)

---