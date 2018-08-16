using System;
using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model.Abilities;
using MTG.Model.Counters;
using MTG.Model.Objects;

namespace MTG_Test.Mockers
{
    public static class Card_Mocker
    {
        public static Card Mock()
        {
            return new Card()
            {
                Name = "Test Card",
            };
        }        
        public static Card MockCreature( int power = 3, int toughness = 3)
        {
            Card retVal = new Card(power, toughness)
            {
                Name = "Test Creature",
                CastingCost = new CastingCost() { ManaCosts = new System.Collections.Generic.List<ManaCost>() { new ManaCost() { Cost = new Mana() { Color = Colors.Blue, Count = 1 } } } },
            };
            retVal.Add(CardType.Creature);
            return retVal;
        }
        public static Deck MockDeck()
        {
            Deck retVal = new Deck()
            {
                Name = "Test Deck"
            };
            for (int i = 0; i < 30; i++)
            {
                retVal.Cards.Add(MockLand());
            }
            for (int i = 0; i < 10; i++)
            {
                retVal.Cards.Add(MockCreature());
            }
            for (int i = 0; i < 10; i++)
            {
                retVal.Cards.Add(MockInstant());
            }
            for (int i = 0; i < 5; i++)
            {
                retVal.Cards.Add(MockSorcery());
            }
            for (int i = 0; i < 5; i++)
            {
                retVal.Cards.Add(MockPlaneswalker(2));
            }

            return retVal;
        }
        public static Deck MockDeck_CreaturesAndLand()
        {
            Deck retVal = new Deck()
            {
                Name = "Test Deck Creatures and Land"
            };
            for (int i = 0; i < 30; i++)
            {
                retVal.Cards.Add(MockLand());
            }
            for (int i = 0; i < 30; i++)
            {
                retVal.Cards.Add(MockCreature(3,3));
            }

            return retVal;
        }
        public static Deck MockDeck_InstantsAndLand()
        {
            Deck retVal = new Deck()
            {
                Name = "Test Deck Instants and Land"
            };
            for (int i = 0; i < 30; i++)
            {
                retVal.Cards.Add(MockLand());
            }
            for (int i = 0; i < 30; i++)
            {
                retVal.Cards.Add(MockInstant());
            }

            return retVal;
        }
        public static Deck MockDeck_LandOnly()
        {
            Deck retVal = new Deck()
            {
                Name = "Test Deck"
            };
            for (int i = 0; i < 60; i++)
            {
                retVal.Cards.Add(MockLand());
            }

            return retVal;
        }
        public static Deck MockDeck_NoLand()
        {
            Deck retVal = new Deck()
            {
                Name = "Test Deck"
            };
            for (int i = 0; i < 60; i++)
            {
                retVal.Cards.Add(MockSorcery());
            }

            return retVal;
        }
        public static Card MockCreatureWithAbility(IAbility ability, int power = 3, int toughness = 3)
        {
            Card retVal = new Card(power, toughness)
            {
                Name = "Test Creature with " + ability.ToString()
            };
            retVal.Add(CardType.Creature);
            retVal.Add(ability);
            return retVal;
        }
        public static Card MockPlaneswalker(int loyaltyCount)
        {
            Card retVal = new Card()
            {
                Name = "Test Planeswalker"
            };
            for (int i = 0; i < loyaltyCount; i++)
                retVal.Add(new Loyalty() );
            retVal.Add(CardType.Planeswalker);
            return retVal;
        }
        public static Card MockLand()
        {
            Card retVal = new Card()
            {
                Name = "Test Land"

            };
            retVal.Add(CardType.Land);
            retVal.Add(new ManaSource(new Mana() { Color = Colors.Blue, Count = 1 }) { RequiresTap = true });
            return retVal;
        }
        public static Card MockInstant()
        {
            Card retVal = new Card()
            {
                Name = "Test Instant",                
                CastingCost = new CastingCost() { ManaCosts = new System.Collections.Generic.List<ManaCost>() { new ManaCost() { Cost = new Mana() { Color = Colors.Blue, Count = 1 } } } },
            };
            retVal.Add(CardType.Instant);
            retVal.Add(new MTG.Model.Abilities.Spell.Damage(3, TargetScope.Single, new List<TargetType>() { TargetType.Player }, true));
            return retVal;
        }
        public static Card MockSorcery()
        {
            Card retVal = new Card()
            {
                Name = "Test Sorcery",
                CastingCost = new CastingCost() { ManaCosts = new System.Collections.Generic.List<ManaCost>() { new ManaCost() { Cost = new Mana() { Color = Colors.Blue, Count = 1 } } } },
            };
            retVal.Add(CardType.Sorcery);
            return retVal;
        }
    }
}
