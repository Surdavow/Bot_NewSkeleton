datablock fxDTSBrickData (BrickSkeletonBot_HoleSpawnData)
{
	brickFile = "Add-ons/Bot_Hole/4xSpawn.blb";
	category = "Special";
	subCategory = "Holes - Skeleton";
	uiName = "Skeleton Hole";
	iconName = "Add-Ons/Bot_NewSkeleton/models/icon/icon_Skeleton";

	bricktype = 2;
	cancover = 0;
	orientationfix = 1;
	indestructable = 1;

	isBotHole = 1;
	holeBot = "SkeletonHoleBot";
};

datablock TSShapeConstructor(mSkeletonMDts)
{
	baseShape = "./models/skeleton/m.dts";
	sequence0 = "./models/skeleton/m_root.dsq root";
	sequence1 = "./models/skeleton/m_run.dsq run";
	sequence2 = "./models/skeleton/m_run.dsq walk";
	sequence3 = "./models/skeleton/m_back.dsq back";
	sequence4 = "./models/skeleton/m_side.dsq side";
	sequence5 = "./models/skeleton/m_crouch.dsq crouch";
	sequence6 = "./models/skeleton/m_crouchRun.dsq crouchRun";
	sequence7 = "./models/skeleton/m_crouchBack.dsq crouchBack";
	sequence8 = "./models/skeleton/m_crouchSide.dsq crouchSide";
	sequence9 = "./models/skeleton/m_look.dsq look";
	sequence10 = "./models/skeleton/m_headSide.dsq headside";
	sequence11 = "./models/skeleton/m_headup.dsq headUp";
	sequence12 = "./models/skeleton/m_standjump.dsq jump";
	sequence13 = "./models/skeleton/m_standjump.dsq standjump";
	sequence14 = "./models/skeleton/m_fall.dsq fall";
	sequence15 = "./models/skeleton/m_root.dsq land";
	sequence16 = "./models/skeleton/m_armAttack.dsq armAttack";
	sequence17 = "./models/skeleton/m_armReadyLeft.dsq armReadyLeft";
	sequence18 = "./models/skeleton/m_armReadyRight.dsq armReadyRight";
	sequence19 = "./models/skeleton/m_armReadyBoth.dsq armReadyBoth";
	sequence20 = "./models/skeleton/m_spearReady.dsq spearready";
	sequence21 = "./models/skeleton/m_spearThrow.dsq spearThrow";
	sequence22 = "./models/skeleton/m_talk.dsq talk";
	sequence23 = "./models/skeleton/m_death1.dsq death1";
	sequence24 = "./models/skeleton/m_shiftUp.dsq shiftUp";
	sequence25 = "./models/skeleton/m_shiftDown.dsq shiftDown";
	sequence26 = "./models/skeleton/m_shiftAway.dsq shiftAway";
	sequence27 = "./models/skeleton/m_shiftTo.dsq shiftTo";
	sequence28 = "./models/skeleton/m_shiftLeft.dsq shiftLeft";
	sequence29 = "./models/skeleton/m_shiftRight.dsq shiftRight";
	sequence30 = "./models/skeleton/m_rotCW.dsq rotCW";
	sequence31 = "./models/skeleton/m_rotCCW.dsq rotCCW";
	sequence32 = "./models/skeleton/m_undo.dsq undo";
	sequence33 = "./models/skeleton/m_plant.dsq plant";
	sequence34 = "./models/skeleton/m_sit.dsq sit";
	sequence35 = "./models/skeleton/m_wrench.dsq wrench";
	sequence36 = "./models/skeleton/m_activate.dsq activate";
	sequence37 = "./models/skeleton/m_activate2.dsq activate2";
	sequence38 = "./models/skeleton/m_leftrecoil.dsq leftrecoil";
	sequence39 = "./models/skeleton/m_mouthTrumpet.dsq mouthTrumpet";
	sequence40 = "./models/skeleton/m_armReadyRight90.dsq armReadyRight90";
};


