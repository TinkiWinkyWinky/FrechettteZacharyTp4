using FrechettteZacharyTp4.Data;
using FrechettteZacharyTp4.Models;
using FrechettteZacharyTp4.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FrechettteZacharyTp4.Services
{
    public class ClientsService(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public ICollection<ClientsInfoVM> GetAll()
        {
            return _context.Clients.Include(c => c.Abonnement).Select(x => new ClientsInfoVM()
            {
                Id = x.Id,
                Nom = x.Nom,
                Age = x.Age,
                Courriel = x.Courriel,
                NoTelephone = x.NoTelephone,
                Type = x.Abonnement.Type,
            }).ToList();
        }

        public bool Remove(int id)
        {
            var client = _context.Clients.Find(id);
            if (client is null)
            {
                return false;
            }
            _context.Clients.Remove(client);
            return _context.SaveChanges() > 0;
        }

        public ClientsCreateVM CreateForm()
        {
            return new ClientsCreateVM()
            {
                Abonnement = context.Abonnements
                .Select(a =>
                    new SelectListItem { Text = a.Type, Value = a.Id.ToString() })
                .ToList(),
            };
        }

        public int Add(ClientsCreateVM vm)
        {
            var client = new Clients()
            {
                Id = 0,
                Nom = vm.Nom,
                Age = vm.Age,
                Courriel= vm.Courriel,
                NoTelephone = vm.NoTelephone,
                AbonnementId = vm.AbonnementId,
            };

            _context.Add(client);
            return _context.SaveChanges();
        }
    }
}
