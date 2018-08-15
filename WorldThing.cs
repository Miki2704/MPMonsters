using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Terraria.GameContent.Generation;

namespace SomeMod
{
    public class WorldThing : ModWorld
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (ShiniesIndex != -1)
            {
                tasks.Insert(ShiniesIndex + 1, new PassLegacy("Some Mod Ores", delegate (GenerationProgress progress)
                {
                    progress.Message = "Controlling NPCs...";
                    for (int i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 40E-05); i++)
                    {
                        WorldGen.TileRunner(
                            WorldGen.genRand.Next(0, Main.maxTilesX),
                            WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY),
                            (double)WorldGen.genRand.Next(3, 6),
                            WorldGen.genRand.Next(2, 6),
                            mod.TileType("ControlOreTile"),
                            false,
                            0f,
                            0f,
                            false,
                            true);

                    }
                   
                }));

            }
        }
    }
}
