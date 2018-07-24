﻿using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Hidden_Agenda : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Hidden_agenda
            702.105a Hidden agenda is a static ability that functions as a conspiracy card with hidden agenda is put into the 
                    command zone. “Hidden agenda” means “As you put this conspiracy card into the command zone, turn it face 
                    down and secretly choose a card name.”
            702.105b To secretly choose a card name, note that name on a piece of paper kept with the face-down conspiracy card.
            702.105c Any time you have priority, you may turn a face-down conspiracy card you control in the command zone face 
                    up. This is a special action. Doing so will reveal the chosen name. See rule 115.2h.
            702.105d Hidden agenda and another ability of the object with hidden agenda that refers to “the chosen name” are 
                    linked. The second ability refers only to the card name chosen as a result of that object’s hidden agenda 
                    ability. See rule 607.2d.
            702.105e If a player leaves the game, all face-down conspiracy cards controlled by that player must be revealed to 
            all players. At the end of each game, all face-down conspiracy cards must be revealed to all players.
            702.105f Double agenda is a variant of the hidden agenda ability. As you put a conspiracy card with double agenda 
                    into the command zone, you secretly name two different cards rather than one. You don’t reveal that more 
                    than one name was secretly chosen until you reveal the chosen names.    
        */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Hidden_Agenda.Process");
        }
    }
}
