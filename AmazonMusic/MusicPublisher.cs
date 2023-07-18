namespace AmazonMusic
{
    public class MusicPublisher
    {
        public delegate void ReleaseHandler(string releaseType, string name, List<string> release);
        public event ReleaseHandler? ReleaseEvent;
        public void PublishRelease(string name, List<string> release)
        {
            string releaseType = release.Count == 1 ? "Single" : "Album";
            ReleaseEvent?.Invoke(releaseType, name, release);
        }
    }
}
