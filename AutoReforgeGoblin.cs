using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent;

namespace AutoReroll
{
    class AutoReforgeGoblin : GlobalNPC
    {
        public override bool AppliesToEntity(NPC entity, bool lateInstantiation)
        {
            return entity.type == NPCID.GoblinTinkerer;
        }

        public override bool PreChatButtonClicked(NPC npc, NPCInteraction interaction)
        {
            if (!AutoReroll.UseDefaultReforgeMenu && interaction is NPCInteractions.Actions.TinkererReforge)
            {
                Main.npcChatText = "";
                AutoReroll.Instance.ReforgeMenu = true;
            }
            return true;
        }


    }
}
