using MTG.Enumerations;
using MTG.Model.Objects;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Armageddon : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=233
            *  
            *  Destroy all lands.
            *  
            * Rulings

            *  
            */
        public Armageddon() : base()
        {
            MultiverseId = 233;
            Name = "Armageddon";
	        Add(Enumerations.Colors.White);
	        Add(CardType.Sorcery);

            CastingCost castingCost = new CastingCost();
            castingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.White, Count = 1 } });
            castingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Colorless, Count = 3 } });
            Add(new Abilities.Spell.Destroy(castingCost, TargetScope.All, new List<TargetType>(){ TargetType.Land }, false));
        }
        public Armageddon(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