datablock PlayerData(SkeletonHoleBot : PlayerStandardArmor)
{
	shapeFile = "./models/skeleton/m.dts";
	minJetEnergy = 0;
	jetEnergyDrain = 0;
	canJet = 0;
	maxItems   = 0;
	maxWeapons = 0;
	maxTools = 0;
	runforce = 100 * 90;
	maxForwardSpeed = 8;
	maxBackwardSpeed = 4;
	maxSideSpeed = 8;
	attackpower = 10;
	rideable = false;
	canRide = true;

	maxdamage = 1000;//Bot Health

	useCustomPainEffects = true;
	PainSound		= "";
	DeathSound		= "SkeleDeathSound";
	jumpSound = "";//Removed due to bots jumping a lot
	uiName = "";

	//Hole Attributes
	isHoleBot = 1;

	//Spawning option
	hSpawnTooClose = 0;//Doesn't spawn when player is too close and can see it
	  hSpawnTCRange = 8;//above range, set in brick units
	hSpawnClose = 0;//Only spawn when close to a player, can be used with above function as long as hSCRange is higher than hSpawnTCRange
	  hSpawnCRange = 32;//above range, set in brick units

	hType = skeleton; //Enemy,Friendly, Neutral
	  hNeutralAttackChance = 60; //0 to 100, Chance that this type will attack neutral bots, ie horses/vehicles/civilians
	//can have unique types, nazis will attack zombies but nazis will not attack other bots labeled nazi
	hName = "Skeleton";//cannot contain spaces
	hTickRate = 3000;
	
	//Wander Options
	hWander = 1;//Enables random walking
	  hSmoothWander = 1;//This is in addition to regular wander, makes them walk a bit longer, and a bit smoother
	  hReturnToSpawn = 1;//Returns to spawn when too far
	  hSpawnDist = 48;//Defines the distance bot can travel away from spawnbrick
	  hGridWander = 0;//Locks the bot to a grid, overwrites other settings
	
	//Searching options
	hSearch = 1;//Search for Players
	  hSearchRadius = 64;//in brick units
	  hSight = 1;//Require bot to see player before pursuing
	  hStrafe = 1;//Randomly strafe while following player
	hSearchFOV = 0;//if enabled disables normal hSearch
	  hFOVRange = 0.7; // determines the angle we can see the player at, 0.7 is about normal fov for players, if 0 we can see all in front, if 1 we could only see someone perfectly ahead, can be negative
	  // hFOVRadius = 6; // no longer used, we now use searchRadius
	  hHearing = 1;//If it hears a player it'll look in the direction of the sound

	  hAlertOtherBots = 1;//Alerts other bots when he sees a player, or gets attacked

	//Attack Options
	hMelee = 1;//Melee
	  hAttackDamage = 5;//Melee Damage
	hShoot = 1;
	  hWep = "";
	  hShootTimes = 16;//Number of times the bot will shoot between each tick
	  hMaxShootRange = 256;//The range in which the bot will shoot the player
	  hAvoidCloseRange = 1;//
		hTooCloseRange = 7;//in brick units

	//Misc options
	hActivateDirection = 0; // 0 1 2, determines the direction you have to face the bot to activate him, both, front back
	hMoveSlowdown = 0; // bool, determines wether the bot will slow down when following enemies
	hAvoidObstacles = 1;
	hSuperStacker = 0;//When enabled makes the bots stack a bit better, in other words, jumping on each others heads to get to a player
	hSpazJump = 0;//Makes bot jump when the user their following is higher than them

	hAFKOmeter = 1;//Determines how often the bot will wander or do other idle actions, higher it is the less often he does things

	hIdle = 1;// Enables use of idle actions, actions which are done when the bot is not doing anything else
	  hIdleAnimation = 1;//Plays random animations/emotes, sit, click, love/hate/etc
	  hIdleLookAtOthers = 1;//Randomly looks at other players/bots when not doing anything else
	    hIdleSpam = 0;//Makes them spam click and spam hammer/spraycan
	  hSpasticLook = 1;//Makes them look around their environment a bit more.
	hEmote = 0;
};

