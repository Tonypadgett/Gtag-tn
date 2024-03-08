using System;
using easyInputs;
using GorillaLocomotion;
using Maximility.Menu.Mods.Movement;
using MelonLoader;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

namespace Maximility
{
	public class ModManager : MelonMod
	{
		public void Mods()
		{
			//Movement Mod Toggles
			if ( Plugin.ExcelFly ) { FlyMods.ExcelFly(); }
            if ( Plugin.TFly ) { FlyMods.TFly(); }
	                //Movement Mod Toggles
			if ( Plugin.ExcelFly ) { FlyMods.ExcelFly(); }
            if ( Plugin.TFly ) { FlyMods.TFly(); }
	               //Movement Mod Toggles
			if ( Plugin.rainbowmonke ) { rainbowmonkeMods.rainbowmonke(); }
            if ( Plugin.rainbowmonke ) { rainbowmonkeMods.(); }
	    	      //Movement Mod Toggles
			if ( Plugin.not tag ) { not tagMods.not tag(); }
            if ( Plugin.not tag ) { not tagMods.not tag(); }
	        
        }
	}
}
