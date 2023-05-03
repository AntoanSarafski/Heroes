using Heroes.Models.Contracts;
using Heroes.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes.Repositories
{
    public class WeaponRepository : IRepository<IWeapon>
    {
        private List<IWeapon> weapons;
        public IReadOnlyCollection<IWeapon> Models => weapons.AsReadOnly();

        public void Add(IWeapon model)
        {
            weapons.Add(model);
        }


        public bool Remove(IWeapon model)
        {
            if (weapons.Remove(model))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public IWeapon FindByName(string name)
            => weapons.FirstOrDefault(w => w.Name == name);
    }
}
