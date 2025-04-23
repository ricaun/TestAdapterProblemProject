#if NETFRAMEWORK
using Autodesk.Revit.Attributes;

[Journaling(JournalingMode.NoCommandData)]
class RevitModule {
    // Class with 'Journaling' Revit reference to prevent 'NUnit3TestAdapter' to discovery tests.
}
#endif