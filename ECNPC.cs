using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace ExperienceAndClasses {
    class ECNPC : GlobalNPC {
        private double xp_value = 0;

        public override void SetDefaults(NPC npc) {
            //calculate xp here as monsters spawn before any scaling
            xp_value = Systems.XP.CalculateXPValue(npc);

            base.SetDefaults(npc);
        }
    }
}
