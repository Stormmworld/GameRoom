using MTG.ArgumentDefintions.Event_Arguments;
using MTG.ArgumentDefintions.Trigger_Arguments;
using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model.Effects;
using MTG.Model.Objects;
using System;
using System.Linq;

namespace MTG.Model.Game
{
    public static class Phases
    {
        public static void InitializationPhase(ActiveGame game)
        {
            throw new NotImplementedException("Phases.InitializationPhase");
        }
        public static void BegginingPhase_UntapStep(ActiveGame game, EventHandler OnEffectTrigger)
        {
            /*
             * https://mtg.gamepedia.com/Beginning_phase#Untap_step
                502.1. First, all phased-in permanents with phasing that the active player controls phase out, and all 
                        phased-out permanents that the active player controlled when they phased out phase in. This all 
                        happens simultaneously. This turn-based action doesn’t use the stack. See rule 702.25, “Phasing.”
                502.2. Second, the active player determines which permanents they control will untap. Then they untap 
                        them all simultaneously. This turn-based action doesn’t use the stack. Normally, all of a player’s 
                        permanents untap, but effects can keep one or more of a player’s permanents from untapping.
                502.3. No player receives priority during the untap step, so no spells can be cast or resolve and no 
                        abilities can be activated or resolve. Any ability that triggers during this step will be held 
                        until the next time a player would receive priority, which is usually during the upkeep step. 
                        (See rule 503, “Upkeep Step.”)
             */
            EffectTriggerEventArgs args = new EffectTriggerEventArgs()
            {
                Args = new PhaseTriggerArgs()
                {
                    ActivePlayer = game.ActivePlayer,
                },
                Trigger = EffectTrigger.Phases_BegginingPhase_UntapStep,
            };
            OnEffectTrigger?.Invoke(null, args);
            game.ActivePlayer.UntapPermanents();
        }
        public static void BegginingPhase_UpkeepStep(ActiveGame game, EventHandler OnEffectTrigger)
        {
            /*
             * https://mtg.gamepedia.com/Beginning_phase#Upkeep_step
                503.1. The upkeep step has no turn-based actions. Once it begins, the active player gets priority. 
                        (See rule 116, “Timing and Priority.”)
                503.1a Any abilities that triggered during the untap step and any abilities that triggered at the 
                        beginning of the upkeep are put onto the stack before the active player gets priority; the 
                        order in which they triggered doesn’t matter. (See rule 603, “Handling Triggered Abilities.”)
                503.2. If a spell states that it may be cast only “after [a player’s] upkeep step,” and the turn 
                        has multiple upkeep steps, that spell may be cast any time after the first upkeep step ends.
             */
            EffectTriggerEventArgs args = new EffectTriggerEventArgs()
            {
                Args = new PhaseTriggerArgs() { ActivePlayer = game.ActivePlayer, },
                Trigger = EffectTrigger.Phases_BegginingPhase_UpkeepStep,
            };
            OnEffectTrigger?.Invoke(null, args);
            foreach (Card card in game.ActivePlayer.Battlefield.FilteredCards(o => o.SummoningSickness))
                card.SummoningSickness = false;
             
        }
        public static void BegginingPhase_UpkeepStep_End(ActiveGame game, EventHandler OnEffectTrigger)
        {
            /*
             * https://mtg.gamepedia.com/Beginning_phase#Upkeep_step
                503.1. The upkeep step has no turn-based actions. Once it begins, the active player gets priority. 
                        (See rule 116, “Timing and Priority.”)
                503.1a Any abilities that triggered during the untap step and any abilities that triggered at the 
                        beginning of the upkeep are put onto the stack before the active player gets priority; the 
                        order in which they triggered doesn’t matter. (See rule 603, “Handling Triggered Abilities.”)
                503.2. If a spell states that it may be cast only “after [a player’s] upkeep step,” and the turn 
                        has multiple upkeep steps, that spell may be cast any time after the first upkeep step ends.
             */
        }
        public static void BegginingPhase_DrawStep(ActiveGame game, EventHandler OnEffectTrigger)
        {
            /*
             * https://mtg.gamepedia.com/Beginning_phase#Draw_step
                504.1. First, the active player draws a card. This turn-based action doesn’t use the stack.
                504.2. Second, the active player gets priority. (See rule 116, “Timing and Priority.”)
             */
            EffectTriggerEventArgs args = new EffectTriggerEventArgs()
            {
                Args = new PhaseTriggerArgs()
                {
                    ActivePlayer = game.ActivePlayer,
                },
                Trigger = EffectTrigger.Phases_BegginingPhase_DrawStep,
            };
            int cardDrawCount = (game.ActiveEffects.FirstOrDefault(o => o is SkipDraw) != null ? 0 : 1);
            foreach (IEffect drawEffect in game.ActiveEffectsByType(typeof(DrawExtraCards)))
                cardDrawCount += ((DrawExtraCards)drawEffect).Value;
            game.ActivePlayer.DrawCards(cardDrawCount, GamePhases.Beginning_Draw);
        }
        public static void PreCombatMainPhase(ActiveGame game, EventHandler OnEffectTrigger)
        {
            EffectTriggerEventArgs args = new EffectTriggerEventArgs()
            {
                Args = new PhaseTriggerArgs()
                {
                    ActivePlayer = game.ActivePlayer,
                },
                Trigger = EffectTrigger.Phases_PreCombatMainPhase,
            };
            OnEffectTrigger?.Invoke(null, args);
            MainPhase(true, game);
        }
        public static void CombatPhase_BeginningStep(ActiveGame game, EventHandler OnEffectTrigger)
        {
            /*
             * https://mtg.gamepedia.com/Beginning_of_combat_step
                507.1. First, if the game being played is a multiplayer game in which the active player’s 
                        opponents don’t all automatically become defending players, the active player chooses 
                        one of their opponents. That player becomes the defending player. This turn-based 
                        action doesn’t use the stack. (See rule 506.2.)
                507.2. Second, the active player gets priority. (See rule 116, “Timing and Priority.”)
             */
            EffectTriggerEventArgs args = new EffectTriggerEventArgs()
            {
                Args = new PhaseTriggerArgs()
                {
                    ActivePlayer = game.ActivePlayer,
                },
                Trigger = EffectTrigger.Phases_CombatPhase_BeginningStep,
            };
        }
        public static void CombatPhase_DeclareAttackersStep(ActiveGame game, EventHandler OnEffectTrigger)
        {
            /*
             * https://mtg.gamepedia.com/Declare_attackers_step
                508.1. First, the active player declares attackers. This turn-based action doesn’t use the stack. To declare attackers, 
                        the active player follows the steps below, in order. If at any point during the declaration of attackers, the 
                        active player is unable to comply with any of the steps listed below, the declaration is illegal; the game returns 
                        to the moment before the declaration (see rule 721, “Handling Illegal Actions”).
                508.1a The active player chooses which creatures that they control, if any, will attack. The chosen creatures must be 
                        untapped, and each one must either have haste or have been controlled by the active player continuously since 
                        the turn began.
                508.1b If the defending player controls any planeswalkers, or the game allows the active player to attack multiple 
                        other players, the active player announces which player or planeswalker each of the chosen creatures is attacking.
                508.1c The active player checks each creature they control to see whether it’s affected by any restrictions (effects 
                        that say a creature can’t attack, or that it can’t attack unless some condition is met). If any restrictions are 
                        being disobeyed, the declaration of attackers is illegal.
                Example: A player controls two creatures, each with a restriction that states “[This creature] can’t attack alone.” It’s 
                        legal to declare both as attackers.
                508.1d The active player checks each creature they control to see whether it’s affected by any requirements (effects 
                        that say a creature attacks if able, or that it attacks if some condition is met). If the number of requirements 
                        that are being obeyed is fewer than the maximum possible number of requirements that could be obeyed without 
                        disobeying any restrictions, the declaration of attackers is illegal. If a creature can’t attack unless a player 
                        pays a cost, that player is not required to pay that cost, even if attacking with that creature would increase the 
                        number of requirements being obeyed. If a requirement that says a creature attacks if able during a certain turn 
                        refers to a turn with multiple combat phases, the creature attacks if able during each declare attackers step in 
                        that turn.
                Example: A player controls two creatures: one that “attacks if able” and one with no abilities. An effect states “No 
                        more than one creature can attack each turn.” The only legal attack is for just the creature that “attacks if able” 
                        to attack. It’s illegal to attack with the other creature, attack with both, or attack with neither.
                508.1e If any of the chosen creatures have banding or a “bands with other” ability, the active player announces which 
                        creatures, if any, are banded with which. (See rule 702.21, “Banding.”)
                508.1f The active player taps the chosen creatures. Tapping a creature when it’s declared as an attacker isn’t a cost; 
                        attacking simply causes creatures to become tapped.
                508.1g If there are any optional costs to attack with the chosen creatures (expressed as costs a player may pay “as” a 
                        creature attacks), the active player chooses which, if any, they will pay.
                508.1h If any of the chosen creatures require paying costs to attack, or if any optional costs to attack were chosen, 
                        the active player determines the total cost to attack. Costs may include paying mana, tapping permanents, sacrificing 
                        permanents, discarding cards, and so on. Once the total cost is determined, it becomes “locked in.” If effects would 
                        change the total cost after this time, ignore this change.
                508.1i If any of the costs require mana, the active player then has a chance to activate mana abilities (see rule 605, 
                        “Mana Abilities”).
                508.1j Once the player has enough mana in their mana pool, they pay all costs in any order. Partial payments are not allowed.
                508.1k Each chosen creature still controlled by the active player becomes an attacking creature. It remains an attacking 
                        creature until it’s removed from combat or the combat phase ends, whichever comes first. See rule 506.4.
                508.1m Any abilities that trigger on attackers being declared trigger.
                508.2. Second, the active player gets priority. (See rule 116, “Timing and Priority.”)
                508.2a Abilities that trigger on a creature attacking trigger only at the point the creature is declared as an attacker. 
                        They will not trigger if a creature attacks and then that creature’s characteristics change to match the ability’s 
                        trigger condition.
                    Example: A permanent has the ability “Whenever a green creature attacks, destroy that creature at end of combat.” If a 
                            blue creature attacks and is later turned green, the ability will not trigger.
                508.2b Any abilities that triggered on attackers being declared or that triggered during the process described in rules 
                        508.1 are put onto the stack before the active player gets priority; the order in which they triggered doesn’t matter. 
                        (See rule 603, “Handling Triggered Abilities.”)
                508.3. Triggered abilities that trigger on attackers being declared may have different trigger conditions.
                508.3a An ability that reads “Whenever [a creature] attacks, . . .” triggers if that creature is declared as an attacker. 
                        Similarly, “Whenever [a creature] attacks [a player or planeswalker], . . .” triggers if that creature is declared 
                        as an attacker attacking that player or planeswalker. Such abilities won’t trigger if a creature is put onto the 
                        battlefield attacking.
                508.3b An ability that reads “Whenever [a player or planeswalker] is attacked, . . .” triggers if one or more creatures are 
                        declared as attackers attacking that player or planeswalker. It won’t trigger if a creature is put onto the battlefield 
                        attacking that player or planeswalker.
                508.3c An ability that reads “Whenever [a player] attacks with [a creature], . . .” triggers whenever a creature that player 
                        controls is declared as an attacker.
                508.3d An ability that reads “Whenever [a creature] attacks and isn’t blocked, . . .” triggers during the declare blockers step, 
                        not the declare attackers step. See rule 509.5g.
                508.4. If a creature is put onto the battlefield attacking, its controller chooses which defending player or which planeswalker a 
                        defending player controls it’s attacking as it enters the battlefield (unless the effect that put it onto the battlefield 
                        specifies what it’s attacking). Such creatures are “attacking” but, for the purposes of trigger events and effects, they 
                        never “attacked.”
                508.4a If the effect that puts a creature onto the battlefield attacking specifies it’s attacking a certain player, and that 
                        player is no longer in the game when the effect resolves, the creature is put onto the battlefield but is never considered 
                        an attacking creature. The same is true if the effect specifies a creature is put onto the battlefield attacking a 
                        planeswalker and that planeswalker is no longer on the battlefield or is no longer a planeswalker when the effect resolves.
                508.4b A creature that’s put onto the battlefield attacking isn’t affected by requirements or restrictions that apply to the 
                        declaration of attackers.
                508.5. If an ability of an attacking creature refers to a defending player, or a spell or ability refers to both an attacking 
                        creature and a defending player, then unless otherwise specified, the defending player it’s referring to is the player 
                        that creature is attacking, or the controller of the planeswalker that creature is attacking. If that creature is no 
                        longer attacking, the defending player it’s referring to is the player that creature was attacking before it was removed 
                        from combat or the controller of the planeswalker that creature was attacking before it was removed from combat.
                508.5a In a multiplayer game, any rule, object, or effect that refers to a “defending player” refers to one specific defending 
                        player, not to all of the defending players. If a spell or ability could apply to multiple attacking creatures, the 
                        appropriate defending player is individually determined for each of those attacking creatures. If there are multiple 
                        defending players that could be chosen, the controller of the spell or ability chooses one.
                508.6. A player is “attacking [a player]” if the first player controls a creature that is attacking the second player. A 
                        player has “attacked [a player]” if the first player declared one or more creatures as attackers attacking the second player.
                508.7. One card (Portal Mage) allows a player to reselect which player or planeswalker a creature is attacking.
                508.7a The attacking creature isn’t removed from combat and it isn’t considered to have attacked a second time. That 
                        creature is attacking the reselected player or planeswalker, but it’s still considered to have attacked the player or 
                        planeswalker chosen as it was declared as an attacker.
                508.7b While reselecting which player or planeswalker a creature is attacking, that creature isn’t affected by 
                        requirements or restrictions that apply to the declaration of attackers.
                508.7c The reselected player or planeswalker must be an opponent of the attacking creature’s controller, or a planeswalker 
                        controlled by an opponent of the attacking creature’s controller.
                508.7d In a multiplayer game not using the attack multiple players option (see rule 802), the reselected player or 
                        planeswalker must be the chosen defending player or a planeswalker controlled by that player.
                508.7e In a multiplayer game using the limited range of influence option (see rule 801), the reselected player or 
                        planeswalker must be within the range of influence of the attacking creature’s controller.
                508.8. If no creatures are declared as attackers or put onto the battlefield attacking, skip the declare blockers and 
                        combat damage steps.
             */
            EffectTriggerEventArgs args = new EffectTriggerEventArgs()
            {
                Args = new PhaseTriggerArgs()
                {
                    ActivePlayer = game.ActivePlayer,
                },
                Trigger = EffectTrigger.Phases_CombatPhase_DeclareAttackersStep,
            };
        }
        public static void CombatPhase_DeclareBlockersStep(ActiveGame game, EventHandler OnEffectTrigger)
        {
            /*
             * https://mtg.gamepedia.com/Declare_blockers_step
                509.1. First, the defending player declares blockers. This turn-based action doesn’t use the stack. To declare blockers, 
                        the defending player follows the steps below, in order. If at any point during the declaration of blockers, the 
                        defending player is unable to comply with any of the steps listed below, the declaration is illegal; the game returns 
                        to the moment before the declaration (see rule 721, “Handling Illegal Actions”).
                509.1a The defending player chooses which creatures they control, if any, will block. The chosen creatures must be untapped. 
                        For each of the chosen creatures, the defending player chooses one creature for it to block that’s attacking that 
                        player or a planeswalker they control.
                509.1b The defending player checks each creature they control to see whether it’s affected by any restrictions (effects 
                        that say a creature can’t block, or that it can’t block unless some condition is met). If any restrictions are being 
                        disobeyed, the declaration of blockers is illegal.::: A restriction may be created by an evasion ability (a static 
                        ability an attacking creature has that restricts what can block it). If an attacking creature gains or loses an evasion 
                        ability after a legal block has been declared, it doesn’t affect that block. Different evasion abilities are cumulative.
                    Example: An attacking creature with flying and shadow can’t be blocked by a creature with flying but without shadow.
                509.1c The defending player checks each creature they control to see whether it’s affected by any requirements (effects 
                        that say a creature must block, or that it must block if some condition is met). If the number of requirements that 
                        are being obeyed is fewer than the maximum possible number of requirements that could be obeyed without disobeying 
                        any restrictions, the declaration of blockers is illegal. If a creature can’t block unless a player pays a cost, 
                        that player is not required to pay that cost, even if blocking with that creature would increase the number of 
                        requirements being obeyed. If a requirement that says a creature blocks if able during a certain turn refers to a 
                        turn with multiple combat phases, the creature blocks if able during each declare blockers step in that turn.
                    Example: A player controls one creature that “blocks if able” and another creature with no abilities. If a creature 
                            with menace attacks that player, the player must block with both creatures. Having only the first creature block 
                            violates the restriction created by menace (the attacking creature can’t be blocked except by two or more 
                            creatures). Having only the second creature block violates both the menace restriction and the first creature’s 
                            blocking requirement. Having neither creature block fulfills the restriction but not the requirement.
                509.1d If any of the chosen creatures require paying costs to block, the defending player determines the total cost to 
                        block. Costs may include paying mana, tapping permanents, sacrificing permanents, discarding cards, and so on. Once 
                        the total cost is determined, it becomes “locked in.” If effects would change the total cost after this time, ignore 
                        this change.
                509.1e If any of the costs require mana, the defending player then has a chance to activate mana abilities (see rule 605, 
                        “Mana Abilities”).
                509.1f Once the player has enough mana in their mana pool, they pay all costs in any order. Partial payments are not allowed.
                509.1g Each chosen creature still controlled by the defending player becomes a blocking creature. Each one is blocking the 
                        attacking creatures chosen for it. It remains a blocking creature until it’s removed from combat or the combat phase 
                        ends, whichever comes first. See rule 506.4.
                509.1h An attacking creature with one or more creatures declared as blockers for it becomes a blocked creature; one with no 
                        creatures declared as blockers for it becomes an unblocked creature. This remains unchanged until the creature is 
                        removed from combat, an effect says that it becomes blocked or unblocked, or the combat phase ends, whichever comes 
                        first. A creature remains blocked even if all the creatures blocking it are removed from combat.
                509.1i Any abilities that trigger on blockers being declared trigger. See rule 509.4 for more information.
                509.2. Second, for each attacking creature that’s become blocked, the active player announces that creature’s damage assignment 
                        order, which consists of the creatures blocking it in an order of that player’s choice. (During the combat damage step, 
                        an attacking creature can’t assign combat damage to a creature that’s blocking it unless each creature ahead of that 
                        blocking creature in its order is assigned lethal damage.) This turn-based action doesn’t use the stack.
                    Example: Vastwood Gorger is blocked by Llanowar Elves, Runeclaw Bear, and Serra Angel. Vastwood Gorger’s controller announces 
                            the Vastwood Gorger’s damage assignment order as Serra Angel, then Llanowar Elves, then Runeclaw Bear.
                509.2a During the declare blockers step, if a blocking creature is removed from combat or a spell or ability causes it to stop 
                        blocking an attacking creature, the blocking creature is removed from all relevant damage assignment orders. The 
                        relative order among the remaining blocking creatures is unchanged.
                509.3. Third, for each blocking creature, the defending player announces that creature’s damage assignment order, which consists 
                        of the creatures it’s blocking in an order of that player’s choice. (During the combat damage step, a blocking creature 
                        can’t assign combat damage to a creature it’s blocking unless each creature ahead of that blocked creature in its order 
                        is assigned lethal damage.) This turn-based action doesn’t use the stack.
                509.3a During the declare blockers step, if an attacking creature is removed from combat or a spell or ability causes it to stop 
                        being blocked by a blocking creature, the attacking creature is removed from all relevant damage assignment orders. 
                        The relative order among the remaining attacking creatures is unchanged.
                509.4. Fourth, the active player gets priority. (See rule 116, “Timing and Priority.”)
                509.4a Any abilities that triggered on blockers being declared or that triggered during the process described in rules 509.1–3 
                        are put onto the stack before the active player gets priority; the order in which they triggered doesn’t matter. 
                        (See rule 603, “Handling Triggered Abilities.”)
                509.5. Triggered abilities that trigger on blockers being declared may have different trigger conditions.
                509.5a An ability that reads “Whenever [a creature] blocks, . . .” generally triggers only once each combat for that creature, 
                        even if it blocks multiple creatures. It triggers if the creature is declared as a blocker. It will also trigger if 
                        that creature becomes a blocker as the result of an effect, but only if it wasn’t a blocking creature at that time. 
                        (See rule 509.1g.) It won’t trigger if the creature is put onto the battlefield blocking.
                509.5b An ability that reads “Whenever [a creature] blocks a creature, . . .” triggers once for each attacking creature the 
                        creature with the ability blocks. It triggers if the creature is declared as a blocker. It will also trigger if an 
                        effect causes that creature to block an attacking creature, but only if it wasn’t already blocking that attacking 
                        creature at that time. It won’t trigger if the creature is put onto the battlefield blocking.
                509.5c An ability that reads “Whenever [a creature] becomes blocked, . . .” generally triggers only once each combat for that 
                        creature, even if it’s blocked by multiple creatures. It will trigger if that creature becomes blocked by at least one 
                        creature declared as a blocker. It will also trigger if that creature becomes blocked by an effect or by a creature 
                        that’s put onto the battlefield as a blocker, but only if the attacking creature was an unblocked creature at that 
                        time. (See rule 509.1h.)
                509.5d An ability that reads “Whenever [a creature] becomes blocked by a creature, . . .” triggers once for each creature that 
                        blocks the named creature. It triggers if a creature is declared as a blocker for the attacking creature. It will also 
                        trigger if an effect causes a creature to block the attacking creature, but only if it wasn’t already blocking that 
                        attacking creature at that time. In addition, it will trigger if a creature is put onto the battlefield blocking that 
                        creature. It won’t trigger if the creature becomes blocked by an effect rather than a creature.
                509.5e If an ability triggers when a creature blocks or becomes blocked by a particular number of creatures, the ability triggers 
                        if the creature blocks or is blocked by that many creatures when blockers are declared. Effects that add or remove 
                        blockers can also cause such abilities to trigger. This applies to abilities that trigger on a creature blocking or 
                        being blocked by at least a certain number of creatures as well.
                509.5f If an ability triggers when a creature with certain characteristics blocks, it will trigger only if the creature has those 
                        characteristics at the point blockers are declared, or at the point an effect causes it to block. If an ability triggers 
                        when a creature with certain characteristics becomes blocked, it will trigger only if the creature has those 
                        characteristics at the point it becomes a blocked creature. If an ability triggers when a creature becomes blocked 
                        by a creature with certain characteristics, it will trigger only if the latter creature has those characteristics at the 
                        point it becomes a blocking creature. None of those abilities will trigger if the relevant creature’s characteristics 
                        change to match the ability’s trigger condition later on.
                    Example: A creature has the ability “Whenever this creature becomes blocked by a white creature, destroy that creature at end 
                            of combat.” If the creature becomes blocked by a black creature that is later turned white, the ability will not trigger.
                509.5g An ability that reads “Whenever [a creature] attacks and isn’t blocked, . . .” triggers if no creatures are declared as 
                        blockers for that creature. It will trigger even if the creature was never declared as an attacker (for example, if 
                        it entered the battlefield attacking). It won’t trigger if the attacking creature is blocked and then all its blockers 
                        are removed from combat.
                509.6. If a spell or ability causes a creature on the battlefield to block an attacking creature, the active player announces the 
                        blocking creature’s placement in the attacking creature’s damage assignment order. The relative order among the 
                        remaining blocking creatures is unchanged. Then the defending player announces the attacking creature’s placement 
                        in the blocking creature’s damage assignment order. The relative order among the remaining attacking creatures is 
                        unchanged. This is done as part of the blocking effect.
                509.7. If a creature is put onto the battlefield blocking, its controller chooses which attacking creature it’s blocking as it 
                        enters the battlefield (unless the effect that put it onto the battlefield specifies what it’s blocking), then the 
                        active player announces the new creature’s placement in the blocked creature’s damage assignment order. The relative 
                        order among the remaining blocking creatures is unchanged. A creature put onto the battlefield this way is “blocking” 
                        but, for the purposes of trigger events and effects, it never “blocked.”
                    Example: Giant Spider is blocked by Canyon Minotaur. The defending player casts Flash Foliage, which creates a Saproling 
                            creature token blocking the Giant Spider. Giant Spider’s controller announces the Giant Spider’s damage assignment 
                            order as the Saproling token, then Canyon Minotaur.
                509.7a If the effect that puts a creature onto the battlefield blocking specifies it’s blocking a certain creature and 
                    that creature is no longer attacking, the creature is put onto the battlefield but is never considered a blocking 
                    creature. The same is true if the controller of the creature that’s put onto the battlefield blocking isn’t a 
                    defending player for the specified attacking creature.
                509.7b A creature that’s put onto the battlefield blocking isn’t affected by requirements or restrictions that apply 
                    to the declaration of blockers.
             */
            EffectTriggerEventArgs args = new EffectTriggerEventArgs()
            {
                Args = new PhaseTriggerArgs()
                {
                    ActivePlayer = game.ActivePlayer,
                },
                Trigger = EffectTrigger.Phases_CombatPhase_DeclareBlockersStep,
            };
        }
        public static void CombatPhase_CombatDamageStep(ActiveGame game, EventHandler OnEffectTrigger)  
        {
            /*
             * https://mtg.gamepedia.com/Combat_damage_step
                510.1. First, the active player announces how each attacking creature assigns its combat damage, then the defending player announces how each blocking creature assigns its combat damage. This turn-based action doesn’t use the stack. A player assigns a creature’s combat damage according to the following rules:
                510.1a Each attacking creature and each blocking creature assigns combat damage equal to its power. Creatures that would assign 0 or less damage this way don’t assign combat damage at all.
                510.1b An unblocked creature assigns its combat damage to the player or planeswalker it’s attacking. If it isn’t currently attacking anything (if, for example, it was attacking a planeswalker that has left the battlefield), it assigns no combat damage.
                510.1c A blocked creature assigns its combat damage to the creatures blocking it. If no creatures are currently blocking it (if, for example, they were destroyed or removed from combat), it assigns no combat damage. If exactly one creature is blocking it, it assigns all its combat damage to that creature. If two or more creatures are blocking it, it assigns its combat damage to those creatures according to the damage assignment order announced for it. This may allow the blocked creature to divide its combat damage. However, it can’t assign combat damage to a creature that’s blocking it unless, when combat damage assignments are complete, each creature that precedes that blocking creature in its order is assigned lethal damage. When checking for assigned lethal damage, take into account damage already marked on the creature and damage from other creatures that’s being assigned during the same combat damage step, but not any abilities or effects that might change the amount of damage that’s actually dealt. An amount of damage that’s greater than a creature’s lethal damage may be assigned to it.
                    Example: The damage assignment order of an attacking Vastwood Gorger (a 5/6 creature) is Pride Guardian (a 0/3 creature) then Llanowar Elves (a 1/1 creature). Vastwood Gorger can assign 3 damage to the Guardian and 2 damage to the Elves, 4 damage to the Guardian and 1 damage to the Elves, or 5 damage to the Guardian.
                    Example: The damage assignment order of an attacking Vastwood Gorger (a 5/6 creature) is Pride Guardian (a 0/3 creature) then Llanowar Elves (a 1/1 creature). During the declare blockers step, the defending player casts Giant Growth targeting Pride Guardian, which gives it +3/+3 until end of turn. Vastwood Gorger must assign its 5 damage to the Guardian.
                    Example: The damage assignment order of an attacking Vastwood Gorger (a 5/6 creature) is Pride Guardian (a 0/3 creature) then Llanowar Elves (a 1/1 creature). During the declare blockers step, the defending player casts Mending Hands targeting Pride Guardian, which prevents the next 4 damage that would be dealt to it. Vastwood Gorger can assign 3 damage to the Guardian and 2 damage to the Elves, 4 damage to the Guardian and 1 damage to the Elves, or 5 damage to the Guardian.
                    Example: The damage assignment order of an attacking Enormous Baloth (a 7/7 creature) is Trained Armodon (a 3/3 creature) that already has 2 damage marked on it, then Foriysian Brigade (a 2/4 creature that can block an additional creature), then Silverback Ape (a 5/5 creature). The damage assignment order of an attacking Durkwood Boars (a 4/4 creature) is the same Foriysian Brigade, then Goblin Piker (a 2/1 creature). Among other possibilities, the active player may have the Baloth assign 1 damage to the Armodon, 1 damage to the Brigade, and 5 damage to the Ape, and have the Boars assign 3 damage to the Brigade and 1 damage to the Piker.
                510.1d A blocking creature assigns combat damage to the creatures it’s blocking. If it isn’t currently blocking any creatures (if, for example, they were destroyed or removed from combat), it assigns no combat damage. If it’s blocking exactly one creature, it assigns all its combat damage to that creature. If it’s blocking two or more creatures, it assigns its combat damage to those creatures according to the damage assignment order announced for it. This may allow the blocking creature to divide its combat damage. However, it can’t assign combat damage to a creature that it’s blocking unless, when combat damage assignments are complete, each creature that precedes that blocked creature is assigned lethal damage. When checking for assigned lethal damage, take into account damage already marked on the creature and damage from other creatures that’s being assigned during the same combat damage step, but not any abilities or effects that might change the amount of damage that’s actually dealt. An amount of damage that’s greater than a creature’s lethal damage may be assigned to it.
                510.1e Once a player has assigned combat damage from each attacking or blocking creature they control, the total damage assignment (not solely the damage assignment of any individual attacking or blocking creature) is checked to see if it complies with the above rules. If it doesn’t, the combat damage assignment is illegal; the game returns to the moment before that player began to assign combat damage. (See rule 721, “Handling Illegal Actions”).
                510.2. Second, all combat damage that’s been assigned is dealt simultaneously. This turn-based action doesn’t use the stack. No player has the chance to cast spells or activate abilities between the time combat damage is assigned and the time it’s dealt.
                    Example: Squadron Hawk (a 1/1 creature with flying) and Goblin Piker (a 2/1 creature) are attacking. Mogg Fanatic (a 1/1 creature with the ability “Sacrifice Mogg Fanatic: Mogg Fanatic deals 1 damage to any target.”) blocks the Goblin Piker. The defending player sacrifices Mogg Fanatic during the declare blockers step to deal 1 damage to the Squadron Hawk. The Hawk is destroyed. The Piker deals and is dealt no combat damage this turn. If the defending player instead left Mogg Fanatic on the battlefield, the Fanatic and the Piker would have dealt lethal damage to one another, but the Squadron Hawk couldn’t have been dealt damage.
                510.3. Third, the active player gets priority. (See rule 116, “Timing and Priority.”)
                510.3a Any abilities that triggered on damage being dealt or while state-based actions are performed afterward are put onto the stack before the active player gets priority; the order in which they triggered doesn’t matter. (See rule 603, “Handling Triggered Abilities.”)
                510.4. If at least one attacking or blocking creature has first strike (see rule 702.7) or double strike (see rule 702.4) as the combat damage step begins, the only creatures that assign combat damage in that step are those with first strike or double strike. After that step, instead of proceeding to the end of combat step, the phase gets a second combat damage step. The only creatures that assign combat damage in that step are the remaining attackers and blockers that had neither first strike nor double strike as the first combat damage step began, as well as the remaining attackers and blockers that currently have double strike. After that step, the phase proceeds to the end of combat step.
             */
            //only process first strike damage
            EffectTriggerEventArgs args = new EffectTriggerEventArgs()
            {
                Args = new PhaseTriggerArgs()
                {
                    ActivePlayer = game.ActivePlayer,
                },
                Trigger = EffectTrigger.Phases_CombatPhase_CombatDamageStep_FirstStrikeDamage,
            };
            if (game.Modifiers.Contains(GameModifier.CombatDamagePrevented))
                return;
            game.ActiveCombat.AssignDamage(true);
            game.ActiveCombat.CommitDamage();
            game.ActiveCombat.AssignDamage(false);
        }
        public static void CombatPhase_EndStep(ActiveGame game, EventHandler OnEffectTrigger)
        {
            /*
             * https://mtg.gamepedia.com/End_of_combat_step
                511.1. The end of combat step has no turn-based actions. Once it begins, the active player gets priority. (See rule 116, “Timing and Priority.”)
                511.2. Abilities that trigger “at end of combat” trigger as the end of combat step begins. Effects that last “until end of combat” expire at the end of the combat phase.
                511.3. As soon as the end of combat step ends, all creatures and planeswalkers are removed from combat. After the end of combat step ends, the combat phase is over and the postcombat main phase begins (see rule 505).
             */
            EffectTriggerEventArgs args = new EffectTriggerEventArgs()
            {
                Args = new PhaseTriggerArgs()
                {
                    ActivePlayer = game.ActivePlayer,
                },
                Trigger = EffectTrigger.Phases_CombatPhase_EndStep,
            };
            //resolve damage and process cards to graveyard
            game.ActiveCombat.CommitDamage();
            //remove effects that end with combat phase
            game.RemoveEffects(GamePhases.Combat_Ending);
            game.ActiveCombat.Clear();
        }
        public static void PostCombatMainPhase(ActiveGame game, EventHandler OnEffectTrigger)
        {
            EffectTriggerEventArgs args = new EffectTriggerEventArgs()
            {
                Args = new PhaseTriggerArgs()
                {
                    ActivePlayer = game.ActivePlayer,
                },
                Trigger = EffectTrigger.Phases_PostCombatMainPhase,
            };
            OnEffectTrigger?.Invoke(null, args);
            MainPhase(false, game);
        }
        public static void EndingPhase_EndStep(ActiveGame game, EventHandler OnEffectTrigger)
        {
            /*
             * https://mtg.gamepedia.com/Ending_phase#End_step
                513.1. The end step has no turn-based actions. Once it begins, the active player gets priority. 
                        (See rule 116, “Timing and Priority.”)
                513.1a Previously, abilities that triggered at the beginning of the end step were printed with 
                        the trigger condition “at end of turn.” Cards that were printed with that text have received 
                        errata in the Oracle card reference to say “at the beginning of the end step” or “at the 
                        beginning of the next end step.”
                513.2. If a permanent with an ability that triggers “at the beginning of the end step” enters 
                        the battlefield during this step, that ability won’t trigger until the next turn’s end step. 
                        Likewise, if a delayed triggered ability that triggers “at the beginning of the next end step” 
                        is created during this step, that ability won’t trigger until the next turn’s end step. In 
                        other words, the step doesn’t “back up” so those abilities can go on the stack. This rule 
                        applies only to triggered abilities; it doesn’t apply to continuous effects whose durations 
                        say “until end of turn” or “this turn.” (See rule 514, “Cleanup Step.”)
             */
            EffectTriggerEventArgs args = new EffectTriggerEventArgs()
            {
                Args = new PhaseTriggerArgs()
                {
                    ActivePlayer = game.ActivePlayer,
                },
                Trigger = EffectTrigger.Phases_CombatPhase_EndStep,
            };
            game.RemoveEffects(GamePhases.Combat_Ending);
        }
        public static void EndingPhase_CleanupStep(ActiveGame game, EventHandler OnEffectTrigger)
        {
            /*
             * https://mtg.gamepedia.com/Ending_phase#Cleanup_step
                514.1. First, if the active player’s hand contains more cards than their maximum hand size (normally seven), they discard enough cards to reduce their hand size to that number. This turn-based action doesn’t use the stack.
                514.2. Second, the following actions happen simultaneously: all damage marked on permanents (including phased-out permanents) is removed and all “until end of turn” and “this turn” effects end. This turn-based action doesn’t use the stack.
                514.3. Normally, no player receives priority during the cleanup step, so no spells can be cast and no abilities can be activated. However, this rule is subject to the following exception:
                514.3a At this point, the game checks to see if any state-based actions would be performed and/or any triggered abilities are waiting to be put onto the stack (including those that trigger “at the beginning of the next cleanup step”). If so, those state-based actions are performed, then those triggered abilities are put on the stack, then the active player gets priority. Players may cast spells and activate abilities. Once the stack is empty and all players pass in succession, another cleanup step begins.
             */
            EffectTriggerEventArgs args = new EffectTriggerEventArgs()
            {
                Args = new PhaseTriggerArgs()
                {
                    ActivePlayer = game.ActivePlayer,
                },
                Trigger = EffectTrigger.Phases_EndingPhase_CleanupStep,
            };
            game.RemoveModifiers(GameModifier.CombatDamagePrevented);
            game.RemoveModifiers(GameModifier.CreaturesTakeNoDamage);

            game.RemoveEffects(GamePhases.Ending_Cleanup);
            game.TurnSpellCount = 0;
        }
        private static void MainPhase(bool preCombat, ActiveGame game)
        {
            /*
             * https://mtg.gamepedia.com/Main_phase
                505.1. There are two main phases in a turn. In each turn, the first main phase (also known as the precombat main phase) 
                        and the second main phase (also known as the postcombat main phase) are separated by the combat phase (see rule 
                        506, “Combat Phase”). The precombat and postcombat main phases are individually and collectively known as the 
                        main phase.
                505.1a Only the first main phase of the turn is a precombat main phase. All other main phases are postcombat main phases. 
                        This includes the second main phase of a turn in which the combat phase has been skipped. It is also true of a turn 
                        in which an effect has caused an additional combat phase and an additional main phase to be created.
                505.2. The main phase has no steps, so a main phase ends when all players pass in succession while the stack is empty. 
                        (See rule 500.2.)
                505.3. First, but only if the players are playing an Archenemy game (see rule 904), the active player is the archenemy, 
                        and it’s the active player’s precombat main phase, the active player sets the top card of their scheme deck in 
                        motion (see rule 701.24). This turn-based action doesn’t use the stack.
                505.4. Second, if the active player controls one or more Saga enchantments and it’s the active player’s precombat main 
                        phase, the active player puts a lore counter on each Saga they control. (See rule 714, “Saga Cards.”) This turn-
                        based action doesn’t use the stack.
                505.5. Third, the active player gets priority. (See rule 116, “Timing and Priority.”)
                505.5a The main phase is the only phase in which a player can normally cast artifact, creature, enchantment, planeswalker, 
                        and sorcery spells. The active player may cast these spells.
                505.5b During either main phase, the active player may play one land card from their hand if the stack is empty, if the 
                        player has priority, and if they haven’t played a land this turn (unless an effect states the player may play 
                        additional lands). This action doesn’t use the stack. Neither the land nor the action of playing the land is a 
                        spell or ability, so it can’t be countered, and players can’t respond to it with instants or activated abilities. 
                        (See rule 305, “Lands.”)
             */
        }
        internal static void NextPhase(ActiveGame game)
        {
            if (game.PendingActions.Count > 0)
                return;
            if (game.OverrideNextPhase != GamePhases.None)
            {
                game.ActivePhase = game.OverrideNextPhase;
                game.OverrideNextPhase = GamePhases.None;
            }
            else
            {
                switch (game.ActivePhase)
                {
                    case GamePhases.None:
                        game.ActivePhase = GamePhases.Beginning_Untap;
                        break;
                    case GamePhases.Beginning_Untap:
                        game.ActivePhase = GamePhases.Beginning_Upkeep;
                        break;
                    case GamePhases.Beginning_Upkeep:
                        game.ActivePhase = GamePhases.Beginning_Draw;
                        break;
                    case GamePhases.Beginning_Draw:
                        game.ActivePhase = GamePhases.PreCombat_Main;
                        break;
                    case GamePhases.PreCombat_Main:
                        game.ActivePhase = GamePhases.Combat_Beginning;
                        break;
                    case GamePhases.Combat_Beginning:
                        game.ActivePhase = GamePhases.Combat_DeclareAttackers;
                        break;
                    case GamePhases.Combat_DeclareAttackers:
                        if(game.ActiveCombat.HasAttackers())
                            game.ActivePhase = GamePhases.Combat_DeclareDefenders;
                        else
                            game.ActivePhase = GamePhases.Combat_Ending;
                        break;
                    case GamePhases.Combat_DeclareDefenders:
                        game.ActivePhase = GamePhases.Combat_Damage;
                        break;
                    case GamePhases.Combat_Damage:
                        game.ActivePhase = GamePhases.Combat_Ending;
                        break;
                    case GamePhases.Combat_Ending:
                        game.ActivePhase = GamePhases.PostCombat_Main;
                        break;
                    case GamePhases.PostCombat_Main:
                        game.ActivePhase = GamePhases.Ending_End;
                        break;
                    case GamePhases.Ending_End:
                        game.ActivePhase = GamePhases.Ending_Cleanup;
                        break;
                    case GamePhases.Ending_Cleanup:
                        game.ActivePhase = GamePhases.Beginning_Untap;
                        game.SetNextPlayer();
                        break;
                }
                if (game.SkipPhases.Contains(game.ActivePhase) || game.ActivePlayer.SkipPhases.Contains(game.ActivePhase))
                    NextPhase(game);
                game.EmptyManaPools();
            }
        }
    }
}
