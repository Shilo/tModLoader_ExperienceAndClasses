using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace ExperienceAndClasses {
    public class Constants {
        //colours
        public static readonly Color COLOUR_RED = new Color(255, 0, 0);
        public static readonly Color COLOUR_GREEN = new Color(0, 255, 0);
        public static readonly Color COLOUR_YELLOW = new Color(255, 255, 0);
        public static readonly Color COLOUR_MAGENTA = new Color(255, 0, 255);
        public static readonly Color COLOUR_BOSS_ORB = new Color(233, 36, 91);
        public static readonly Color COLOUR_ASCENSION_ORB = new Color(4, 195, 249);
        public static readonly Color COLOUR_OFF_COOLDOWN = new Color(163, 73, 164);
        public static readonly Color COLOUR_XP = new Color(21, 111, 48);

        //active abilities
        public const int NUMBER_OF_ABILITY_SLOTS = 4;
        private static readonly string[] HOTKEY_DEFAULTS = { "Q", "E", "R", "F" };

        //awarding experience and drops
        public const float RANGE_EXP_AND_ASCENSION_ORB = 2500f;
        public const float PERCENT_CHANCE_BOSS_ORB_FIXED = 5.0f;
        public const float PERCENT_CHANCE_BOSS_ORB_FIXED_SINGLEPLAYER_BONUS = 5.0f;
        public const float PERCENT_CHANCE_BOSS_ORB_VARIABLE = 45.0f;
        public const float PERCENT_CHANCE_ASCENSION_ORB = 0.6f;
        public const float PERCENT_CHANCE_ASCENSION_ORB_EXPERT = 0.7f;

        //map settings constants
        public const double DEFAULT_EXPERIENCE_MODIFIER = 1.0;
        public const double DEFAULT_DEATH_PENALTY = 0.1;

        //ability constants
        public const float HEAL_POWER_PER_IMMUNITY = 0.1f;

        //debuffs
        public static readonly string[] DEBUFF_NAMES = {
            "Bleeding",
            "Poisoned",
            "OnFire",
            "Venom",
            "Darkness",
            "Blackout",
            "Silenced",
            "Cursed",
            "Confused",
            "Slow",
            "Slimed",
            "OgreSpit",
            "Weak",
            "BrokenArmor",
            "WitheredArmor",
            "WitheredWeapon",
            "CursedInferno",
            "Ichor",
            "Chilled",
            "Frozen",
            "Webbed",
            "Stoned",
            "VortexDebuff",
            "Obstructed",
            "Electrified",
            "Rabies",
            "Burning",
            "Frostburn",
            "Oiled",
            "ShadowFlame",
            "BetsysCurse",
            "Dazed",
        };
        public static readonly int NUMBER_OF_DEBUFFS = DEBUFF_NAMES.Length;

        //undead
        public static readonly string[] UNDEAD_NAMES =
        {
            "skel",
            "zomb",
            "groom",
            "bride",
            "undead",
            "viking",
            "eyezor",
            "bone",
            "ghost",
            "ghast",
            "dark caster",
            "skull",
            "dungeon guardian",
            "mummy",
            "tim",
            "ghoul",
            "diabolist",
            "floaty gross",
            "necromancer",
            "ragged caster",
            "wraith",
            "rune wizard",
            "vampire miner",
            "frankenstein",
            "reaper",
            "undead",
            "headless",
        };

        //misc
        public const int LEVEL_START_APPLYING_DEATH_PENALTY = 10;
        public const long AFK_TIME_TICKS_SEC = 60;
    }
}
