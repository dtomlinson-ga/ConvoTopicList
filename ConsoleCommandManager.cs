using StardewModdingAPI;
using StardewValley;
using System.Collections.Generic;
using System.Text;

namespace ConvoTopicList
{
	internal class ConsoleCommandManager
	{
		internal static void InitializeConsoleCommands()
		{
			Globals.Helper.ConsoleCommands.Add("vert.ct.list", "Prints current conversation topics and durations.", (_, _) =>
				{
					if (Context.IsWorldReady)
					{
						StringBuilder output = new StringBuilder("Active conversation topics (days remaining):\n");

						foreach (KeyValuePair<string, int> kvp in Game1.player.activeDialogueEvents.Pairs)
						{
							output.AppendLine($"\t{kvp.Key} ({kvp.Value})");
						}

						Log.Info(output.ToString());
					}
					else
					{
						Log.Warn("This command should only be used while a save is loaded.");
					}
				}
			);
		}
	}
}