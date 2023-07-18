using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMusic
{
    // Class who receives the notification => Subscriber
    // Getting a notification when an action occurred =>
    // Register with an event and handle it
    public class MusicSubscriber
    {
        public string? Message { get; private set; }
        public void Subscribe(MusicPublisher publisher) =>
            publisher.ReleaseEvent += OnRelease;

        private void OnRelease(string releaseType, string name, List<string> release)
        {
            if (releaseType == "Single")
            {
                Message = $"Received notification of new {releaseType} '{name}' released on 'AmazonMusic'.";
            }
            else
            {
                string releaseContent = string.Join(" | ", release);
                Message = $"Received notification of new {releaseType} '{name}' released on 'AmazonMusic' with songs: {releaseContent}.";
            }
        }  
    }
}
