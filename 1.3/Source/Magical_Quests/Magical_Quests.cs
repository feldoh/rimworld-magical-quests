using System.Reflection;
using System.Linq;
using Verse;
using RimWorld;
using UnityEngine;
using HarmonyLib;

namespace Magical_Quests
{
	public class Mod : Verse.Mod
	{
	public static Settings settings;
		public Mod(ModContentPack content) : base(content)
		{
			Log.Message("Hello world from Magical Quests");

			// initialize settings
			settings = GetSettings<Settings>();

#if DEBUG
			Harmony.DEBUG = true;
#endif

			Harmony harmony = new Harmony("Taggerung.rimworld.Magical_Quests.main");	
			harmony.PatchAll();
		}

		public override void DoSettingsWindowContents(Rect inRect)
		{
			base.DoSettingsWindowContents(inRect);
			settings.DoWindowContents(inRect);
		}

		public override string SettingsCategory()
		{
			return "Magical Quests";
		}
	}
}