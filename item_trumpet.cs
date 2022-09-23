datablock ItemData(TrumpetItem) {
  category = "Weapon";
  className = "Weapon";

  shapeFile = "./models/trumpet/trumpet_item.dts";
  emap = true;

  uiName = "";
  iconName = "./models/icon/icon_trumpet";

  image = TrumpetImage;
  canDrop = true;

  doColorShift = true;
  colorShiftColor = "1 1 0 1";

  friction = 0.599218;
};

datablock ShapeBaseImageData(TrumpetImage) {
  className = "WeaponImage";
  shapeFile = "./models/trumpet/trumpet_image.dts";
  item = TrumpetItem;
  emap = true;

  mountPoint = 0;
  
  offset = "0 0.3 0.25";
  eyeOffset = false;

  // This is used by the instruments mod to determine what sounds to use
  // It's also used to check if an image is even an instrument to begin with

  doColorShift = true;
  colorShiftColor = TrumpetItem.colorShiftColor;

  stateName[0]                     = "Activate";
  stateTimeoutValue[0]             = 0.15;
  stateTransitionOnTriggerDown[0]  = "Ready";
  stateSound[0]          = weaponSwitchSound;

  stateName[1]                     = "Ready";
  stateScript[1]                  = "onReady";
  stateTransitionOnTimeout[1]     = "Play";
  stateTimeoutValue[1]             = 0.3;
  stateAllowImageChange[1]         = true;
  stateSequence[1]  = "Ready";

  stateName[2]                    = "Play";
  stateTransitionOnTimeout[2]     = "PostPlay";
  stateTimeoutValue[2]            = 0.8;
  stateFire[2]                    = true;
  stateAllowImageChange[2]        = false;
  stateScript[2]                  = "onPlay";
  stateWaitForTimeout[2]      = true;
  stateEmitterTime[2]        = 0.05;

  stateName[3] = "PostPlay";
  stateScript[3]                  = "onPost";
  stateTimeoutValue[3]            = 2;
  stateTransitionOnTimeout[3]     = "Reload";

  stateName[4]      = "Reload";
  stateSequence[4]                = "Reload";
  stateTransitionOnTimeout[4]     = "Activate";
  stateSequence[4]  = "Ready";
};

// ------------------------------------------------------------------------------

function TrumpetImage::onMount(%this, %obj, %slot) {
  Parent::onMount(%this, %obj, %slot);
}

// ------------------------------------------------------------------------------

function TrumpetImage::onReady(%this, %obj, %pos) 
{
  %obj.playThread(1, mouthTrumpet);
}

function TrumpetImage::onPlay(%this, %obj, %pos) 
{
  %obj.playaudio(1,"TrumpetDoot");
  %obj.playThread(2, plant);
}

function TrumpetImage::onPost(%this, %obj, %pos) 
{
  %obj.playThread(1, root);
}
