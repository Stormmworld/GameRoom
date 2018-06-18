using System;
using System.Collections.Generic;
using System.Linq;
using FiveColorApi.Classes.Enumerations;
using FiveColorApi.Model;
using Newtonsoft.Json;
using Phase = FiveColorApi.Model.Phase;
using Player = FiveColorApi.Model.Player;

namespace FiveColorApi.Classes
{
    public class Game
    {
        #region Properties
        [JsonProperty(PropertyName = "ActiveStack")]
        public List<StackEntry> ActiveStack { get; set; }        
        [JsonProperty(PropertyName = "Id")]
        public Guid Id { get; set; }
        [JsonProperty(PropertyName = "LandsPlayedThisturn")]
        public int LandsPlayedThisturn { get; set; }
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "Players")]
        public List<Player> Players { get; set; }
        [JsonProperty(PropertyName = "Phase")]
        public Phase Phase { get; set; }
        [JsonProperty(PropertyName = "Rules")]
        public Rules Rules { get; set; }
        [JsonProperty(PropertyName = "Status")]
        public Status Status { get; set; }
        #endregion 

        #region Methods
        public void ActivateEffect()
        {
        }
        public void CastSpell(int playerId, int CardId, List<Target> targets) {

            Card card = FindCard(playerId, CardId);
            ActiveStack.Add(new StackEntry()
            {
                Card = card,
                OwnerId = playerId, 
                Targets = targets
            });
            Player activePlayer = Players.FirstOrDefault(o => o.Stats.Id == playerId);
            activePlayer.Hand.Remove(card);
        }
        public void DrawPhase()
        {
            var currentPlayer = Players.FirstOrDefault(o => o.Stats.Id == Phase.CurrentPlayerId);
            if(currentPlayer == null)
                throw new Exception("Player not found");
            PlayerDrawsXCards(currentPlayer, Rules.DrawCount);
        }
        public void EndPhase()
        {
            switch (Phase.PhaseName)
            {
                case Enumerations.Phase.Beginning:
                    switch (Phase.SubPhaseName)
                    {
                        case SubPhase.Untap:
                            Phase.SubPhaseName = SubPhase.Upkeep;
                            break;
                        case SubPhase.Upkeep:
                            Phase.SubPhaseName = SubPhase.Draw;
                            break;
                        case SubPhase.Draw:
                            Phase.PhaseName = Enumerations.Phase.Main1;
                            Phase.SubPhaseName = SubPhase.None;
                            break;
                    }
                    break;
                case Enumerations.Phase.Main1:
                    Phase.PhaseName = Enumerations.Phase.Combat;
                    Phase.SubPhaseName = SubPhase.AttackDeclaration;
                    break;
                case Enumerations.Phase.Combat:
                    switch (Phase.SubPhaseName)
                    {
                        case SubPhase.AttackDeclaration:
                            Phase.SubPhaseName = SubPhase.DefenseDeclaration;
                            break;
                        case SubPhase.DefenseDeclaration:
                            Phase.SubPhaseName = SubPhase.DamageResolution;
                            break;
                        case SubPhase.DamageResolution:
                            Phase.PhaseName = Enumerations.Phase.Main2;
                            Phase.SubPhaseName = SubPhase.None;
                            break;
                    }
                    break;
                case Enumerations.Phase.Main2:
                    Phase.PhaseName = Enumerations.Phase.Discard;
                    break;
                case Enumerations.Phase.Discard:
                    Phase.PhaseName = Enumerations.Phase.Ending;
                    break;
                case Enumerations.Phase.Ending:
                    EndTurn();
                    break;
            }
            EndOfPhaseDamageReset();
        }
        private void EndOfPhaseDamageReset()
        {
            foreach (Player player in Players)
            {
                player.Stats.DamagePrevention = 0;
                foreach (Card card in player.BattleField)
                {
                    card.DamagePrevention = 0;
                    card.DamageTaken = 0;
                }
            }
        }
        public void EndTurn()
        {
            Player nextPlayer = GetNextPlayer();
            Phase.PhaseName = Enumerations.Phase.Beginning;
            Phase.SubPhaseName = SubPhase.Untap;
            Phase.CurrentPlayer = nextPlayer.Stats.Name;
            Phase.CurrentPlayerId = nextPlayer.Stats.Id;
        }
        private Card FindCard(int playerId, int cardId)
        {
            throw new NotImplementedException();
        }
        public Player GetNextPlayer()
        {
            for (int i = 0; i < Players.Count; i++)
            {
                if (Players[i].Stats.Id == Phase.CurrentPlayerId)
                {
                    for (int j = i + 1; j < Players.Count; j++) // check next element to end of list
                        if (Players[j].LoseCondition == LoseCondition.None)
                            return Players[j];
                    for (int j = 0; j < i; j++)//check first element until the current element 
                        if (Players[j].LoseCondition == LoseCondition.None)
                            return Players[j];
                    break;//end search for current player
                }
            }
            throw new Exception("Next Player not found");
        }
        public List<Card> GetUpkeepCards()
        {
            List<Card> retVal = new List<Card>();

            foreach (Player player in Players)
                foreach (Card card in player.BattleField)
                    if(card.Effects.FirstOrDefault(o=>o.Triggers.Contains(Trigger.Upkeep)) != null)
                            retVal.Add(card);
            return retVal;
        }
        public void PlayerDrawsXCards(Player player, int drawCount)
        {
            if (player.Library.Count < drawCount)
                player.LoseCondition = LoseCondition.NocardsInLibrary;
            else
            {
            for (int i = 0; i < drawCount; i++)
            {
                var currentCard = player.Library[0];
                player.Hand.Add(currentCard);
                player.Library.RemoveAt(0);
            }
            }
        }
        public void ResolveStack()
        {
            while (ActiveStack.Count > 0)
            {
                StackEntry currentEntry = ActiveStack[ActiveStack.Count - 1];
                ActiveStack.RemoveAt(ActiveStack.Count - 1);
                if (currentEntry.Card.Types.Contains("Land"))
                    ProcessLandIntoPlay(currentEntry.OwnerId, currentEntry.Card);
                else
                {
                    foreach (Effect currentEffect in currentEntry.Card.Effects)
                    {
                        switch (currentEffect.Action)
                        {
                            case Enumerations.Action.AddLife:
                                if (currentEntry.Targets != null && currentEntry.Targets.Count > 0)
                                {
                                    foreach (Target currentTarget in currentEntry.Targets)
                                        if (currentTarget.PlayerId > 0)
                                            ProcessAddLifeEffect(currentTarget.PlayerId, currentEffect);
                                        else
                                            ProcessAddLifeEffect(currentEffect);
                                }
                                else
                                    ProcessAddLifeEffect(currentEffect);
                                break;
                            case Enumerations.Action.DealDamage:
                                if (currentEntry.Targets != null && currentEntry.Targets.Count > 0)
                                {
                                    foreach (Target currentTarget in currentEntry.Targets)
                                        if (currentTarget.CardId < 1 && currentTarget.PlayerId > 0)
                                            ProcessDamageEffect(currentTarget.PlayerId, currentEffect);
                                        else if (currentTarget.CardId > 0)
                                            ProcessDamageEffect(FindCard(currentTarget.PlayerId, currentTarget.CardId), currentEffect);
                                        else
                                            ProcessDamageEffect(currentEffect);
                                }
                                else
                                    ProcessDamageEffect(currentEffect);
                                break;
                            case Enumerations.Action.Destroy:
                                if (currentEntry.Targets != null && currentEntry.Targets.Count > 0)
                                {
                                    foreach (Target currentTarget in currentEntry.Targets)
                                        if (currentTarget.CardId > 0)
                                            ProcessDestroyEffect(FindCard(currentTarget.PlayerId, currentTarget.CardId), currentEffect);
                                        else
                                            ProcessDestroyEffect(currentEffect);
                                }
                                else
                                    ProcessDestroyEffect(currentEffect);
                                break;
                            case Enumerations.Action.DrawXCards:
                                if (currentEntry.Targets != null && currentEntry.Targets.Count > 0)
                                {
                                    foreach (Target currentTarget in currentEntry.Targets)
                                        if (currentTarget.PlayerId > 0)
                                            ProcessDrawXCardsEffect(currentTarget.PlayerId, currentEffect);
                                        else
                                            ProcessDrawXCardsEffect(currentEffect);
                                }
                                else
                                    ProcessDrawXCardsEffect(currentEffect);
                                break;
                            case Enumerations.Action.PreventDamage:
                                if (currentEntry.Targets != null && currentEntry.Targets.Count > 0)
                                {
                                    foreach (Target currentTarget in currentEntry.Targets)
                                        if (currentTarget.CardId < 1 && currentTarget.PlayerId > 0)
                                            ProcessPreventDamageEffect(currentTarget.PlayerId, currentEffect);
                                        else if (currentTarget.CardId > 0)
                                            ProcessPreventDamageEffect(FindCard(currentTarget.PlayerId, currentTarget.CardId), currentEffect);
                                        else
                                            ProcessPreventDamageEffect(currentEffect);
                                }
                                else
                                    ProcessPreventDamageEffect(currentEffect);
                                break;
                            case Enumerations.Action.Tap:
                                if (currentEntry.Targets != null && currentEntry.Targets.Count > 0)
                                {
                                    foreach (Target currentTarget in currentEntry.Targets)
                                        if (currentTarget.CardId > 0)
                                            ProcessTapEffect(FindCard(currentTarget.PlayerId, currentTarget.CardId), currentEffect);
                                        else
                                            ProcessTapEffect(currentEffect);
                                }
                                else
                                    ProcessTapEffect(currentEffect);
                                break;
                            case Enumerations.Action.Untap:
                                if (currentEntry.Targets != null && currentEntry.Targets.Count > 0)
                                {
                                    foreach (Target currentTarget in currentEntry.Targets)
                                        if (currentTarget.CardId > 0)
                                            ProcessUnTapEffect(FindCard(currentTarget.PlayerId, currentTarget.CardId), currentEffect);
                                        else
                                            ProcessUnTapEffect(currentEffect);
                                }
                                else
                                    ProcessUnTapEffect(currentEffect);
                                break;
                        }
                    }
                }
            }
        }
        public void Selectdeck(int playerId, long deckId)
        {

        }
        #endregion

        #region Process Effects
        private void ProcessAddLifeEffect(Effect effect)
        {//process add life effect
        }
        private void ProcessAddLifeEffect(int playerId, Effect effect)
        {//process add life effect on target player
            Player targetPlayer = Players.FirstOrDefault(o => o.Stats.Id == playerId);
            targetPlayer.Stats.Life = targetPlayer.Stats.Life + effect.Value;
        }
        private void ProcessDestroyEffect(Effect effect)
        {//proccess destroy effect 
        }
        private void ProcessDestroyEffect(Card card, Effect effect)
        {//proccess destroy effect on target card
            if (!card.Indestructible)
                card.Destroyed = true;
        }
        private void ProcessDrawXCardsEffect(Effect effect)
        {//target player draws x cards
        }
        private void ProcessDrawXCardsEffect(int playerId, Effect effect)
        {//target player draws x cards
            Player targetPlayer = Players.FirstOrDefault(o => o.Stats.Id == playerId);
            PlayerDrawsXCards(targetPlayer, 1);
        }
        private void ProcessDamageEffect(Effect effect)
        {//proccess damage effect 
        }
        private void ProcessDamageEffect(int playerId, Effect effect)
        {//proccess damage effect on target player
            int damageToDeal = effect.Value;
            Player targetPlayer = Players.FirstOrDefault(o => o.Stats.Id == playerId);
            if (targetPlayer.Stats.DamagePrevention > damageToDeal)
            {
                targetPlayer.Stats.DamagePrevention = targetPlayer.Stats.DamagePrevention - damageToDeal;
                damageToDeal = 0;
            }
            else if (targetPlayer.Stats.DamagePrevention > 0)
            {
                damageToDeal = damageToDeal - targetPlayer.Stats.DamagePrevention;
                targetPlayer.Stats.DamagePrevention = 0;
            }
            targetPlayer.Stats.Life = targetPlayer.Stats.Life - damageToDeal;
        }
        private void ProcessDamageEffect(Card card, Effect effect)
        {//proccess damage effect on target card
            if (card.Toughness > 0) //card can take damage
            {
                int damageToDeal = effect.Value;
                if (card.DamagePrevention > damageToDeal)
                {
                    card.DamagePrevention = card.DamagePrevention - damageToDeal;
                    damageToDeal = 0;
                }
                else if (card.DamagePrevention > 0)
                {
                    damageToDeal = damageToDeal - card.DamagePrevention;
                    card.DamagePrevention = 0;
                }
                card.DamageTaken = card.DamageTaken + damageToDeal;
                card.Destroyed = card.Destroyed || card.DamageTaken >= card.Toughness;
            }
        }
        private void ProcessLandIntoPlay(int playerId, Card land)
        {// put land into play under the control of target player
            Player targetPlayer = Players.FirstOrDefault(o=>o.Stats.Id == playerId);
            //need to make decisions on whether land comes into play tapped
            targetPlayer.Lands.Add(land);
            //trigger land count changed events
        }
        private void ProcessPreventDamageEffect(Effect effect)
        {//proccess PreventDamage effect

        }
        private void ProcessPreventDamageEffect(int playerId, Effect effect)
        {//proccess PreventDamage effect on target player
            Player targetPlayer = Players.FirstOrDefault(o=>o.Stats.Id==playerId);
            targetPlayer.Stats.DamagePrevention = targetPlayer.Stats.DamagePrevention + effect.Value;
        }
        private void ProcessPreventDamageEffect(Card card, Effect effect)
        {//proccess PreventDamage effect on target card
            card.DamagePrevention = effect.Value;
        }
        private void ProcessTapEffect(Card card, Effect effect)
        {//proccess tap effect
            card.tapped = true;
        }
        private void ProcessTapEffect(Effect effect)
        {//proccess tap effect on target card
        }
        private void ProcessUnTapEffect(Effect effect)
        {//proccess untap effect
        }
        private void ProcessUnTapEffect(Card card, Effect effect)
        {//proccess untap effect on target card
            card.tapped = false;
        }
        #endregion
    }
}