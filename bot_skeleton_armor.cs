datablock fxDTSBrickData (BrickArmoredSkeletonBot_HoleSpawnData : BrickSkeletonBot_HoleSpawnData)
{
	uiName = "Armored Skeleton Hole";
	iconName = "Add-Ons/Bot_NewSkeleton/models/icon/icon_Skeleton_Armored";

	holeBot = "ArmoredSkeletonHoleBot";
};

datablock PlayerData(ArmoredSkeletonHoleBot : SkeletonHoleBot)
{
	hName =  "Armored" SPC "Skeleton";
};

function ArmoredSkeletonHoleBot::onAdd(%this,%obj)
{
	armor::onAdd(%this,%obj);

	%obj.unhidenode(SkeleSmiles);//Initial customized stuff
	%obj.hIsSkeleton =1;
	%obj.FakeDeath = 1;
	%obj.SkeleArmor = 1;
	%obj.mountImage(swordImage,0);
	%obj.lastdamage = getsimtime();
	%obj.setHealth(250);

	%color = "1 1 1 1";
	%colorarmor = "0.5 0.5 0.5 1";

	%obj.hidenode(overcoat);//Hide all the custom nodes
	%obj.hidenode(Shades);
	%obj.hidenode(SkeleEvil);
	%obj.hidenode(JacketSans);
	%obj.hidenode(shirt);
	%obj.hidenode(pants2);
	%obj.hidenode(skeleeyel);
	%obj.hidenode(skeleeyelbig);
	%obj.hidenode(skeleeyer);

	%obj.lhand =  "0";//Default
	%obj.hip =  "0";
	%obj.chest =  "0";
	%obj.rarm =  "1";
	%obj.larm =  "1";
	%obj.rleg =  "0";
	%obj.rhand =  "0";
	%obj.lleg =  "0";
	%obj.pack =  "1";
	%obj.hat =  "2";
	%obj.secondPack =  "6";
	%obj.accent =  "1";

	%obj.packColor =  %colorarmor;
	%obj.hatColor =  %colorarmor;
	%obj.secondPackColor =  %colorarmor;

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

	GameConnection::ApplyBodyParts(%obj);
	GameConnection::ApplyBodyColors(%obj);
}

function ArmoredSkeletonHoleBot::onBotLoop( %this, %obj, %targ )
{
	SkeletonHoleBot::onBotLoop(%this,%obj,%targ);
}

function ArmoredSkeletonHoleBot::onBotFollow( %this, %obj, %targ )
{
	SkeletonHoleBot::onBotFollow(%this,%obj,%targ);
}

function ArmoredSkeletonHoleBot::onDisabled(%this,%obj)
{
	SkeletonHoleBot::onDisabled(%this,%obj);
}

function ArmoredSkeletonHoleBot::onDamage( %this, %obj, %am, %source)
{
    SkeletonHoleBot::onDamage(%this,%obj,%am,%source);
}

function ArmoredSkeletonHoleBot::onCollision(%this, %obj, %col, %fade, %pos, %norm)
{
	SkeletonHoleBot::onCollision(%this, %obj, %col, %fade, %pos, %norm);
}