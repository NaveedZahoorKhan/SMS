using SMS.Presentation;

namespace SMS.Presentation
{
    interface IShell : IShellInteraction
    {
        Shell2 View { get; }
    }
}