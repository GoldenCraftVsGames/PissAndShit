﻿using Terraria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;

namespace PissAndShit.NPCs
{
    class GodSlimeWorshipper : ModNPC
    {
        private int frameNum = 0;
        private int frameTimer = 0;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("God Slime's Servant");
            Main.npcFrameCount[npc.type] = 5;
        }

        public override void SetDefaults()
        {
            npc.width = 158;
            npc.height = 115;
            
            npc.lifeMax = 50000;
            npc.damage = 200;
            npc.defense = 100;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.aiStyle = 1;
            aiType = NPCID.GreenSlime;
            npc.knockBackResist = 0;
            animationType = NPCID.RainbowSlime;
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * bossLifeScale);
            npc.damage = (int)(npc.damage * 1.3f);
        }
    }
}
