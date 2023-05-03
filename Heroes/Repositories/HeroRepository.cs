using Heroes.Models.Contracts;
using Heroes.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes.Repositories
{
    internal class HeroRepository : IRepository<IHero>
    {
        private List<IHero> heroes;
        public IReadOnlyCollection<IHero> Models => heroes.AsReadOnly();

        public void Add(IHero model)
        {
            heroes.Add(model);
        }


        public bool Remove(IHero model)
        {
            if (heroes.Remove(model))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public IHero FindByName(string name)
            => heroes.FirstOrDefault(h => h.Name == name);

    }
}
