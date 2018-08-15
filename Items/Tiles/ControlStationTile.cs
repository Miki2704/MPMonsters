using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SomeMod.Items.Tiles
{
    public class ControlStationTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolidTop[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            disableSmartCursor = true;
            TileObjectData.addTile(Type);

            drop = mod.ItemType("ControlStation");
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Control Station");
            AddMapEntry(new Color(0, 0, 0), name);
            minPick = 10;
        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("ControlStation"));
        }
    }
}
