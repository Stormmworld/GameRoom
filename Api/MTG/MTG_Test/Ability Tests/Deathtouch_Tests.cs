using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTG.ArgumentDefintions.Event_Arguments;
using MTG.Enumerations;
using MTG.Model.Abilities.Static;
using MTG.Model.Objects;
using MTG_Test.Mockers;
using System;
using System.Collections.Generic;

namespace MTG_Test.Ability_Tests
{
    [TestClass]
    public class Deathtouch_Tests
    {
        [TestMethod]
        public void Ability_Deathtouch_GeneratesDeathTouchDamage()
        {
            List<string> applyDamageTypes = new List<string>();
            Card deathtouchCard = Card_Mocker.MockCreature(1,1);
            deathtouchCard.Add(new Deathtouch());
            Damage damage = new Damage()
            {
                BaseValue = deathtouchCard.Power,
                OriginCard = deathtouchCard,          
                Target = Target_Mocker.Mock(Card_Mocker.MockCreature()),
            };
            damage.OnApplyDamage += delegate (object sender, EventArgs e) 
                {
                    foreach(DamageTypes type in ((ApplyDamageEventArgs)e).Types)
                    applyDamageTypes.Add(type.ToString());
                };
            damage.Process();
            Assert.IsTrue(applyDamageTypes.Contains(DamageTypes.Deathtouch.ToString()));
        }
    }
}
