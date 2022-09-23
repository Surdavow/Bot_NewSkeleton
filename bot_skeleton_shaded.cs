datablock fxDTSBrickData (BrickShadedSkeletonBot_HoleSpawnData : BrickSkeletonBot_HoleSpawnData)
{
	uiName = "Shaded Skeleton Hole";
	iconName = "Add-Ons/Bot_NewSkeleton/models/icon/icon_Skeleton_Shaded";

	holeBot = "ShadedSkeletonHoleBot";
};

datablock PlayerData(ShadedSkeletonHoleBot : SkeletonHoleBot)
{
	hName =  "Shaded" SPC "Skeleton";
};

function ShadedSkeletonHoleBot::onAdd(%this,%obj)
{
	armor::onAdd(%this,%obj);

	%obj.unhidenode(SkeleEvil);//Initial customized stuff
	%obj.unhidenode(overcoat);
	%obj.unhidenode(Shades);
	%obj.FakeDeath = 1;
	%obj.hIsSkeleton =1;
	%obj.SkeleShaded = 1;
	%obj.mountImage(gunImage,0);
	%obj.lastdamage = getsimtime();
	%obj.setHealth(100);
	%color = "1 1 1 1";
	%colorShaded = "0.5 0.5 0.5 1";

	%obj.hidenode(SkeleSmiles);//Hide all the custom nodes
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
	%obj.pack =  "0";
	%obj.hat =  "7";
	%obj.secondPack =  "0";
	%obj.accent =  "0";

	%obj.setNodeColor("Shades", "0.15 0.15 0.15 0.95");
	%obj.setNodeColor("Overcoat", "0.35 0.35 0.35 1");

	%obj.hatColor =  %colorShaded;

	%obj.packColor =  %color;
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

	GameConnection::ApplyBodyParts(%obj);
	GameConnection::ApplyBodyColors(%obj);
}

function ShadedSkeletonHoleBot::onBotLoop( %this, %obj, %targ )
{
	SkeletonHoleBot::onBotLoop(%this,%obj,%targ);
}

function ShadedSkeletonHoleBot::onBotFollow( %this, %obj, %targ )
{
	SkeletonHoleBot::onBotFollow(%this,%obj,%targ);
}

function ShadedSkeletonHoleBot::onDisabled(%this,%obj)
{
	SkeletonHoleBot::onDisabled(%this,%obj);
}

function ShadedSkeletonHoleBot::onDamage( %this, %obj, %am, %source)
{
    SkeletonHoleBot::onDamage(%this,%obj,%am,%source);
}

function ShadedSkeletonHoleBot::onCollision(%this, %obj, %col, %fade, %pos, %norm)
{
	SkeletonHoleBot::onCollision(%this, %obj, %col, %fade, %pos, %norm);
}