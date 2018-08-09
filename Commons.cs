using System;
using Terraria;
using Terraria.ModLoader;

public static class Commons {
    public static bool IsSingleplayer() {
        return Main.netMode == 0;
    }
    public static bool IsClient() {
        return Main.netMode == 1;
    }
    public static bool IsServer() {
        return Main.netMode == 2;
    }
}
