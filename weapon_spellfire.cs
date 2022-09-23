datablock ParticleData(RapidFireTrailParticle)
{
  dragCoefficient = 1.75;
  windCoefficient = 0;
  gravityCoefficient = 0;
  inheritedVelFactor = 0;
  constantAcceleration = 0;
  lifetimeMS = 1500;
  lifetimeVarianceMS = 500;
  textureName = "Add-Ons/Projectile_Pong/Square.png";
  spinSpeed = 0;
  spinRandomMin = -300;
  spinRandomMax = 300;
  useInvAlpha = false;

colors[0] = "0 25 51 0.3"; //light color
  colors[1] = "0 0 51 0.3"; //dark color
  colors[2] = "0 0 255 0.3"; //barley noticeable color
  sizes[0] = 0.2;
  sizes[1] = 0.4;
};
datablock ParticleEmitterData(RapidFireTrailEmitter)
{
  ejectionPeriodMS = 15;
  periodVarianceMS = 0;
  ejectionVelocity = 1.5;
  velocityVariance = 1;
  ejectionOffset = 0.0;
  thetaMin = 0;
  thetaMax = 180;
  phiReferenceVel = 0;
  phiVariance = 360;
  overrideAdvance = false;
  particles = RapidFireTrailParticle;
     useEmitterColors = true;

  uiName = "Blue Pixel";
};
datablock ParticleData(RapidFireParticle)
{
  dragCoefficient = 1.75;
  windCoefficient = 0;
  gravityCoefficient = 0;
  inheritedVelFactor = 0;
  constantAcceleration = 0;
  lifetimeMS = 1500;
  lifetimeVarianceMS = 500;
  textureName = "Add-Ons/Projectile_Pong/Square.png";
  spinSpeed = 0;
  spinRandomMin = -300;
  spinRandomMax = 300;
  useInvAlpha = false;

colors[0] = "0 25 51 0.3"; //light color
  colors[1] = "0 0 51 0.3"; //dark color
  colors[2] = "0 0 255 0.3"; //barley noticeable color
  sizes[0] = 0.1;
  sizes[1] = 0.1;
};
datablock ParticleEmitterData(RapidFireEmitter)
{
  ejectionPeriodMS = 15;
  periodVarianceMS = 0;
  ejectionVelocity = 3.2;
  velocityVariance = 2;
  ejectionOffset = 0.0;
  thetaMin = 0;
  thetaMax = 180;
  phiReferenceVel = 0;
  phiVariance = 360;
  overrideAdvance = false;
  particles = RapidFireParticle;

  uiName = "";
};

datablock ParticleData(RapidSmokeParticle)
{
  dragCoefficient = 1.75;
  windCoefficient = 0;
  gravityCoefficient = 0;
  inheritedVelFactor = 0;
  constantAcceleration = 0;
  lifetimeMS = 1500;
  lifetimeVarianceMS = 500;
  textureName = "base/data/particles/cloud.png";
  spinSpeed = 0;
  spinRandomMin = -300;
  spinRandomMax = 300;
  useInvAlpha = false;

colors[0] = "0 25 51 0.3"; //light color
  colors[1] = "0 0 51 0.3"; //dark color
  colors[2] = "0 0 255 0.3"; //barley noticeable color
  sizes[0] = 0.25;
  sizes[1] = 0.55;
};
datablock ParticleEmitterData(RapidSmokeEmitter)
{
  ejectionPeriodMS = 5;
  periodVarianceMS = 0;
  ejectionVelocity = 0.9;
  velocityVariance = 0.6;
  ejectionOffset = 0.0;
  thetaMin = 0;
  thetaMax = 180;
  phiReferenceVel = 0;
  phiVariance = 360;
  overrideAdvance = false;
  particles = RapidSmokeParticle;

  uiName = "";
};

datablock ParticleData(rapidfireExplosionParticle)
{
  dragCoefficient      = 5;
  gravityCoefficient   = 0.0;
  inheritedVelFactor   = 1.0;
  constantAcceleration = 0.0;
  lifetimeMS           = 500;
  lifetimeVarianceMS   = 300;
  textureName          = "Add-Ons/Projectile_Pong/Square.png";
  spinSpeed   = 0.0;
  spinRandomMin   = -0.0;
  spinRandomMax   = 0.0;
  colors[0] = "0 255 255 0.3"; //light color
  colors[1] = "0 25 51 0.3"; //dark color
  colors[2] = "0 0 255 0.3"; //barley noticeable color
  sizes[0]      = 0.5;
  sizes[1]      = 0.1;
};

