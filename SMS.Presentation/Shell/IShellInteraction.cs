using System;
using System.ComponentModel;
using System.Windows.Input;


namespace SMS.Presentation
{

    public interface IShellInteraction
    {
        event CancelEventAction OnShellClosing;
        event Action OnShellClosed;
    }

    public delegate void CancelEventAction(CancelEventArgs e);
}
