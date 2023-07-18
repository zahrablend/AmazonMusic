namespace AmazonMusic
{
    // Delegate defines the signature for the event handler method of the subscriber class
    public delegate void ReleaseHandler(string releaseType, string name, List<string> release);
    // Class who raises events => Publisher
    // Raises an event when some action occurred
    public class MusicPublisher
    {
        // Event is an encapsulated delegate in c#
        // Event is dependent on the delegate
        public event ReleaseHandler? ReleaseEvent;
        public void PublishRelease(string name, List<string> release)
        {
            string releaseType = release.Count == 1 ? "Single" : "Album";
            ReleaseEvent?.Invoke(releaseType, name, release);
        }
    }
}
