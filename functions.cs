function SkeleDisassemble(%obj)
{	
	%obj.unMountImage(0);
	%obj.unMountImage(1);
	%obj.playThread(0,death1);
	%obj.playaudio(2,"brickbreaksound");

	if($BotSkeleton::FakeDeathChance > 0)
	{
		%obj.SkeleAssembleSchedule = schedule(6000,0,SkeleAssemble,%obj,%count);
		%obj.stopHoleLoop();
			

		%obj.Name = "Skeleton";

		%obj.SkeleArmor = 0;
		%obj.Papify = 0;
		%obj.Sansify = 0;
	}

		%proj = new Projectile()
      	{
        	scale = %obj.getScale();
        	dataBlock = SkeletalDeathExplosionProjectile;
        	initialVelocity = %obj.getVelocity();
        	initialPosition = %obj.getPosition();
        	sourceObject = %obj;
        	sourceSlot = 0;
        	client = %obj.client;
     	};
     	MissionCleanup.add(%proj);

	  	%obj.hideNode("ALL");
      	%obj.unhidenode(pants);
      	%obj.unhidenode(chest);
}

function SkeleAssemble(%obj,%count)
{
	if(isObject(%obj) && %obj.getState() !$= "Dead")
	{
		%time = getRandom(125,250);
		if(%count != 8)
		{
			if(%count == 1)
			{
			%obj.unhideNode("larm");
			}

			if(%count == 2)
			{
			%obj.unhideNode("rarm");
			}

			if(%count == 3)
			{
			%obj.unhideNode("rhand");
			}

			if(%count == 4)
			{
			%obj.unhideNode("lhand");
			}

			if(%count == 5)
			{
			%obj.unhideNode("lshoe");
			}

			if(%count == 6)
			{
			%obj.unhideNode("rshoe");
			}

			if(%count == 7)
			{
			%obj.unhideNode("headskin");
			%obj.unhideNode("skelesmiles");
			}

			%obj.setNodeColor("ALL", "1 1 1 1");
			%obj.stopaudio(3);
			%obj.playaudio(3,"Assemble" @ GetRandom(1,4));
			%obj.playthread(3,plant);

		schedule(%time,0,SkeleAssemble,%obj,%count+1);
		}
		else if(%count == 8)
		{
			%obj.lastdamage = getsimtime();
			%obj.StartHoleLoop();
			%obj.playthread(0,root);
			%obj.playthread(1,root);
			%obj.playthread(2,root);
			%obj.playthread(3,root);
			%obj.SetHealth(100);
			%obj.FakeDeath = 1;
			%obj.SkeleShaded = 0;
			%obj.SkeleArmor = 0;

			%obj.Name = %obj.getDatablock().hName;
		}
	}
}

function SkeleTalk(%obj,%count)
{
	%time = getRandom(10,200);
	if(isObject(%obj) && %count != %obj.MaxTalk)
	{
		%obj.stopaudio(0);

		if(%obj.Sansify)
		{
		%obj.playaudio(0,"SansTalk");
		}
		if(%obj.Papify)
		{
		%obj.playaudio(0,"PapyTalk");
		}

		//serverPlay3d(SansTalk,%obj.getposition());
		%obj.playthread(3,talk);

	schedule(%time,0,SkeleTalk,%obj,%count+1);
	}
	else if(isObject(%obj) && %count >= %obj.MaxTalk)
	{
		%obj.StartTalking = 0;
		%obj.playthread(3,root);
	}
}

package SkeletonInfection
{
	function holeZombieInfect(%obj, %col)
	{
		if(isObject(%col) && %col.hIsSkeleton)
		return;

		parent::holeZombieInfect(%obj, %col);
	}
};
if($AddOn__Bot_Zombie $= "1")
activatePackage(SkeletonInfection);