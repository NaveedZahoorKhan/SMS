namespace SMS.Presentation
{
    /// <summary>
    /// Base interface for Views
    /// </summary>
    public interface IView
    {
        object DataContext { get; set; }
    }
}
