
using N28_T1.EventBus;
using N28_T1.Events;
using N28_T1.Models;

var eventBus = new InMemoryEventBus();

eventBus.Subscribe<OrderCreatedEvent>(e =>
{
    Console.WriteLine($"[OrderCreatedEvent] OrderCreatedEvent keldi: {e.OrderId}, " +
        $"User Id: {e.UserId}, Amount: {e.Amount}");
    return Task.CompletedTask;
});

eventBus.Subscribe<BonusAchievedEvent>(e =>
{
    Console.WriteLine($"[Handler] BonusAchievedEvent keldi: {e.UserId}, {e.OldBonus}, -> {e.NewBonus}");
    return Task.CompletedTask;
});

var user = new User
{
    Id = 1,
    FullName = "Jasur Abdulhayev",
    Email = "jasurabdulxaev@gmail.com",
    Bonus = new Bonus { Id = 1, UserId = 1, TotalAmount = 89m }
};

async Task CreateOrderAsync(User forUser, decimal amount)
{
    var order = new Order
    {
        Id = 1,
        UserId = forUser.Id,
        Amount = amount,
        CreatedAt = DateTime.UtcNow
    };
    Console.WriteLine($"[CreateOrderAsync] Order yaratildi: {order.Id}, User Id: {order.UserId}, Amount: {order.Amount}");
    await eventBus.PublishAsync(new OrderCreatedEvent
    {
        OrderId = order.Id,
        UserId = order.UserId,
        Amount = order.Amount
    });
    // Bonus hisoblash logikasi
    var oldBonus = forUser.Bonus?.TotalAmount ?? 0m;
    var newBonus = oldBonus + (amount * 0.1m); // Masalan, 10% bonus
    if (newBonus > oldBonus)
    {
        forUser.Bonus!.TotalAmount = newBonus;
        await eventBus.PublishAsync(new BonusAchievedEvent
        {
            UserId = forUser.Id,
            OldBonus = oldBonus,
            NewBonus = newBonus
        });
    }
}

await CreateOrderAsync(user, 100m);
await CreateOrderAsync(user, 50m);
await CreateOrderAsync(user, 40m);

Console.WriteLine($"\nUser '{user.FullName}' has a total bonus of {user.Bonus?.TotalAmount ?? 0m}");
