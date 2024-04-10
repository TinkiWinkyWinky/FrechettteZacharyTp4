using Bogus;
using FrechettteZacharyTp4.Models;
using Seeder;

Console.WriteLine("Début du seed!");

using var context = DbContextFactory.CreateDbContext();

context.Clients.RemoveRange(context.Clients);
context.SaveChanges();

var abonnements = context.Abonnements.ToList();
var clientsFaker = new Faker<Clients>();
clientsFaker
    .RuleFor(x => x.Nom, f => f.Name.FullName())
    .RuleFor(x => x.Age, f => f.Random.Int(20, 75))
    .RuleFor(x => x.Courriel, f => f.Internet.Email())
    .RuleFor(x => x.Abonnement, f => f.PickRandom(abonnements))
    .RuleFor(x => x.NoTelephone, f => f.Phone.PhoneNumber("##########"));

context.Clients.AddRange(clientsFaker.Generate(15));
context.SaveChanges();

Console.WriteLine("Fin du seed!");