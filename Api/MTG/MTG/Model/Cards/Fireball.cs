using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Fireball : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=197
        *  
        *  Fireball deals X damage divided evenly, rounded down, among any number of target creatures and/or players.
Fireball costs {1} more to cast for each target beyond the first.
        *  
        * Rulings
        * 2017-11-17: For example, if X is 5 and you choose three target creatures, Fireball has a total cost of {7}{R} (even though its mana cost is just {5}{R} and its converted mana cost is 6). If those creatures are all still legal targets as Fireball resolves, it deals 1 damage to each of them.
        * 2017-11-17: You may cast Fireball with zero targets, regardless of the value chosen for X. If you do so, it will not be a targeted spell, and no damage will actually be dealt when it resolves.
        * 2017-11-17: Fireball's damage is divided as Fireball resolves, not as it's cast, because there are no choices involved. The division involves only targets that are still legal as Fireball resolves.
        * 2017-11-17: You can target more than X creatures. However, if the number of legal targets at the time Fireball resolves is greater than X, none of them will be dealt any damage.

        *
        */
        public Fireball() : base()
        {
            MultiverseId = 197;
            Name = "Fireball";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, true)));
            abilityCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(CardType.Sorcery);

            throw new NotImplementedException("Fireball");
        }
        public Fireball(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