function SkeletonHoleBot::onAdd(%this,%obj)
{
	armor::onAdd(%this,%obj);

	%color = "1 1 1 1";

	%obj.hidenode(overcoat);
	%obj.hidenode(Shades);
	%obj.unhidenode(SkeleSmiles);
	%obj.hidenode(SkeleEvil);
	%obj.hidenode(JacketSans);
	%obj.hidenode(shirt);
	%obj.hidenode(pants2);
	%obj.hidenode(skeleeyel);
	%obj.hidenode(skeleeyelbig);
	%obj.hidenode(skeleeyer);

	%obj.lastdamage = getsimtime();
	%obj.setHealth(100);

	%obj.FakeDeath = 1;
	%obj.hIsSkeleton =1;

	%obj.packColor =  %color;
	%obj.hatColor =  %color;
	%obj.secondPackColor =  %color;
	%obj.llegColor =  %color;
	%obj.rlegColor =  %color;
	%obj.rarmColor =  %color;
	%obj.hipColor =  %color;
	%obj.larmColor =  %color;
	%obj.chestColor =  %color;
	%obj.accentColor =  %color;
	%obj.rhandColor =  %color;
	%obj.headColor =  %color;
	%obj.lhandColor =  %color;


	%obj.lhand =  "0";
	%obj.hip =  "0";
	%obj.chest =  "0";
	%obj.rarm =  "1";
	%obj.larm =  "1";
	%obj.rleg =  "0";
	%obj.rhand =  "0";
	%obj.lleg =  "0";
	%obj.pack =  "0";
	%obj.hat =  "0";
	%obj.secondPack =  "0";
	%obj.accent =  "1";

	GameConnection::ApplyBodyParts(%obj);
	GameConnection::ApplyBodyColors(%obj);
}

