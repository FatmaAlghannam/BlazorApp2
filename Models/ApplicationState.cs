namespace BlazorApp2.Models
{
    public class ApplicationState
    {
        public int CurrentCounter { get; set; } = 1;

        public void Increment()
        { 
            CurrentCounter++;
        }
    }
}