datablock ParticleEmitterData(rapidExplosionEmitter)
{
   ejectionPeriodMS = 7;
   periodVarianceMS = 0;
   ejectionVelocity = 5;
   velocityVariance = 1;
   ejectionOffset   = 0.0;
   thetaMin         = 0;
   thetaMax         = 90;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   overrideAdvance = false;
   particles = "rapidfireExplosionParticle";

   useEmitterColors = true;

   uiName = "";
};
datablock ParticleData(rapidfiresmokeParticle)
{
  dragCoefficient      = 8;
  gravityCoefficient   = 1;
  inheritedVelFactor   = 0.2;
  constantAcceleration = 0.0;
  lifetimeMS           = 600;
  lifetimeVarianceMS   = 400;
  textureName          = "base/data/particles/cloud";
  spinSpeed   = 10.0;
  spinRandomMin   = -50.0;
  spinRandomMax   = 50.0;
colors[0] = "0 0 102 0.3"; //light color
  colors[1] = "0 25 51 0.3"; //dark color
  colors[2] = "0 0 255 0.3"; //barley noticeable color
  sizes[0]      = 0.25;
  sizes[1]      = 0.75;

  useInvAlpha = true;
};
datablock ParticleEmitterData(rapidfiresmokeEmitter)
{
   ejectionPeriodMS = 1;
   periodVarianceMS = 0;
   ejectionVelocity = 2;
   velocityVariance = 1;
   ejectionOffset   = 0.0;
   thetaMin         = 89;
   thetaMax         = 90;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   overrideAdvance = false;
   particles = "rapidfiresmokeParticle";

   useEmitterColors = true;
   uiName = "";
};
datablock ExplosionData(rapidfireExplosion)
{
   //explosionShape = "";
  soundProfile = pixelHitSound;

   lifeTimeMS = 150;

   particleEmitter = rapidExplosionEmitter;
   particleDensity = 10;
   particleRadius = 0.2;

   emitter[0] = rapidfiresmokeEmitter;
   

   faceViewer     = true;
   explosionScale = "1 1 1";

   shakeCamera = false;
   camShakeFreq = "10.0 11.0 10.0";
   camShakeAmp = "1.0 1.0 1.0";
   camShakeDuration = 0.5;
   camShakeRadius = 10.0;

   // Dynamic light
   lightStartRadius = 5;
   lightEndRadius = 5;
   lightStartColor = "0 0.8 1 1";
   lightEndColor = "0 0 0";

   damageRadius = 1;
   radiusDamage = 1;

   impulseRadius = 4; //4
   impulseForce = 500; //500
};

AddDamageType("RapidFire",   '<bitmap:Add-Ons/Bot_SkeletonRev/models/icon/ci_rapidfire> %1',    '%2 <bitmap:Add-Ons/Bot_SkeletonRev/models/icon/ci_rapidfire> %1',0.2,1);
datablock ProjectileData(rapidfireProjectile)
{
   projectileShapeName = "base/data/shapes/empty.dts";
   directDamage        = 12;
   directDamageType    = $DamageType::rapidfire;
   radiusDamageType    = $DamageType::rapidfire;
   

   brickExplosionRadius = 0;
   brickExplosionImpact = true;          //destroy a brick if we hit it directly?
   brickExplosionForce  = 10;
   brickExplosionMaxVolume = 1;          //max volume of bricks that we can destroy
   brickExplosionMaxVolumeFloating = 2;  //max volume of bricks that we can destroy if they aren't connected to the ground

   impactImpulse       = 0;
   verticalImpulse    = 0;
   explosion           = rapidfireExplosion;
   particleEmitter     = RapidFiretrailEmitter; 

   muzzleVelocity      = 200;
   velInheritFactor    = 1;

   armingDelay         = 00;
   lifetime            = 200;
   fadeDelay           = 3500;
   bounceElasticity    = 0.5;
   bounceFriction      = 0.20;
   isBallistic         = false;
   gravityMod = 0.0;
   explodeOnDeath = true;

  hasLight    = true;
   lightRadius = 5.0;
   lightColor  = "0 0 1 1";

   uiName = "";
};