function SkeletonHoleBot::onBotLoop( %this, %obj, %targ )
{
		if(!%obj.hFollowing && %obj.SkeleWither)
	{
		%obj.setMaxForwardSpeed(8);
	}

	if(!%obj.hFollowing && %obj.getMountedImage(0) && %obj.raisearm)
	{
		%obj.playThread(1,"root");
		%obj.raisearm = 0;
	}

	%random = getRandom(1,100);

	if(!%obj.StartTalking && %random <= 50 && %obj.Sansify || %obj.Papify)
	{
	%obj.StartTalking = 1;
	cancel(%obj.SkeleTalk);
	%obj.MaxTalk = getRandom (2,15);
	%obj.SkeleTalk = schedule(600,0,SkeleTalk,%obj,%count);
	}

	if($BotSkeleton::SkeletonEasterEggs && %obj.getDatablock().getName() $= "SkeletonHoleBot" || %obj.getDatablock().getName() $= "RandomSkeletonHoleBot")
	{
		if(%random <= 25 && %obj.Name $= "Sans" && !%obj.Sansify)
		{
			%obj.FakeDeath = 0;
			%obj.setscale("1.1 1 1");
			%obj.setShapeName("Sans", 8564862);
			%obj.setShapeNameDistance(100);

			%obj.Sansify = 1;
			%obj.mountImage(rapidfireImage,0);
			%obj.setHealth(1000);

			%obj.hidenode(overcoat);
			%obj.hidenode(Shades);
			%obj.hidenode(SkeleEvil);
			%obj.unhidenode(SkeleSmiles);
			%obj.unhidenode(pants2);
		
			%obj.hidenode(skeleeyel);
			%obj.unhidenode(skeleeyelbig);
			%obj.unhidenode(skeleeyer);

			%obj.unhidenode(JacketSans);
			%obj.unhidenode(shirt);
			%obj.setNodeColor("JacketSans", "0.15 0.35 0.55 1");
			%obj.setNodeColor("pants2", "0.15 0.15 0.15 1");
			%obj.setNodeColor("shirt", "0.8 0.8 0.8 1");

			%obj.hat =  "0";
			%obj.pack =  "0";
			%obj.secondPack =  "0";

			%obj.larmColor =  "0.15 0.35 0.55 1";
			%obj.rarmColor =  "0.15 0.35 0.55 1";
			%obj.llegColor =  "0.99 0.75 0.792 1";
			%obj.rlegColor =  "0.99 0.75 0.792 1";

			GameConnection::ApplyBodyParts(%obj);
			GameConnection::ApplyBodyColors(%obj);

			%obj.SkeleShaded = 0;
			%obj.SkeleArmor = 0;

			%obj.playaudio(3,"SansSpawn");
		}

		if(%random <= 25 && %obj.Name $= "Papyrus" && !%obj.Papify)
		{
			%obj.FakeDeath = 0;
			%obj.setscale("1 0.925 1.1");
			%obj.setShapeName("Papyrus", 8564862);
			%obj.setShapeNameDistance(100);

			%colorred = "0.9 0.125 0.125 1";

			%obj.Papify = 1;
			%obj.mountImage(swordGOLImage,0);
			%obj.setHealth(500);

			%obj.unhidenode(SkeleEvil);
			%obj.unhidenode(pants2);

			%obj.hidenode(overcoat);
			%obj.hidenode(Shades);		
			%obj.hidenode(SkeleSmiles);
			%obj.hidenode(skeleeyel);
			%obj.hidenode(skeleeyelbig);
			%obj.hidenode(skeleeyer);
			%obj.hidenode(JacketSans);
			%obj.hidenode(shirt);
			%obj.setNodeColor("JacketSans", "0.15 0.35 0.55 1");
			%obj.setNodeColor("pants2", "0.15 0.55 0.75 1");
			%obj.setNodeColor("shirt", "0.8 0.8 0.8 1");

			%obj.hat =  "0";
			%obj.pack =  "3";
			%obj.secondPack =  "6";

			%obj.secondPackColor =  %colorred;
			%obj.packColor =  %colorred;
			%obj.llegColor =  %colorred;
			%obj.rlegColor =  %colorred;

			%obj.SkeleShaded = 0;
			%obj.SkeleArmor = 0;

			GameConnection::ApplyBodyParts(%obj);
			GameConnection::ApplyBodyColors(%obj);

			%obj.playaudio(3,"PapySpawn");
		}
	}
}

function SkeletonHoleBot::onBotFollow( %this, %obj, %targ )
{
	if(%obj.SkeleWither)
	{
		%obj.setMaxForwardSpeed(9);
	}

	if(%targ.hType !$= %obj.hType && %obj.lastsaw+getRandom(1000,4000) < getsimtime())//Play an animation and do the annoying sounds
	{		
		%obj.lastsaw = getsimtime();
		%obj.playthread(2,plant);
		//%obj.setAimObject(%targ);

		%obj.playaudio(0,"SkeleIdle" @ getrandom(1,4) @ "Sound");
		if(%obj.getMountedImage(0) && !%obj.raisearm)
		{
		if(%obj.SkeleShaded)
		{
		%obj.playThread(1,"armReadyRight90");
		}
		else %obj.playThread(1,"armReadyRight");
		%obj.raisearm = 1;
		}

		if(%obj.Sansify == 1)
		{
			%power = 10;
	
			%tPos = %obj.getPosition();//our position
			%oPos = getWords(%targ.getPosition(), 0, 2); //object's position
			%dis = VectorSub(%oPos, %tPos); //displacement is distance and direction of object from us, it's pos - our pos
			%normVec = vectorscale(VectorNormalize(%dis),400); //get rid of the distance (setting it to 1) so we only have direction left
			%flipVec = -getWord(%normVec, 0) SPC -getWord(%normVec, 1) SPC -getWord(%normVec, 2); //flip the vector so it's facing from the object to us, we're pushing not pulling it
			%vec = VectorScale(%flipVec, %power); //the vector is facing the right way so all that is left is to make it bigger so it can actually push
			
			if(%random <= 50 && %random > 25)
			{
				%targ.applyImpulse(%obj.getPosition(), getwords(%vec,0,1) SPC 5);
				%targ.playaudio(3,"forcePull");
				%obj.playthread(3,armreadyleft);
				%obj.schedule(500,playthread,3,root);

				%targ.mountImage(PixelGrabStatusPlayerImage, 3);
				%targ.schedule(750,unMountImage,3);
			}

			if(%random2 <= 25)
			{
				%targ.applyImpulse(%obj.getPosition(), getwords(%vec,0,1) SPC 50);
				%targ.playaudio(3,"forcePull");
				%obj.playthread(3,armreadyleft);
				%obj.schedule(500,playthread,3,root);

				%targ.mountImage(PixelGrabStatusPlayerImage, 3);
				%targ.schedule(1000,unMountImage,3);
			}
		}

	}
}

