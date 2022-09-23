datablock fxDTSBrickData (BrickTrumpetSkeletonBot_HoleSpawnData : BrickSkeletonBot_HoleSpawnData)
{
	uiName = "Trumpet Skeleton Hole";
	iconName = "Add-Ons/Bot_NewSkeleton/models/icon/icon_Skeleton_trumpet";
	holeBot = "TrumpetSkeletonHoleBot";
};

datablock PlayerData(TrumpetSkeletonHoleBot : SkeletonHoleBot)
{
	hName = "Trumpet" SPC "Skeleton";//cannot contain spaces
};

function TrumpetSkeletonHoleBot::onAdd(%this,%obj)
{
	SkeletonHoleBot::onAdd(%this,%obj);
	%obj.mountImage(TrumpetImage,0);
}

function TrumpetSkeletonHoleBot::onBotLoop( %this, %obj, %targ )
{
	SkeletonHoleBot::onBotLoop(%this,%obj,%targ);
}

function TrumpetSkeletonHoleBot::onBotFollow( %this, %obj, %targ )
{
	SkeletonHoleBot::onBotFollow(%this,%obj,%targ);
}

function TrumpetSkeletonHoleBot::onDisabled(%this,%obj)
{
	SkeletonHoleBot::onDisabled(%this,%obj);
}

function TrumpetSkeletonHoleBot::onDamage( %this, %obj, %am, %source)
{
	SkeletonHoleBot::onDamage(%this,%obj,%am,%source);
}

function TrumpetSkeletonHoleBot::onCollision(%this, %obj, %col, %fade, %pos, %norm)
{
	SkeletonHoleBot::onCollision(%this, %obj, %col, %fade, %pos, %norm);
}