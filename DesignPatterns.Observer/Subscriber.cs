namespace DesignPatterns.Observer
{
    public class Subscriber : IObserver
    {
        private string _name;

        public Subscriber(string name)
        {
            _name = name;
        }

        public void Update(string news)
        {
            Console.WriteLine($"Subscriber {_name} received news: {news}");
        }
    }
}
