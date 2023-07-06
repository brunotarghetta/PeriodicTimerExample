using PeriodicTimerExampleApp;
Console.WriteLine("Press any button to start");
Console.ReadKey();

var task = new BackGroundTask(TimeSpan.FromSeconds(1)); 
task.Start();

Console.WriteLine("Press any button to start task");
Console.ReadKey();

await task.StopAsync();