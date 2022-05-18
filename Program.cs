// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


var builder = Host.CreateDefaultBuilder(args);

var host = builder.ConfigureServices((_, services) => services
    .AddSingleton<PersonRepository>()
    .AddScoped<IPersonService, PersonService>())
    .Build();

host.RunAsync();


using (IServiceScope serviceScope = host.Services.CreateScope())
{
    IServiceProvider provider = serviceScope.ServiceProvider;
    IPersonService personService = provider.GetRequiredService<IPersonService>();


    
    Console.Write("How many people would you like to create?");
    int peopleCount = Convert.ToInt32(Console.ReadLine()),
    i = 0 ;


    while (i < peopleCount)
    {
        Console.Write("Please Enter your name:");
        string? name = Console.ReadLine();
        Console.Write("Please Enter your age:");
        int? age = Convert.ToInt32(Console.ReadLine());

        personService.Create(new Person()
        {
            Name = name is null ? "" : name,
            Age = age
        });

        i++;
    }

    foreach (var person in personService.GetList())
        Console.WriteLine(person.ToString());
}


