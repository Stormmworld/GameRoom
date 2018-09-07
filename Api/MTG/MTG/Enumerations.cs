
namespace MTG.Enumerations
{
    public enum AbilityType
    {
        None,
        Activated,
        Static,
        Triggered
    }
    public enum ActionType
    {
        None,
        Sacrifice_Creature,
        Damage,
        Destroy,
        Discard,
        Discard_Random,
        Remove_From_Game,
    }
    public enum AmountType
    {
        None,
        All,
        AllBut1,
        Defined
    }
    public enum AttackableType
    {
        None,
        Planeswalker,
        Player,
    }
    public enum BandTypes
    {
        None,
        Attacking,
        Defending,
    }
    public enum CardAction
    {
        None,
        Tapped,
        Untapped,
        Attacker,
        Blocker,
    }
    public enum CardType
    {
        None,
        Artifact,
        Creature,
        Enchantment,
        Instant,
        Land,
        Planeswalker,
        Sorcery,
        Tribal,
        Plane,
        Phenomena,
        Vanguard,
        Scheme,
        Conspiracy
    }
    public enum Color
    {
        None = 0,
        Black,
        Blue,
        Colorless,
        Green,
        Multi,
        Red,
        White,
        Same
    }
    public enum CombatState
    {
        None, 
        Blocked,
        UnBlocked
    }
    public enum Comparator
    {
        None, 
        Equal_To,
        Less_Than,
        Greater_Than,
    }
    public enum DamageTypes
    {
        None,
        Trample,
        Unblocked,
        Deathtouch,
        Discard1,
        Discard2,
        Blocked,
    }    
    public enum EffectTrigger
    {
        None,
        Card_Blocked,
        Card_Cast,
        Card_DamageCreature,
        Card_DamagePlayer,
        Card_DealtDamage,
        Card_Destroyed,
        Card_EntersBattleField,
        Card_EntersGraveyard,
        Card_InBattlefield,
        Card_InHand,
        Card_InGraveyard,
        Card_InOpeningHand,
        Card_RecievesDamage,
        Card_SelectedToCast,
        Card_Tapping,
        Card_XDeepInGraveyard,
        Phases_BegginingPhase_UntapStep,
        Phases_BegginingPhase_UpkeepStep,
        Phases_BegginingPhase_DrawStep,
        Phases_PreCombatMainPhase,
        Phases_CombatPhase_BeginningStep,
        Phases_CombatPhase_DeclareAttackersStep,
        Phases_CombatPhase_DeclareBlockersStep,
        Phases_CombatPhase_CombatDamageStep_FirstStrikeDamage,
        Phases_CombatPhase_CombatDamageStep_NormalDamage,
        Phases_CombatPhase_EndStep,
        Phases_PostCombatMainPhase,
        Phases_EndingPhase_EndStep,
        Phases_EndingPhase_CleanupStep,
        Player_Damaged,
        Card_RecievesCounter,
        Cast,
        LandEntersBattlefield,
        Card_AbilityCompleted,
        Aura_Attached,
        Aura_Detached,
        Card_Untapped,
        Card_Tapped,
        Land_EntersGraveYard,
        Player_Discard,
        EnchantedCard_Destroyed,
    }
    public enum GameEvent {
        None,
        Creature_Attacked,
    }
    public enum GameModifier {
        None,
        CreaturesTakeNoDamage,
        CombatDamagePrevented,
    }
    public enum GamePhase
    {
        None = 0,
        Beginning_Untap = 1,
        Beginning_Upkeep = 2,
        Beginning_Draw = 3,
        PreCombat_Main = 4,
        Combat_Beginning = 5,
        Combat_DeclareAttackers = 6,
        Combat_DeclareDefenders = 7,
        Combat_Damage = 9,
        Combat_Ending = 10,
        PostCombat_Main = 11,
        Ending_End = 12,
        Ending_Cleanup = 13
    }
    public enum GameType
    {
        None,
        Melee
    }
    public enum Incrementer
    {
        None,
        Half_ControlledForests_RoundedUp,
        Half_ControlledForests_RoundedDown,
        CurrentPower,
        X,
    }
    public enum InsertLocation
    {
        None,
        Bottom,
        Random,
        Top,
    }
    public enum ManaRestriction
    {
        None,
        Activate_Abilities,
        Activate_Abilities_CardType,
        Color,
        Spell_Type,
        Cumulative_Upkeep,
        Flashback_GraveYard,

    }
    public enum Modifier
    {
        None,
        Assigned,
        ConvertedCost,
        Power,
        Toughness,
        SubTypeDefenderControls,
        SubTypeControllerControls,
        Controlled_Swamp,
        TypeControllerControls,
    }
    public enum SacrificeType
    {
        None,
        Count,
        HighestPower,
        HighestToughness,
    }
    public enum StackEntryType
    {
        None,
        Spell,
        Effect,
    }
    public enum SubType
    {
        None
        , Advisor
        , Aetherborn
        , Ally
        , Angel
        , Antelope
        , Ape
        , Arcane
        , Archer
        , Archon
        , Artificer
        , Assassin
        , AssemblyWorker
        , Atog
        , Aura
        , Aurochs
        , Avatar
        , Azra
        , Badger
        , Barbarian
        , Basilisk
        , Bat
        , Bear
        , Beast
        , Beeble
        , Berserker
        , Bird
        , Blinkmoth
        , Boar
        , Bringer
        , Brushwagg
        , Camarid
        , Camel
        , Caribou
        , Carrier
        , Cartouche
        , Cat
        , Centaur
        , Cephalid
        , Chimera
        , Citizen
        , Cleric
        , Clue
        , Cockatrice
        , Construct
        , Contraption
        , Coward
        , Crab
        , Crocodile
        , Curse
        , Cyclops
        , Dauthi
        , Demon
        , Desert
        , Deserter
        , Devil
        , Dinosaur
        , Djinn
        , Dragon
        , Drake
        , Dreadnought
        , Drone
        , Druid
        , Dryad
        , Dwarf
        , Efreet
        , Egg
        , Elder
        , Eldrazi
        , Elemental
        , Elephant
        , Elf
        , Elk
        , Equipment
        , Eye
        , Faerie
        , Ferret
        , Fish
        , Flagbearer
        , Forest
        , Fortification
        , Fox
        , Frog
        , Fungus
        , Gargoyle
        , Gate
        , Germ
        , Giant
        , Gnome
        , Goat
        , Goblin
        , God
        , Golem
        , Gorgon
        , Graveborn
        , Gremlin
        , Griffin
        , Hag
        , Harpy
        , Hellion
        , Hippo
        , Hippogriff
        , Homarid
        , Homunculus
        , Horror
        , Horse
        , Hound
        , Human
        , Hydra
        , Hyena
        , Illusion
        , Imp
        , Incarnation
        , Insect
        , Island
        , Jackal
        , Jellyfish
        , Juggernaut
        , Kavu
        , Kirin
        , Kithkin
        , Knight
        , Kobold
        , Kor
        , Kraken
        , Lair
        , Lamia
        , Lammasu
        , Leech
        , Leviathan
        , Lhurgoyf
        , Licid
        , Lizard
        , Locus
        , Manticore
        , Masticore
        , Mercenary
        , Merfolk
        , Metathran
        , Minion
        , Minotaur
        , Mole
        , Monger
        , Mongoose
        , Monk
        , Monkey
        , Moonfolk
        , Mutant
        , Myr
        , Mystic
        , Naga
        , Nautilus
        , Nephilim
        , Nightmare
        , Nightstalker
        , Ninja
        , Noggle
        , Nomad
        , Nymph
        , Octopus
        , Ogre
        , Ooze
        , Orb
        , Orc
        , Orgg
        , Ouphe
        , Ox
        , Oyster
        , Pangolin
        , Pegasus
        , Pentavite
        , Pest
        , Phelddagrif
        , Phoenix
        , Pilot
        , Pincher
        , Pirate
        , Plains
        , Plant
        , Praetor
        , Prism
        , Processor
        , Rabbit
        , Rat
        , Rebel
        , Reflection
        , Rhino
        , Rigger
        , Rogue
        , Sable
        , Saga
        , Salamander
        , Samurai
        , Sand
        , Saproling
        , Satyr
        , Scarecrow
        , Scion
        , Scorpion
        , Scout
        , Serf
        , Serpent
        , Servo
        , Shade
        , Shaman
        , Shapeshifter
        , Sheep
        , Shrine
        , Siren
        , Skeleton
        , Slith
        , Sliver
        , Slug
        , Snake
        , Soldier
        , Soltari
        , Spawn
        , Specter
        , Spellshaper
        , Sphinx
        , Spider
        , Spike
        , Spirit
        , Splinter
        , Sponge
        , Squid
        , Squirrel
        , Starfish
        , Surrakar
        , Survivor
        , Swamp
        , Tetravite
        , Thalakos
        , Thopter
        , Thrull
        , Trap
        , Treasure
        , Treefolk
        , Trilobite
        , Triskelavite
        , Troll
        , Turtle
        , Unicorn
        , Urzas_Mine
        , Urzas_PowerPlant
        , Urzas_Tower
        , Vampire
        , Vedalken
        , Vehicle
        , Viashino
        , Volver
        , Wall
        , Warrior
        , Weird
        , Werewolf
        , Whale
        , Wizard
        , Wolf
        , Wolverine
        , Wombat
        , Worm
        , Wraith
        , Wurm
        , Yeti
        , Zombie
        , Zubera
            //planeswalker sub types
        , Ajani
        , Angrath
        , Arlinn
        , Ashiok
        , Bolas
        , Chandra
        , Dack
        , Daretti
        , Domri
        , Dovin
        , Elspeth
        , Freyalise
        , Garruk
        , Gideon
        , Huatli
        , Jace
        , Jaya
        , Karn
        , Kaya
        , Kiora
        , Koth
        , Liliana
        , Nahiri
        , Narset
        , Nissa
        , Nixilis
        , Ral
        , Rowan
        , Saheeli
        , Samut
        , Sarkhan
        , Sorin
        , Tamiyo
        , Teferi
        , Tezzeret
        , Tibalt
        , Ugin
        , Venser
        , Vivien
        , Vraska
        , Will
        , Xenagos
        , Yanggu
        , Yanling,
        Mountain
    }
    public enum SuperType
    {
        None,
        Basic,
        Elite,
        Host,
        Legendary,
        Ongoing,
        Snow,
        World,
    }
    public enum TappingTypes
    {
        None,
        Tapped,
        UnTapped
    }
    public enum TargetScope
    {
        None,
        All,
        Single,
        Opponents,
        Specified_Number,
        Self,
        Controller,
        ActivePlayer,
        Owner,
    }
    public enum TargetType
    {
        None,
        Card,
        Player,
        EnchantedController,
        EnchantedCard,
    }
    public enum TargetZone
    {
        None,
        Ante,
        Battlefield,
        Command,
        Exile,
        Graveyard,
        Hand,
        PhasedOut,
        Stack,
        Library,
    }
}
