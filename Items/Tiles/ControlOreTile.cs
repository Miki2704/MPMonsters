using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SomeMod.Items.Tiles
{
	public class ControlOreTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileBlockLight[Type] = true;

            drop = mod.ItemType("ControlOre");
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Control Ore");
            AddMapEntry(new Color(255, 255, 255), name);
            minPick = 50;
                
        }
        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 1;
            g = 1;
            b = 1;
        }
    }
}
