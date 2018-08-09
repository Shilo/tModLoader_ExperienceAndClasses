using Terraria.ModLoader;
using System;
using Terraria.UI;
using Terraria;
using System.Collections.Generic;
using System.IO;
using Terraria.Localization;
using Microsoft.Xna.Framework;
using Terraria.ID;
using System.Reflection;

namespace ExperienceAndClasses {
    /* For Sync Packets */
    enum PacketType : byte {
        
    }

    class ExperienceAndClasses : Mod {
        //active abilities
        public static ModHotKey[] HOTKEY_ABILITY = new ModHotKey[Constants.NUMBER_OF_ABILITY_SLOTS];
        public static ModHotKey HOTKEY_ALTERNATE_EFFECT;

    }
}

//needed for compiling outside of Terraria
public class Application
{
    [STAThread]
    static void Main(string[] args) { }
}