function SkeletonHoleBot::onDisabled(%this,%obj)
{
	if(%obj.SkeleWither)
	{
		%obj.spawnExplosion(WitherFinalExplosionProjectile,"1 1 1");
	}

	if(!isEventPending(%obj.SkeleAssembleSchedule) && !%obj.SkeleWither)
	{
		SkeleDisassemble(%obj);
	}
	%obj.unMountImage(0);
	%obj.unMountImage(1);

	Parent::OnDisabled(%this,%obj);
}

function SkeletonHoleBot::onDamage( %this, %obj, %am, %source)
{

    if(isObject(%obj) && %obj.getstate() !$= "Dead" && %obj.lastdamage+1000 < getsimtime())//1 second cooldown
	{
		%obj.lastdamage = getsimtime();
		%obj.playaudio(0,"SkeleHurt" @ getrandom(1,3) @ "Sound");
	}

	if(getRandom(1,100) <= $BotSkeleton::FakeDeathChance && %obj.getstate() !$= "Dead" && %obj.getDamageLevel() > %obj.getDatablock().maxDamage-50 
		&& %obj.FakeDeath && !%obj.SkeleWither)
	{
		SkeleDisassemble(%obj);
	}

	Parent::OnDamage(%this, %obj, %am, %source);
}

function SkeletonHoleBot::onCollision(%this, %obj, %col, %fade, %pos, %norm)
{
	if(%obj.hLoopActive)
	{
	if(isObject(%col) && %col.getType() & $TypeMasks::PlayerObjectType)
	{	
		if(%col.getstate() !$= "Dead" && %obj.getstate() !$= "Dead" && checkHoleBotTeams(%obj,%col) && %obj.hIgnore !$= %col)
		{
			if(!%obj.isBurning && isObject(getMiniGameFromObject(%obj,%col)) && miniGameCanDamage(%obj,%col))
			{
				if($BotSkeleton::HoldVictims && !%col.isBeingStrangled && %obj.lastpull+250 < getsimtime())
				{
					%col.setvelocity("0 0 -.1");
					%obj.lastpull = getsimtime();
					%obj.playthread(3,"shiftdown");
				}

				if(%obj.lastdamaged+1000 < getsimtime())
				{
					%obj.lastdamaged = getsimtime();
					%obj.playaudio(2,ZombieAttackSound);
					%obj.playaudio(3,"SkeleAttackSound");
					%obj.playthread(2,activate2);
					%col.damage(%obj.hFakeProjectile, %col.getposition(), 0.25, $DamageType::HoleMelee);
				}
			}
		}
	}
	}
	Parent::oncollision(%this, %obj, %col, %fade, %pos, %norm);
}