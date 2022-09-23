datablock fxDTSBrickData (BrickRandomSkeletonBot_HoleSpawnData : BrickSkeletonBot_HoleSpawnData)
{
	uiName = "Random Skeleton Hole";
	iconName = "Add-Ons/Bot_NewSkeleton/models/icon/icon_Skeleton_random";

	holeBot = "RandomSkeletonHoleBot";
};

datablock PlayerData(RandomSkeletonHoleBot : SkeletonHoleBot)
{
	hName = "Skeleton";
};

function RandomSkeletonHoleBot::onAdd(%this,%obj)
{
	armor::onAdd(%this,%obj);

	%color = "1 1 1 1";
	%colorarmor = "0.5 0.5 0.5 1";
	%colorarcher = "0.5 0.25 0.05 1";
	%coloregypt = "0.9 0.8 0.2 1";

	%colorblack = "0.1 0.1 0.1 1";

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

	%obj.setNodeColor("Shades", "0.15 0.15 0.15 0.95");
	%obj.setNodeColor("Overcoat", "0.35 0.35 0.35 1");

	%random = getRandom(1,100);
	%obj.FakeDeath = 1;
	%obj.hIsSkeleton =1;

	if(%random <= 20)
	{
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

		%obj.mountImage(swordImage,0);
		%obj.pack =  "1";
		%obj.packColor =  %colorarmor;
		%obj.hat =  "2";
		%obj.hatColor =  %colorarmor;
		%obj.secondPack =  "6";
		%obj.secondPackColor =  %colorarmor;
		%obj.SkeleArmor = 1;
		%obj.llegColor =  %color;
		%obj.rlegColor =  %color;
		%obj.name = "Armored" SPC "Skeleton";

		%obj.lhand =  "0";
		%obj.hip =  "0";
		%obj.chest =  "0";
		%obj.rarm =  "1";
		%obj.larm =  "1";
		%obj.rleg =  "0";
		%obj.rhand =  "0";
		%obj.lleg =  "0";

	if(%random <= 15)
	{
		%obj.mountImage(TrumpetImage,0);
		%obj.secondPack =  "0";
		%obj.hat =  "0";
		%obj.pack =  "0";

		%obj.SkeleArmor = 0;
		%obj.name = "Trumpet" SPC "Skeleton";
	}

		if(%random <= 10)
	{
		%obj.mountImage(bowImage,0);
		%obj.pack =  "5";
		%obj.hat =  "4";
		%obj.hatColor =  %colorarcher;
		%obj.packColor =  %colorarcher;
		%obj.secondPack =  "6";
		%obj.secondPackColor =  %colorarcher;
		%obj.llegColor =  %colorarcher;
		%obj.rlegColor =  %colorarcher;
		%obj.name = "Archer" SPC "Skeleton";

		%obj.hidenode(SkeleSmiles);
		%obj.unhidenode(SkeleEvil);
	}

			if(%random <= 7)
	{
		%obj.hidenode(overcoat);
		%obj.hidenode(Shades);
		%obj.mountImage(swordGOLImage,0);
		%obj.pack =  "1";
		%obj.packColor =  %coloregypt;
		%obj.hat =  "3";
		%obj.hatColor =  %coloregypt;
		%obj.secondPack =  "6";
		%obj.secondPackColor =  %coloregypt;
		%obj.llegColor =  %color;
		%obj.rlegColor =  %color;
		%obj.accent =  "0";
		%obj.name = "Egyptian" SPC "Skeleton";

		%obj.SkeleArmor = 1;
	}

			if(%random <= 5)
	{
		%obj.unhidenode(Shades);
		%obj.mountImage(GunImage,0);
		%obj.pack =  "0";
		%obj.packColor =  %color;
		%obj.hat =  "7";
		%obj.hatColor =  %colorarmor;
		%obj.secondPack =  "0";
		%obj.secondPackColor =  %color;
		%obj.llegColor =  %color;
		%obj.rlegColor =  %color;
		%obj.accent =  "0";
		%obj.name = "Shaded" SPC "Skeleton";

		%obj.unhidenode(overcoat);

		%obj.SkeleArmor = 0;
		%obj.SkeleShaded = 1;
	}

			if(%random <= 3)
	{
		%obj.setscale("1 1 1.1");
		%obj.mountImage(swordImage,0);

		%obj.pack =  "0";
		%obj.hat =  "0";
		%obj.secondPack =  "0";
		%obj.accent =  "0";
		%obj.name = "Wither" SPC "Skeleton";

		%obj.packColor =  %colorblack;
		%obj.hatColor =  %colorblack;
		%obj.secondPackColor =  %colorblack;
		%obj.llegColor =  %colorblack;
		%obj.rlegColor =  %colorblack;
		%obj.rarmColor =  %colorblack;
		%obj.hipColor =  %colorblack;
		%obj.larmColor =  %colorblack;
		%obj.chestColor =  %colorblack;
		%obj.accentColor =  %colorblack;
		%obj.rhandColor =  %colorblack;
		%obj.headColor =  %colorblack;
		%obj.lhandColor =  %colorblack;

		%obj.hidenode(Shades);
		%obj.unhidenode(SkeleSmiles);
		%obj.hidenode(SkeleEvil);
		%obj.hidenode(overcoat);

		%obj.SkeleWither = 1;
		%obj.SkeleArmor = 0;
		%obj.SkeleShaded = 0;
	}
	}
	else
	{
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
	}

	GameConnection::ApplyBodyParts(%obj);
	GameConnection::ApplyBodyColors(%obj);

	if(%obj.SkeleArmor)
	{
		%obj.lastdamage = getsimtime();
		%obj.setHealth(250);
	}
	else if(%obj.SkeleWither)
	{
		%obj.lastdamage = getsimtime();
		%obj.setHealth(500);
	}
	else
	{
		%obj.lastdamage = getsimtime();
		%obj.setHealth(100);
	}

}

function RandomSkeletonHoleBot::onBotLoop( %this, %obj, %targ )
{
	SkeletonHoleBot::onBotLoop(%this,%obj,%targ);
}

function RandomSkeletonHoleBot::onBotFollow( %this, %obj, %targ )
{
	SkeletonHoleBot::onBotFollow(%this,%obj,%targ);
}

function RandomSkeletonHoleBot::onDisabled(%this,%obj)
{
	SkeletonHoleBot::onDisabled(%this,%obj);
}

function RandomSkeletonHoleBot::onDamage( %this, %obj, %am, %source)
{
    SkeletonHoleBot::onDamage(%this,%obj,%am,%source);
}

function RandomSkeletonHoleBot::onCollision(%this, %obj, %col, %fade, %pos, %norm)
{
	SkeletonHoleBot::onCollision(%this, %obj, %col, %fade, %pos, %norm);
}