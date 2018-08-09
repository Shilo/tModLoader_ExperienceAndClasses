using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using System.Collections.Generic;
using Terraria.Localization;
using Terraria.GameInput;
using System.Linq;
using System.Reflection;

namespace ExperienceAndClasses {
    public class ECPlayer : ModPlayer {
        

        public override void Initialize() {
            base.Initialize();
        }

        public override void OnEnterWorld(Player player) {
            if (Main.LocalPlayer.Equals(player)) {
            }

            base.OnEnterWorld(player);
        }

        public override void OnHitAnything(float x, float y, Entity victim) { //local player only, singleplayer/client only, every kind of hit including minion melee and ranged hits
            if (victim is NPC) {
                NPC npc = (NPC)victim;
                Main.NewText("BONK");
            }
            else if (victim is Player) {
                Player player = (Player)victim;
            }

            base.OnHitAnything(x, y, victim);
        }

        public override void PostUpdate() {
            if (Main.LocalPlayer.Equals(player)) {
            }

            base.PostUpdate();
        }
    }
}