using System;

namespace DesignPatterns.Observer
{
    public class NewsPublisher : ISubject
    {
        private List<IObserver> _subscribers = new List<IObserver>();
        private string _latestNews;

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Attached new subscriber.");
            _subscribers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _subscribers.Remove(observer);
            Console.WriteLine("Detached a subscriber.");
        }

        public void Notify()
        {
            Console.WriteLine("Notifying subscribers...");
            foreach (var observer in _subscribers)
            {
                observer.Update(_latestNews);
            }
        }

        public void PublishNews(string news)
        {
            _latestNews = news;
            Notify();
        }
    }
}
