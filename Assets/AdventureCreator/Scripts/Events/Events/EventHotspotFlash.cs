﻿namespace AC
{

	public class EventHotspotFlash : EventBase
	{

		public override string[] EditorNames { get { return new string[] { "Hotspot/Flash all" }; } }
		protected override string EventName { get { return "OnHotspotsFlash"; } }
		protected override string ConditionHelp { get { return "Whenever the scene's Hotspots are flashed with the FlashHotspots input."; } }


		public override void Register ()
		{
			EventManager.OnHotspotsFlash += OnHotspotsFlash;
		}


		public override void Unregister ()
		{
			EventManager.OnHotspotsFlash -= OnHotspotsFlash;
		}


		private void OnHotspotsFlash ()
		{
			Run ();
		}


#if UNITY_EDITOR

		protected override bool HasConditions (bool isAssetFile) { return false; }

#endif

	}

}