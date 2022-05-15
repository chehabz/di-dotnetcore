// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


var builder = Host.CreateDefaultBuilder(args);

var host = builder.ConfigureServices((_, services)=> services
    .AddTransient<PersonRepository>()
    .AddScoped<IPersonService, PersonService>())
    .Build();

host.RunAsync();


using (IServiceScope serviceScope = host.Services.CreateScope()){
    IServiceProvider provider = serviceScope.ServiceProvider;
    IPersonService personService = provider.GetRequiredService<IPersonService>();

    var person = personService.GetPerson();
    Console.WriteLine($"Hello {person.Name}");
}


