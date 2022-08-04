namespace WebApp_Test.Models
{
    public class Inbox : IRepository<Message>
    {
        private static Inbox _instance = new Inbox();
        public static Inbox SharedInbox => _instance;
        private Dictionary<int, Message> _messages = new Dictionary<int, Message>();
        public Inbox()
        {
            var initialItems = new [] {
                new Message { Id = 1, Title = "Hello!", Text = "Good day!" },
                new Message { Id = 2, Title = "Congratulations!", Text = "You win a prize!" },
                new Message { Id = 3, Title = "Open me (not spam)", Text = "#jkasf lsjfajfs l jakjdf" },
                new Message { Id = 4, Title = "Mr. Smith", Text = "It is a fake person" },
                new Message { Id = 5, Title = "Bubbles", Text = "In tumb, OMG!" },
                new Message { Id = 6, Title = "Big deal", Text = "I pay you 100500" },
                new Message { Id = 7, Title = "My opinion", Text = "Is nothing" },
            };
            foreach (var item in initialItems)
            {
                _messages.Add(item.Id, item);
            }
        }
        public IEnumerable<Message> Items => _messages.Values;

        public void DeleteById(int Id)
        {
            _messages.Remove(Id);
        }
    }
}
