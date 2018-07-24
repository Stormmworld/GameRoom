using MTG.ArgumentDefintions;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{
    public class Equip : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Equip
            702.6a Equip is an activated ability of Equipment cards. “Equip [cost]” means 
                    “[Cost]: Attach this permanent to target creature you control. Activate 
                    this ability only any time you could cast a sorcery.”
            702.6b For more information about Equipment, see rule 301, “Artifacts.”
            702.6c “Equip [quality] creature” is a variant of the equip ability. 
                    “Equip [quality] [cost]” means “[Cost]: Attach this permanent to target [quality] 
                    creature you control. Activate this ability only any time you could cast a sorcery.” 
                    This ability doesn’t restrict what the Equipment may be attached to.
            702.6d An “equip [quality] creature” ability is an equip ability, and an “equip [quality] 
                    creature” cost is an equip cost. Any effect that modifies how or whether a player may
                    activate an equip ability of an object affects “equip [quality] creature” abilities of 
                    that object. Any effect that increases or reduces an equip cost will increase or reduce a 
                    “equip [quality] creature” cost.
            702.6e If a permanent has multiple equip abilities, any of its equip abilities may be activated.
         */
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Equip.Process");
        }
    }
}
