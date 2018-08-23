using MTG.Model.Objects;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Ankh_of_Mishra : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=1
            *  
            *  Whenever a land enters the battlefield, Ankh of Mishra deals 2 damage to that land's controller.
            *  
            * Rulings
		        2004-10-04: This triggers on any land entering the battlefield. This includes playing a land or putting a land onto the battlefield using a spell or ability.
		        2004-10-04: It determines the land's controller at the time the ability resolves. If the land leaves the battlefield before the ability resolves, the land's last controller before it left is used.
            *  
            */
        public Ankh_of_Mishra() : base()
        {
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Colorless, Count = 2 } });
            MultiverseId = 1;
            Name = "Ankh of Mishra";
            Add(Enumerations.CardType.Artifact);
            Add(new Abilities.Triggered.Damage(2, new List<Enumerations.TargetType>() { Enumerations.TargetType.Player }, Enumerations.EffectTrigger.LandEntersBattlefield));
        }
        public Ankh_of_Mishra(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
