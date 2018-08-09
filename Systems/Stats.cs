using System;

namespace ExperienceAndClasses.Systems {
    public class Power : Stat {
        private static Lazy<Stat> _instance = new Lazy<Stat>(() => new Stat());
        public static Stat Instance {
            get {
                return _instance.Value;
            }
        }
        
        static Power() {
        }
    }

    public class Dexterity : Stat {
        private static Lazy<Stat> _instance = new Lazy<Stat>(() => new Stat());
        public static Stat Instance {
            get {
                return _instance.Value;
            }
        }

        static Dexterity() {
        }
    }

    public class Stat {
        public float bonus_max_life = 0f;
        public float bonus_max_mana = 0f;
        public float bonus_defense = 0f;

        public void Apply(int amount) {

        }
    }
}
