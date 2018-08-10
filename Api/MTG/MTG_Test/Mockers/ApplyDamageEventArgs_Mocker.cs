
using MTG.ArgumentDefintions.Event_Arguments;
using MTG.Model.Abilities.Static;
using MTG.Model.Objects;

namespace MTG_Test.Mockers
{
    public static class ApplyDamageEventArgs_Mocker
    {
        public static ApplyDamageEventArgs Mock()
        {
            ApplyDamageEventArgs retVal = new ApplyDamageEventArgs() { DamageValue = 1 };
            return retVal;
        }
        public static ApplyDamageEventArgs Mock_Deathtoucn()
        {
            ApplyDamageEventArgs retVal = new ApplyDamageEventArgs() { DamageValue = 1};
            Card deathtouchCard = Card_Mocker.MockCreature(1, 1);
            deathtouchCard.Add(new Deathtouch());
            retVal.addDamageAttributtes(deathtouchCard);
            return retVal;
        }
    }
}