//////////
// item //
//////////
datablock ItemData(rapidfireItem)
{
  category = "Weapon";  // Mission editor category
  className = "Weapon"; // For inventory system

   // Basic Item Properties
  shapeFile = "./models/pixelitem.dts";
  rotate = false;
  mass = 1;
  density = 0.2;
  elasticity = 0.2;
  friction = 0.6;
  emap = true;

  //gui stuff
  uiName = "Spread Pixel";
  iconName = "./rapidfire";
  doColorShift = true;
  colorShiftColor = "0 0 0.15 1";

   // Dynamic properties defined by the scripts
  image = rapidfireImage;
  canDrop = true;
};

////////////////
//weapon image//
////////////////
datablock ShapeBaseImageData(rapidfireImage)
{
   // Basic Item properties
   shapeFile = "./models/emptyWeapon.dts";
   emap = true;

   // Specify mount point & offset for 3rd person, and eye offset
   // for first person rendering.
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = 0; //"0.7 1.2 -0.5";
   rotation = eulerToMatrix( "0 0 0" );

   // When firing from a point offset from the eye, muzzle correction
   // will adjust the muzzle vector to point to the eye LOS point.
   // Since this weapon doesn't actually fire from the muzzle point,
   // we need to turn this off.  
   correctMuzzleVector = true;

   // Add the WeaponImage namespace as a parent, WeaponImage namespace
   // provides some hooks into the inventory system.
   className = "WeaponImage";

   // Projectile && Ammo.
   item = rapidfireItem;
   ammo = " ";
   projectile = rapidfireProjectile;
   projectileType = Projectile;

   //melee particles shoot from eye node for consistancy
   melee = false;
   //raise your arm up or not
   armReady = true;

   doColorShift = true;
   colorShiftColor = rapidfireItem.colorShiftColor;//"0.400 0.196 0 1.000";
   
stateName[0]                    = "Activate";
  stateTimeoutValue[0]            = 0.15;
  stateTransitionOnTimeout[0]     = "Ready";
  stateSound[0]       = "";
  stateEmitter[0]         = RapidFireEmitter;
        stateEmitterTime[0]            = 600;


  stateName[1]                    = "Ready";
  stateTransitionOnTriggerDown[1] = "Fire";
  stateAllowImageChange[1]        = true;
  stateTimeoutValue[1]      = 0.1;
  stateEmitter[1]         = RapidSmokeEmitter;
  stateEmitterTime[1]            = 0.05;

  stateName[2]                    = "Fire";
  stateTransitionOnTimeout[2]     = "Smoke";
  stateTimeoutValue[2]            = 0.14;
  stateFire[2]                    = true;
  stateAllowImageChange[2]        = false;
  stateSequence[2]                = "Fire";
  stateScript[2]                  = "onFire";
  stateWaitForTimeout[2]      = true;
  stateSound[2]       = pixelfire4Sound;

  stateName[3]        = "Smoke";
  stateTimeoutValue[3]            = 0.2;
  stateTransitionOnTimeout[3]     = "Reload";

  stateName[4]        = "Reload";
  stateTimeoutValue[4]      = 0.1;
  stateSequence[4]        = "reload";
  stateTransitionOnTimeout[4]   = "Activate";
  stateWaitForTimeout[4]      = true;
  stateEjectShell[4]          = false;
};
function rapidfireImage::onFire(%this,%obj,%slot)
{
  if((%obj.lastFireTime+%this.minShotTime) > getSimTime())
    return;
  %obj.lastFireTime = getSimTime();
      
  // %obj.setVelocity(VectorAdd(%obj.getVelocity(),VectorScale(%obj.client.player.getEyeVector(),"-3")));
  %obj.addVelocity(VectorScale(%obj.getForwardVector(),"-3"));
  %obj.playThread(2, shiftAway);

  %projectile = %this.projectile;
  %obj.spawnExplosion(feedbackProjectile,"1 1 1");



  %projectile = %this.projectile;
  %spread = 0.0025;
  %shellcount = 10;

  for(%shell=0; %shell<%shellcount; %shell++)
  {
    %vector = %obj.getMuzzleVector(%slot);
    %objectVelocity = %obj.getVelocity();
    %vector1 = VectorScale(%vector, %projectile.muzzleVelocity);
    %vector2 = VectorScale(%objectVelocity, %projectile.velInheritFactor);
    %velocity = VectorAdd(%vector1,%vector2);
    %x = (getRandom() - 0.5) * 10 * 3.1415926 * %spread;
    %y = (getRandom() - 0.5) * 10 * 3.1415926 * %spread;
    %z = (getRandom() - 0.5) * 10 * 3.1415926 * %spread;
    %mat = MatrixCreateFromEuler(%x @ " " @ %y @ " " @ %z);
    %velocity = MatrixMulVector(%mat, %velocity);

    %p = new (%this.projectileType)()
    {
      dataBlock = %projectile;
      initialVelocity = %velocity;
      initialPosition = %obj.getMuzzlePoint(%slot);
      sourceObject = %obj;
      sourceSlot = %slot;
      client = %obj.client;
    };
    MissionCleanup.add(%p);
  }
  return %p;
}
function rapidfireItem::onAdd(%this, %obj)
{
%obj.canPickup = true;

%obj.playThread(0, rotate);
%obj.rotate = true;
Parent::onAdd(%this, %obj);
}

