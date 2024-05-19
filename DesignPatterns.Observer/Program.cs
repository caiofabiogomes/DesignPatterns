using DesignPatterns.Observer;

var publisher = new NewsPublisher();

var subscriber1 = new Subscriber("John");
var subscriber2 = new Subscriber("Alice");
var subscriber3 = new Subscriber("Bob");


publisher.Attach(subscriber1);
publisher.Attach(subscriber2);
publisher.Attach(subscriber3);

publisher.PublishNews("Breaking news: test!");

publisher.Detach(subscriber2);

publisher.PublishNews("New technology launched: test!");

Console.ReadKey();
