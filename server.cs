//Base Blockhead guy
if(LoadRequiredAddOn("Bot_Hole") == $Error::None)
{
	exec("./functions.cs");
	exec("./skeletal_death.cs");
	exec("./sound.cs");
	exec("./item_trumpet.cs");
	exec("./weapon_spellfire.cs");
	exec("./bot_skeleton.cs");
	exec("./bot_skeleton_armor.cs");
	exec("./bot_skeleton_archer.cs");
	exec("./bot_skeleton_trumpet.cs");
	exec("./bot_skeleton_egyptian.cs");
	exec("./bot_skeleton_shaded.cs");
	exec("./bot_skeleton_wither.cs");

	exec("./bot_skeleton_random.cs");
}

if(%error == $Error::AddOn_NotFound)
{
   error("ERROR: Gold Sword for Bot_SkeletonRev - required add-on Weapon_Sword not found");
}
else
{
   exec("./weapon_goldsword.cs");
}

if(isFunction(registerPreferenceAddon))//Function for BLG preferences
{
	registerPreferenceAddon("Bot_SkeletonRev", "Skeleton Bots", "skull_old");

				new ScriptObject(Preference)
	{
		className      = "BotSkeletons";

		addon          = "Bot_SkeletonRev";
		category       = "Settings";
		title          = "Fake Death Chance (%)";

		type           = "num";
		params         = "0 100 0";

		variable       = "$BotSkeleton::FakeDeathChance";

		defaultValue   = "50";

		updateCallback = "";
		loadCallback   = "";

		hostOnly       = false;
		secret         = false;

		loadNow        = false;
		noSave         = false;
		requireRestart = false;
	};

		new ScriptObject(Preference)
	{
		className      = "BotSkeletons";

		addon          = "Bot_SkeletonRev";
		category       = "Settings";
		title          = "Hold Down Victims";

		type           = "bool";
		params         = "";

		variable       = "$BotSkeleton::HoldVictims";

		defaultValue   = "0";

		updateCallback = "";
		loadCallback   = "";

		hostOnly       = false;
		secret         = false;

		loadNow        = false;
		noSave         = false;
		requireRestart = false;
	};

				new ScriptObject(Preference)
	{
		className      = "BotSkeletons";

		addon          = "Bot_SkeletonRev";
		category       = "Settings";
		title          = "Skeleton Easter Eggs";

		type           = "bool";
		params         = "";

		variable       = "$BotSkeleton::SkeletonEasterEggs";

		defaultValue   = "1";

		updateCallback = "";
		loadCallback   = "";

		hostOnly       = false;
		secret         = false;

		loadNow        = false;
		noSave         = false;
		requireRestart = false;
	};
}

else	//If BLG isn't installed
{
	$BotSkeleton::FakeDeathChance = 50;
	$BotSkeleton::HoldVictims = 0;
	$BotSkeleton::SkeletonEasterEggs = 1;
}

// Projectile - you can't spawn explosions on the server, so we use a short-lived projectile
/////////////////////////////////
datablock ProjectileData(WitherFinalExplosionProjectile : vehicleFinalExplosionProjectile)
{
   directDamage        = 0;
   radiusDamage        = 0;
   damageRadius        = 0;
   explosion           = vehicleFinalExplosion;

   directDamageType  = $DamageType::VehicleExplosion;
   radiusDamageType  = $DamageType::VehicleExplosion;

   explodeOnDeath		= 1;

   armingDelay         = 0;
   lifetime            = 0;

   uiName = "";
};
