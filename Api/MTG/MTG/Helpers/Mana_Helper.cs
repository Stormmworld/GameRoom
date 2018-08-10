using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTG.Helpers
{
    public static class Mana_Helper
    {
        public static bool CanActivate(CastingCost cost, IAbility ability, ManaPool pool, ref List<Guid> manaToUse)
        {
            List<Mana> availableMana = new List<Mana>();
            availableMana.AddRange(pool.BlackMana.FindAll(o => o.CanUse(ability)));
            availableMana.AddRange(pool.BlueMana.FindAll(o => o.CanUse(ability)));
            availableMana.AddRange(pool.ColorlessMana.FindAll(o => o.CanUse(ability)));
            availableMana.AddRange(pool.GreenMana.FindAll(o => o.CanUse(ability)));
            availableMana.AddRange(pool.RedMana.FindAll(o => o.CanUse(ability)));
            availableMana.AddRange(pool.WhiteMana.FindAll(o => o.CanUse(ability)));

            bool manaFound = true;
            foreach (ManaCost mana in cost.ManaCosts)
            {
                List<Guid> useableMana = new List<Guid>();
                if (getUseableMana(mana.Cost, availableMana, ref useableMana))
                {
                    manaToUse.AddRange(useableMana);
                    availableMana.RemoveAll(o => useableMana.FirstOrDefault(u => u == o.Id) != null);
                    continue;
                }
                if (getUseableMana(mana.Cost, availableMana, ref useableMana))
                {
                    manaToUse.AddRange(useableMana);
                    availableMana.RemoveAll(o => useableMana.FirstOrDefault(u => u == o.Id) != null);
                    continue;
                }
                manaFound = false;
            }
            if (!manaFound)
                manaToUse.Clear();
            return manaFound;
        }
        public static bool CanCast(CastingCost cost, Card spell, ManaPool pool, ref List<Guid> manaToUse)
        {
            List<Mana> availableMana = new List<Mana>();
            availableMana.AddRange(pool.BlackMana.FindAll(o => o.CanUse(spell)));
            availableMana.AddRange(pool.BlueMana.FindAll(o => o.CanUse(spell)));
            availableMana.AddRange(pool.ColorlessMana.FindAll(o => o.CanUse(spell)));
            availableMana.AddRange(pool.GreenMana.FindAll(o => o.CanUse(spell)));
            availableMana.AddRange(pool.RedMana.FindAll(o => o.CanUse(spell)));
            availableMana.AddRange(pool.WhiteMana.FindAll(o => o.CanUse(spell)));

            bool manaFound = true;
            foreach (ManaCost mana in cost.ManaCosts)
            {
                List<Guid> useableMana = new List<Guid>();
                if (getUseableMana(mana.Cost, availableMana, ref useableMana))
                {
                    manaToUse.AddRange(useableMana);
                    availableMana.RemoveAll(o => useableMana.FirstOrDefault(u => u == o.Id) != null);
                    continue;
                }
                if (getUseableMana(mana.Cost, availableMana, ref useableMana))
                {
                    manaToUse.AddRange(useableMana);
                    availableMana.RemoveAll(o => useableMana.FirstOrDefault(u => u == o.Id) != null);
                    continue;
                }
                manaFound = false;
            }
            if (!manaFound)
                manaToUse.Clear();
            return manaFound;
        }
        private static bool getUseableMana(Mana manaNeeded, List<Mana> availableMana, ref List<Guid> useableMana)
        {
            List<Mana> matchMana = availableMana.FindAll(o => o.Color == manaNeeded.Color || manaNeeded.Color == Colors.Colorless);
            if (matchMana != null && matchMana.Count >= manaNeeded.Count)
            {
                for (int i = 0; i < manaNeeded.Count; i++)
                    useableMana.Add(matchMana[i].Id);
                return true;
            }
            return false;
        }
    }
}
