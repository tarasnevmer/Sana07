using AbstractnessAndException;
using AbstractnessAndException.Products;

Console.OutputEncoding = System.Text.Encoding.UTF8;

ShoppingCart cart = new ShoppingCart();

Keyboard keyboard = new Keyboard("Клавіатура Hator Rockfall", 1999, 1, 
    "Механічна", "Дротове", "Eng/Ukr", "Чорний", 1155);
Computer computer = new Computer("Комп'ютер Artline Gaming", 19299, 1, "GeForce GTX 1650", 
    "AMD Ryzen 5 3600", 16, 7, 480, 4);
Screen monitor = new Screen("Монітор Acer Nitro VG240YM3bmiipx", 5599, 1, 23.8f, 
    "1920x1080", "IPS", 180);

cart.AddToCard(monitor);
cart.AddToCard(keyboard);
cart.AddToCard(computer);

Console.WriteLine(cart.DisplayCart()); ;

Console.WriteLine($"Загальна сума: {cart.CalculateTotal()} грн.");