datablock AudioProfile(SkeletalDeathExplosionSound)
{
   filename    = "base/data/sound/breakBrick.wav";
   description = AudioClosest3d;
   preload = false;
};

datablock DebrisData(skeleheadDebris)
{
   shapeFile = "./models/skelehead.dts";
   lifetime = 6.0;
   minSpinSpeed = -400.0;
   maxSpinSpeed = 200.0;
   elasticity = 0.5;
   friction = 0.2;
   numBounces = 3;
   staticOnMaxBounce = true;
   snapOnMaxBounce = false;
   fade = true;
   gravModifier = 2;
};
datablock DebrisData(handDebris : skeleheadDebris)
{
   shapeFile = "./models/hand.dts";
   lifetime = 6.0;
   minSpinSpeed = -400.0;
   maxSpinSpeed = 200.0;
   elasticity = 0.5;
   friction = 0.2;
   numBounces = 3;
   staticOnMaxBounce = true;
   snapOnMaxBounce = false;
   fade = true;
   gravModifier = 2;
};
datablock DebrisData(handLeftDebris : skeleheadDebris)
{
   shapeFile = "./models/handLeft.dts";
   lifetime = 6.0;
   minSpinSpeed = -400.0;
   maxSpinSpeed = 200.0;
   elasticity = 0.5;
   friction = 0.2;
   numBounces = 3;
   staticOnMaxBounce = true;
   snapOnMaxBounce = false;
   fade = true;
   gravModifier = 2;
};
datablock DebrisData(skeleshoulderDebris : skeleheadDebris)
{
   shapeFile = "./models/skeleshoulder.dts";
   lifetime = 6.0;
   minSpinSpeed = -400.0;
   maxSpinSpeed = 200.0;
   elasticity = 0.5;
   friction = 0.2;
   numBounces = 3;
   staticOnMaxBounce = true;
   snapOnMaxBounce = false;
   fade = true;
   gravModifier = 2;
};
datablock DebrisData(footDebris : skeleheadDebris)
{
   shapeFile = "./models/foot.dts";
   lifetime = 6.0;
   minSpinSpeed = -400.0;
   maxSpinSpeed = 200.0;
   elasticity = 0.5;
   friction = 0.2;
   numBounces = 3;
   staticOnMaxBounce = true;
   snapOnMaxBounce = false;
   fade = true;
   gravModifier = 2;
};
datablock ExplosionData(SkeletalDeathExplosion1)
{
   lifetimeMS = 33;
   particleEmitter = "";
   debrisNumVariance      = 0;
   debrisPhiMin           = 0;
   debrisPhiMax           = 360;
   debrisThetaMin         = 5;
   debrisThetaMax         = 105;
   debrisVelocity         = 5;
   debrisVelocityVariance = 1;

   debris = skeleheadDebris;
   debrisNum = 0;

   faceViewer     = true;
   explosionScale = "1 1 1";

   shakeCamera = false;

   lightStartRadius = 0;
   lightEndRadius = 0;

   impulseRadius = 100;
   impulseForce = 100;

   radiusDamage = 0;
   damageRadius = 0;
};
datablock ExplosionData(SkeletalDeathExplosion2 : SkeletalDeathExplosion1)
{
   debris = footDebris;
   debrisNum = 2;
};
datablock ExplosionData(SkeletalDeathExplosion3 : SkeletalDeathExplosion1)
{
   debris = skeleshoulderDebris;
   debrisNum = 2;
};
datablock ExplosionData(SkeletalDeathExplosion4 : SkeletalDeathExplosion1)
{
   debris = handDebris;
   debrisNum = 1;
};
datablock ExplosionData(SkeletalDeathExplosion5 : SkeletalDeathExplosion1)
{
   debris = handLeftDebris;
   debrisNum = 1;
};
datablock ExplosionData(SkeletalDeathExplosion : SkeletalDeathExplosion1)
{
   lifeTimeMS = 500;

   //particleEmitter = "";
   particleDensity = 45;
   particleRadius  = 2.5;

   debris = skeleheadDebris;
   debrisNum = 1;

   soundProfile = SkeletalDeathExplosionSound;

   //emitter[0] = "";

   subExplosion[0] = SkeletalDeathExplosion1;
   subExplosion[1] = SkeletalDeathExplosion2;
   subExplosion[2] = SkeletalDeathExplosion3;
   subExplosion[3] = SkeletalDeathExplosion4;
   subExplosion[4] = SkeletalDeathExplosion5;
};

datablock ProjectileData(SkeletalDeathExplosionProjectile)
{
   projectileShapeName = "base/data/shapes/empty.dts";
   directDamage     = 10;
   directDamageType = $DamageType::Default; //Damagetype default actually does no damage
   radiusDamageType = $DamageType::Default;
   impactImpulse    = 10;
   verticalImpulse  = 10;
   explosion        = SkeletalDeathExplosion;

   brickExplosionRadius            = 0;
   brickExplosionImpact            = false; 
   brickExplosionForce             = 0;
   brickExplosionMaxVolume         = 0;
   brickExplosionMaxVolumeFloating = 0;

   muzzleVelocity   = 1;
   velInheritFactor = 1;

   lifetime         = 10;
   bounceElasticity = 0;
   bounceFriction   = 0;
   isBallistic    = false;
   explodeOnDeath = true;
   hasLight       = false;
};