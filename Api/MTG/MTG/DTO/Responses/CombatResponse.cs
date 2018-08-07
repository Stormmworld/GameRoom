using MTG.Enumerations;
using MTG.Model;
using MTG.Model.Objects;
using System.Collections.Generic;

namespace MTG.DTO.Responses
{
    public class CombatResponse
    {
        public List<AttackableTarget> AttackableTargets { get; set; }
        public List<Band> AttackingBands { get; set; }
        public List<AttackingCreature> AttackingCreatures { get; set; }

        public CombatResponse()
        {
            AttackingBands = new List<Band>();
            AttackingCreatures = new List<AttackingCreature>();
            AttackableTargets = new List<AttackableTarget>();
        }
        public CombatResponse(ActiveGame game) : this()
        {
            foreach (Player player in game.Players)
            {
                AttackableTargets.Add(new AttackableTarget() { AttackableType = AttackableType.Player, Id = player.Id, Name = player.Name });
                foreach (Card planeswalker in player.Battlefield.FilteredCards(o => o.HasType(CardType.Planeswalker)))
                    AttackableTargets.Add(new AttackableTarget() { AttackableType = AttackableType.Planeswalker, Id = planeswalker.Id, Name = planeswalker.Name + "(" + player.Name + ")" });
            }
            AttackingBands.AddRange(game.ActiveCombat.AttackingBands);
            AttackingCreatures.AddRange(game.ActiveCombat.Attackers);
        }
    }
}
