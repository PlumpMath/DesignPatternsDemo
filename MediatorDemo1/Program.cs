namespace MediatorDemo1
{
    using static System.Console;

    class Program
    {
        static void Main(string[] args)
        {
            MediatorSample1();
        }

        private static void MediatorSample1()
        {
            string activityId1 = "act1";
            var mediator = new ActivityMediator();

            //var seller1 = new User(mediator) { Id="us1", Name="user1" };
            //var buyer1 = new User(mediator) { Id = "us2", Name = "user2" };
            //var buyer2 = new User(mediator) { Id = "us3", Name = "user3" };

            var seller1 = new Seller(mediator) { Id = "us1", Name = "user1" };
            var buyer1 = new Buyer(mediator) { Id = "us2", Name = "user2" };
            var buyer2 = new Buyer(mediator) { Id = "us3", Name = "user3" };

            // Register the users.
            WriteLine(string.Empty);
            seller1.RegisterMe();
            buyer1.RegisterMe();
            buyer2.RegisterMe();

            // Create activity.
            WriteLine(string.Empty);
            seller1.CreateActivity(activityId1, "activity 1 - sell watch");

            // Register for Bid.
            WriteLine(string.Empty);
            buyer1.RegisterForBid(activityId1);
            buyer2.RegisterForBid(activityId1);

            // Apply Bid.
            WriteLine(string.Empty);
            buyer1.ApplyBid(activityId1, 10000);
            buyer2.ApplyBid(activityId1, 15000);

            ReadKey();
        }
    }
}
