using Learning.HotChocolate.Models;

namespace Learning.HotChocolate.GraphQL;

[SubscriptionType]
public static partial class Subscription
{
    [Subscribe]
    [Topic(nameof(User))]
    public static User User([EventMessage] User user) => user;
}
