using HarmonyLib;
using OWML.ModHelper;
using System.Reflection;

namespace EnableMeditation
{
	[HarmonyPatch]
	public class EnableMeditation : ModBehaviour
	{
		private void Awake()
		{
			Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
		}

		[HarmonyPostfix]
		[HarmonyPatch(typeof(PauseMenuManager), nameof(PauseMenuManager.Start))]
		private static void PauseMenuManager_Start(PauseMenuManager __instance)
		{
			__instance._skipToNextLoopButton.SetActive(true);
		}
	}
}