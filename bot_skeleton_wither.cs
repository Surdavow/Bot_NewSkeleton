datablock fxDTSBrickData (BrickWitherSkeletonBot_HoleSpawnData : BrickSkeletonBot_HoleSpawnData)
{
	uiName = "Wither Skeleton Hole";
	iconName = "Add-Ons/Bot_NewSkeleton/models/icon/icon_Skeleton_Wither";

	holeBot = "WitherSkeletonHoleBot";
};

datablock PlayerData(WitherSkeletonHoleBot : SkeletonHoleBot)
{
	hName =  "Wither" SPC "Skeleton";
};

function WitherSkeletonHoleBot::onAdd(%this,%obj)
{
	armor::onAdd(%this,%obj);

	%obj.setscale("1 1 1.1");
	%obj.unhidenode(SkeleEvil);//Initial customized stuff
	%obj.FakeDeath = 1;
	%obj.hIsSkeleton =1;
	%obj.SkeleWither = 1;
	%obj.mountImage(swordImage,0);
	%obj.lastdamage = getsimtime();
	%obj.setHealth(500);

	%color = "0.1 0.1 0.1 1";

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
	%obj.pack =  "0";
	%obj.hat =  "0";
	%obj.secondPack =  "0";
	%obj.accent =  "0";

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

	GameConnection::ApplyBodyParts(%obj);
	GameConnection::ApplyBodyColors(%obj);
}

function WitherSkeletonHoleBot::onBotLoop( %this, %obj, %targ )
{
	SkeletonHoleBot::onBotLoop(%this,%obj,%targ);
}

function WitherSkeletonHoleBot::onBotFollow( %this, %obj, %targ )
{
	SkeletonHoleBot::onBotFollow(%this,%obj,%targ);
}

function WitherSkeletonHoleBot::onDisabled(%this,%obj)
{
	SkeletonHoleBot::onDisabled(%this,%obj);
}

function WitherSkeletonHoleBot::onDamage( %this, %obj, %am, %source)
{
    SkeletonHoleBot::onDamage(%this,%obj,%am,%source);
}

function WitherSkeletonHoleBot::onCollision(%this, %obj, %col, %fade, %pos, %norm)
{
	SkeletonHoleBot::onCollision(%this, %obj, %col, %fade, %pos, %norm);
}