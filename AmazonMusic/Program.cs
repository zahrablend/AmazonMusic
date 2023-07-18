namespace AmazonMusic
{
    internal static class Program
    {
        static void Main()
        {
            var publisher = new MusicPublisher();
            var subscriber = new MusicSubscriber();

            subscriber.Subscribe(publisher);

            publisher.PublishRelease("Human", new List<string> { "Human" });
            Console.WriteLine(subscriber.Message);
            Console.ReadLine();
            publisher.PublishRelease("People", new List<string> { "Happy", "Sad", "Who cares!" });
            Console.WriteLine(subscriber.Message);
            Console.ReadLine();


        }
    }
}