using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SomeMod.Items.Tiles
{
    public class ControlBarTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileFrameImportant[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.addTile(Type);

            drop = mod.ItemType("ControlBar");
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Control Bar");
            AddMapEntry(new Color(255, 255, 250), name);
            minPick = 100;

        }
        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 1;
            g = 1;
            b = 1;
        }  
    }
}
