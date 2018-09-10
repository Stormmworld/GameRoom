using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Activated;
using MTG.Interfaces.Mana_Interfaces;
using System.Collections.Generic;
using MTG.Model.Effects;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Living_Wall : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=29
        *  
        *  Defender (This creature can't attack.)
        *  {1}: Regenerate Living Wall.
        *  
        * Rulings
        *
        */
        public Living_Wall() : base()
        {
            MultiverseId = 29;
            Name = "Living Wall";
            Set(0, 6);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 4)));
            Add(SubType.Wall);
            Add(CardType.Artifact);
            Add(CardType.Creature);
            Add(new EffectGenerator(false, new List<IManaCost>() { new ManaCost(new Mana(Color.Colorless, 1)) }, typeof(RegenerationEffect), new TargetRequirements(TargetScope.Self, TargetType.None), GamePhase.None));
        }
        public Living_Wall(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
