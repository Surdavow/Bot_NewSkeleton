datablock fxDTSBrickData (BrickArcherSkeletonBot_HoleSpawnData : BrickSkeletonBot_HoleSpawnData)
{
	uiName = "Archer Skeleton Hole";
	iconName = "Add-Ons/Bot_NewSkeleton/models/icon/icon_Skeleton_archer";

	holeBot = "ArcherSkeletonHoleBot";
};

datablock PlayerData(ArcherSkeletonHoleBot : SkeletonHoleBot)
{
	hName =  "Archer" SPC "Skeleton";
};

function ArcherSkeletonHoleBot::onAdd(%this,%obj)
{
	armor::onAdd(%this,%obj);

	%obj.unhidenode(SkeleEvil);//Initial customized stuff
	%obj.FakeDeath = 1;
	%obj.hIsSkeleton =1;
	%obj.mountImage(bowImage,0);
	%obj.lastdamage = getsimtime();
	%obj.setHealth(100);
	%color = "1 1 1 1";
	%colorarcher = "0.5 0.25 0.05 1";

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
	%obj.pack =  "5";
	%obj.hat =  "4";
	%obj.secondPack =  "6";
	%obj.accent =  "1";

	%obj.packColor =  %colorarcher;
	%obj.hatColor =  %colorarcher;
	%obj.secondPackColor =  %colorarcher;
	%obj.llegColor =  %colorarcher;
	%obj.rlegColor =  %colorarcher;

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

function ArcherSkeletonHoleBot::onBotLoop( %this, %obj, %targ )
{
	SkeletonHoleBot::onBotLoop(%this,%obj,%targ);
}

function ArcherSkeletonHoleBot::onBotFollow( %this, %obj, %targ )
{
	SkeletonHoleBot::onBotFollow(%this,%obj,%targ);
}

function ArcherSkeletonHoleBot::onDisabled(%this,%obj)
{
	SkeletonHoleBot::onDisabled(%this,%obj);
}

function ArcherSkeletonHoleBot::onDamage( %this, %obj, %am, %source)
{
    SkeletonHoleBot::onDamage(%this,%obj,%am,%source);
}

function ArcherSkeletonHoleBot::onCollision(%this, %obj, %col, %fade, %pos, %norm)
{
	SkeletonHoleBot::onCollision(%this, %obj, %col, %fade, %pos, %norm);
}