datablock ParticleData(PixelGrabStatusParticle)
{
  dragCoefficient      = 0.2;
  gravityCoefficient   = 0.5;
  inheritedVelFactor   = 0.6;
  constantAcceleration = 0.0;
  spinRandomMin        = -90;
  spinRandomMax     = 90;
  lifetimeMS           = 1300;
  lifetimeVarianceMS   = 400;
  textureName          = "base/data/particles/dot";
  colors[0]     = "0.2 0.7 0.9 0.3";
  colors[1]     = "0.15 0.4 0.7 0.4";
  colors[2]     = "0.2 0.4 0.6 0.0";
//  colors[3]     = "0.4 0.6 0.4 0.0";
  sizes[0]      = 0.01;
  sizes[1]      = 0.25;
  sizes[2]      = 0.05;
//  sizes[3]      = 0.0;
  times[0]    = 0.0;
  times[1]    = 0.3;
  times[2]    = 1;
//  times[3]    = 1.0;

};

datablock ParticleEmitterData(PixelGrabStatusEmitter)
{
   ejectionPeriodMS = 30; //7
   periodVarianceMS = 2;
   ejectionVelocity = 0;
   velocityVariance = 0.0;
   ejectionOffset   = 1.0;
   thetaMin         = 0;
   thetaMax         = 180;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   overrideAdvance = false;
   particles = "PixelGrabStatusParticle";

   uiName = "";
};

datablock ParticleData(PixelGrabPulseParticle)
{
  dragCoefficient      = 0.8;
  gravityCoefficient   = -1.0;
  inheritedVelFactor   = 1;
  constantAcceleration = 0.0;
  spinRandomMin        = -90;
  spinRandomMax     = 90;
  lifetimeMS           = 1000;
  lifetimeVarianceMS   = 300;
  textureName          = "base/data/particles/cloud";
  colors[0]     = "0.2 0.6 0.9 0.2";
  colors[1]     = "0.2 0.7 0.8 0.0";
  sizes[0]      = 2.0;
  sizes[1]      = 0.01;
  times[0]    = 0.0;
  times[1]    = 1.0;

};

datablock ParticleEmitterData(PixelGrabPulseEmitter)
{
   ejectionPeriodMS = 70; //7
   periodVarianceMS = 5;
   ejectionVelocity = 0;
   velocityVariance = 0.0;
   ejectionOffset   = 0.6;
   thetaMin         = 0;
   thetaMax         = 180;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   overrideAdvance = false;
   particles = "PixelGrabPulseParticle";

   uiName = "";
};

datablock ShapeBaseImageData(PixelGrabStatusPlayerImage)
{
   shapeFile = "base/data/shapes/empty.dts";
   emap = true;

   mountPoint = 5;
   offset = "0 0 -0.3";
   eyeOffset = 0;
   rotation = "0 0 0";

   correctMuzzleVector = true;

   className = "WeaponImage";

   item = "";
   ammo = " ";
   projectile = "";
   projectileType = Projectile;
   
   isPoison = 1;

   melee = false;
   armReady = false;

   doColorShift = false;
   colorShiftColor = "1 1 1 1";

  //lightType = "ConstantLight";
  //lightColor = "0 1 0";
  //lightRadius = 4;

  stateName[0]                   = "Wait";
  stateTimeoutValue[0]           = 0.3;
  stateEmitter[0]                = PixelGrabStatusEmitter;
  stateEmitterTime[0]            = 1;
  stateTransitionOnTimeout[0]    = "Poison";
  //stateSound[0]                  = PixelGrabPulseSound;

  stateName[1]                   = "Poison";
  //stateScript[1]                 = "Damage";
  stateEmitter[1]                = PixelGrabPulseEmitter;
  stateEmitterTime[1]            = 0.6;
  stateTimeoutValue[1]           = 0.1;
  stateTransitionOnTimeout[1]    = "Wait";
  //stateSound[1]                  = FireShotSound; //No sound
};
