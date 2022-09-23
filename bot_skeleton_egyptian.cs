datablock fxDTSBrickData (BrickEgyptianSkeletonBot_HoleSpawnData : BrickSkeletonBot_HoleSpawnData)
{
	uiName = "Egyptian Skeleton Hole";
	iconName = "Add-Ons/Bot_NewSkeleton/models/icon/icon_Skeleton_egyptian";

	holeBot = "EgyptianSkeletonHoleBot";
};

datablock PlayerData(EgyptianSkeletonHoleBot : SkeletonHoleBot)
{
	hName =  "Egyptian" SPC "Skeleton";
};

function EgyptianSkeletonHoleBot::onAdd(%this,%obj)
{
	armor::onAdd(%this,%obj);

	%obj.unhidenode(SkeleEvil);//Initial customized stuff
	%obj.hIsSkeleton =1;
	%obj.FakeDeath = 1;
	%obj.SkeleArmor = 1;
	%obj.mountImage(swordGOLImage,0);
	%obj.lastdamage = getsimtime();
	%obj.setHealth(250);

	%color = "1 1 1 1";
	%colorarmor = "0.9 0.8 0.2 1";

	%obj.hidenode(overcoat);//Hide all the custom nodes
	%obj.hidenode(Shades);
	%obj.hidenode(SkeleSmiles);
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
	%obj.hat =  "3";
	%obj.secondPack =  "6";
	%obj.accent =  "0";

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

function EgyptianSkeletonHoleBot::onBotLoop( %this, %obj, %targ )
{
	SkeletonHoleBot::onBotLoop(%this,%obj,%targ);
}

function EgyptianSkeletonHoleBot::onBotFollow( %this, %obj, %targ )
{
	SkeletonHoleBot::onBotFollow(%this,%obj,%targ);
}

function EgyptianSkeletonHoleBot::onDisabled(%this,%obj)
{
	SkeletonHoleBot::onDisabled(%this,%obj);
}

function EgyptianSkeletonHoleBot::onDamage( %this, %obj, %am, %source)
{
    SkeletonHoleBot::onDamage(%this,%obj,%am,%source);
}

function EgyptianSkeletonHoleBot::onCollision(%this, %obj, %col, %fade, %pos, %norm)
{
	SkeletonHoleBot::onCollision(%this, %obj, %col, %fade, %pos, %norm);
}