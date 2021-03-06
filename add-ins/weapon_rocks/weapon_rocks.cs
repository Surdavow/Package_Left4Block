%pattern = "add-ons/gamemode_left4block/add-ins/weapon_rocks/sound/*.wav";//Too lazy to write datablock files for the sounds, just took this from the Disease Gamemode
%file = findFirstFile(%pattern);
while(%file !$= "")
{
	%soundName = strlwr(%file);
	%soundName = strreplace(%soundName, "add-ons/gamemode_left4block/add-ins/weapon_rocks/sound/", "");
	%soundName = strreplace(%soundName, "/", "");
	%soundName = strreplace(%soundName, ".wav", "");
	%soundName = strreplace(%soundName, "loud", "");

	if(strstr(%file,"loud") != -1)//Loudest Soundscape
	if(strstr(%file,"loop") != -1)
	eval("datablock AudioProfile(" @ %soundName @ "_sound) { preload = true; description = AudioDefaultLooping3d; filename = \"" @ %file @ "\"; };");
	else eval("datablock AudioProfile(" @ %soundName @ "_sound) { preload = true; description = AudioDefault3d; filename = \"" @ %file @ "\"; };");

	%file = findNextFile(%pattern);
}

datablock DebrisData(boulder1debris)
{
   emitters = "";

	shapeFile = "./models/boulderpiece1.dts";
	lifetime = 10;
	spinSpeed			= 2000.0;
	minSpinSpeed = -100.0;
	maxSpinSpeed = 100.0;
	elasticity = 0.5;
	friction = 0.4;
	numBounces = 5;
	staticOnMaxBounce = true;
	snapOnMaxBounce = false;
	fade = true;

	gravModifier = 1;
};
datablock ExplosionData(boulder1debrisExplosion)
{
   particleEmitter = "";

   debris = boulder1debris;
   debrisNum = 2;
   debrisNumVariance = 6;
   debrisPhiMin = 0;
   debrisPhiMax = 360;
   debrisThetaMin = 0;
   debrisThetaMax = 180;
   debrisVelocity = 3;
   debrisVelocityVariance = 1;
};

datablock DebrisData(boulder2debris)
{
   emitters = "";

	shapeFile = "./models/boulderpiece2.dts";
	lifetime = 10;
	spinSpeed			= 2000.0;
	minSpinSpeed = -100.0;
	maxSpinSpeed = 100.0;
	elasticity = 0.5;
	friction = 0.4;
	numBounces = 5;
	staticOnMaxBounce = true;
	snapOnMaxBounce = false;
	fade = true;

	gravModifier = 1;
};
datablock ExplosionData(boulder2debrisExplosion)
{
   particleEmitter = "";

   debris = boulder2debris;
   debrisNum = 2;
   debrisNumVariance = 6;
   debrisPhiMin = 0;
   debrisPhiMax = 360;
   debrisThetaMin = 0;
   debrisThetaMax = 180;
   debrisVelocity = 3;
   debrisVelocityVariance = 1;
};

datablock DebrisData(boulder3debris)
{
   emitters = "";

	shapeFile = "./models/boulderpiece3.dts";
	lifetime = 10;
	spinSpeed			= 2000.0;
	minSpinSpeed = -100.0;
	maxSpinSpeed = 100.0;
	elasticity = 0.5;
	friction = 0.4;
	numBounces = 5;
	staticOnMaxBounce = true;
	snapOnMaxBounce = false;
	fade = true;

	gravModifier = 1;
};
datablock ExplosionData(boulder3debrisExplosion)
{
   particleEmitter = "";

   debris = boulder3debris;
   debrisNum = 2;
   debrisNumVariance = 6;
   debrisPhiMin = 0;
   debrisPhiMax = 360;
   debrisThetaMin = 0;
   debrisThetaMax = 180;
   debrisVelocity = 3;
   debrisVelocityVariance = 1;
};

datablock DebrisData(boulder4debris)
{
   emitters = "";

	shapeFile = "./models/boulderpiece4.dts";
	lifetime = 10;
	spinSpeed			= 2000.0;
	minSpinSpeed = -100.0;
	maxSpinSpeed = 100.0;
	elasticity = 0.5;
	friction = 0.4;
	numBounces = 5;
	staticOnMaxBounce = true;
	snapOnMaxBounce = false;
	fade = true;

	gravModifier = 1;
};
datablock ExplosionData(boulder4debrisExplosion)
{
   particleEmitter = "";

   debris = boulder4debris;
   debrisNum = 2;
   debrisNumVariance = 6;
   debrisPhiMin = 0;
   debrisPhiMax = 360;
   debrisThetaMin = 0;
   debrisThetaMax = 180;
   debrisVelocity = 3;
   debrisVelocityVariance = 1;
};

datablock ExplosionData(BoulderExplosion : spearExplosion)
{
   soundProfile = "boulder_hit_sound";
   //impulse
   impulseRadius = 10;
   impulseForce = 5000;

   //subExplosion[0] = boulder1debrisExplosion;
   //subExplosion[1] = boulder2debrisExplosion;
   //subExplosion[2] = boulder3debrisExplosion;
   //subExplosion[3] = boulder4debrisExplosion;

   //radius damage
   radiusDamage        = 50;
   damageRadius        = 10;

   faceViewer     = true;
   explosionScale = "5 5 5";

   shakeCamera = true;
   camShakeFreq = "2 2 2";
   camShakeAmp = "1.25 1.25 1.25";
   camShakeDuration = 4;
   camShakeRadius = 1.25;
};

datablock ExplosionData(BoulderExplosion1 : spearExplosion)
{
   soundProfile = "";
   //impulse
   impulseRadius = 0;
   impulseForce = 0;

   //radius damage
   radiusDamage        = 0;
   damageRadius        = 0;
};

//spear trail
datablock ParticleData(boulderTrailParticle)
{
	dragCoefficient		= 3.0;
	windCoefficient		= 0.0;
	gravityCoefficient	= 0.0;
	inheritedVelFactor	= 0.0;
	constantAcceleration	= 0.0;
	lifetimeMS		= 600;
	lifetimeVarianceMS	= 0;
	spinSpeed		= 10.0;
	spinRandomMin		= -50.0;
	spinRandomMax		= 50.0;
	useInvAlpha		= true;
	animateTexture		= false;
	//framesPerSec		= 1;

	textureName		= "base/data/particles/cloud";
	//animTexName		= " ";

	// Interpolation variables
	colors[0]	= "0.5 0.5 0.5 0.1";
	colors[1]	= "0.25 0.25 0.25 0.05";
	colors[2]	= "0.05 0.05 0.05 0";
	sizes[0]	= 3;
	sizes[1]	= 1;
	sizes[2]	= 0.1;
	times[0]	= 0.0;
	times[1]	= 0.1;
	times[2]	= 1.0;
};

datablock ParticleEmitterData(boulderTrailEmitter)
{
   ejectionPeriodMS = 5;
   periodVarianceMS = 0;

   ejectionVelocity = 0.25; //0.25;
   velocityVariance = 0.10; //0.10;

   ejectionOffset = 0;

   thetaMin         = 0.0;
   thetaMax         = 90.0;  

   particles = boulderTrailParticle;

   useEmitterColors = true;
   uiName = "";
};


//projectile
AddDamageType("BoulderDirect",   '<bitmap:./icons/CI_Boulder> %1',       '%2 <bitmap:./icons/CI_Boulder> %1',1,1);
AddDamageType("BoulderRadius",   '<bitmap:./icons/CI_Boulder> %1', '%2 <bitmap:./icons/CI_Boulder> %1',1,0);
datablock ProjectileData(BoulderProjectile)
{
   projectileShapeName = "./models/BoulderProjectile.dts";
   directDamage        = 30;
   directDamageType  = $DamageType::BoulderDirect;
   radiusDamageType  = $DamageType::BoulderRadius;
   impactImpulse	   = 500;
   verticalImpulse	   = 150;
   explosion           = BoulderExplosion;
   particleEmitter     = boulderTrailEmitter;

   brickExplosionRadius = 0;
   brickExplosionImpact = true; //destroy a brick if we hit it directly?
   brickExplosionForce  = 0;
   brickExplosionMaxVolume = 0;
   brickExplosionMaxVolumeFloating = 0;

   muzzleVelocity      = 20;
   velInheritFactor    = 1;

   armingDelay         = 0;
   lifetime            = 20000;
   fadeDelay           = 19500;
   bounceElasticity    = 0;
   bounceFriction      = 0;
   isBallistic         = true;
   gravityMod = 1;

   hasLight    = false;
   uiName = "";
};

datablock ProjectileData(TankLandProjectile)
{
   projectileShapeName = "./models/BoulderProjectile.dts";
   directDamage        = 24;
   directDamageType  = $DamageType::Tank;
   radiusDamageType  = $DamageType::Tank;
   impactImpulse	   = 5;
   verticalImpulse	   = 5;
   explosion           = BoulderExplosion;
   particleEmitter     = "";

   brickExplosionRadius = 0;
   brickExplosionImpact = true; //destroy a brick if we hit it directly?
   brickExplosionForce  = 0;
   brickExplosionMaxVolume = 0;
   brickExplosionMaxVolumeFloating = 0;

   muzzleVelocity      = 20;
   velInheritFactor    = 1;

   armingDelay         = 0;
   lifetime            = 20000;
   fadeDelay           = 19500;
   bounceElasticity    = 0;
   bounceFriction      = 0;
   isBallistic         = true;
   gravityMod = 1.0;

   hasLight    = false;
   lightRadius = 3.0;
   lightColor  = "0 0 0.5";

   uiName = "";
};

datablock ProjectileData(BoulderProjectile1 : BoulderProjectile)
{
   directDamage        = 0;
   impactImpulse	   = 0;
   verticalImpulse	   = 0;
   explosion           = BoulderExplosion1;

};

datablock ShapeBaseImageData(BoulderImage)
{
   shapeFile = "./models/Boulder.dts";
   emap = true;
   mountPoint = 0;
   offset = "-1.625 0 0";
   rotation				= eulerToMatrix( "90 0 90" );
   correctMuzzleVector = true;
   className = "WeaponImage";

   // Projectile && Ammo.
   item = BoulderItem;
   ammo = " ";
   projectile = "";
   projectileType = Projectile;

   //melee particles shoot from eye node for consistancy
   melee = true;
   //raise your arm up or not
   armReady = true;

   isChargeWeapon = true;

   //casing = " ";
   doColorShift = true;
   colorShiftColor = "0.400 0.196 0 1.000";

	stateName[0]			= "Activate";
	stateTimeoutValue[0]		= 1.5;
	stateTransitionOnTimeout[0]	= "Ready";
	stateSequence[0]		= "ready";
   stateScript[0]			= "onActivate";
	stateSound[0]					= weaponSwitchSound;

	stateName[1]			= "Ready";
	stateTransitionOnTriggerDown[1]	= "Fire";
	stateAllowImageChange[1]	= true;

	stateName[2]			= "Fire";
	stateTransitionOnTimeout[2]	= "Ready";
	stateFire[2]			= true;
	stateSequence[2]		= "fire";
	stateScript[2]			= "onFire";
	stateWaitForTimeout[2]		= true;
   stateTimeoutValue[2]		= 5;
	stateAllowImageChange[2]	= false;
	stateSound[2]				= "";
};

function BoulderImage::onActivate(%this, %obj, %slot)
{
   %obj.playaudio(1, "tank_rock_grab_sound");
   %obj.playthread(1, spearReady);
   %obj.spawnExplosion(BoulderProjectile1,1); //boom
   %obj.setenergylevel(0);
}

function BoulderProjectile::onExplode(%this,%obj)
{
	for(%i=0;%i<75;%i++)
	{
		%rnd = getRandom();
		%dist = getRandom()*15;
		%x = mCos(%rnd*$PI*3)*%dist;
		%y = mSin(%rnd*$PI*3)*%dist;
		%p = new projectile()
		{
			datablock = MxRockProjectile;
			initialPosition = vectorAdd(%obj.getPosition(),"0 0 1.5");
			initialVelocity = %x SPC %y SPC (getRandom()*4);
			client = %obj.sourceObject.client;
			sourceObject = %obj.sourceObject;
			damageType = $DamageType::SpitAcidBall;
		};
	}
	Parent::onExplode(%this,%obj);
}

function BoulderImage::onFire(%this, %obj, %slot)
{
   %obj.schedule(75,TankThrowBoulder);
   %obj.playthread(1, spearThrow);
   %obj.playaudio(1, "tank_rock_toss" @ getRandom(1,3) @ "_sound");
   return;
}


function Player::TankThrowBoulder(%obj)
{
   %obj.playthread(2, "activate2");
   %obj.playthread(3, "activate2");
   %obj.playthread(0, "jump");

   if(isObject(%targ = %obj.hFollowing))
   %velocity = vectorscale(%obj.getEyeVector(),50+vectorDist(%obj.getHackPosition(),%targ.getHackPosition())*0.75);
   else %velocity = vectorscale(%obj.getEyeVector(),75);
   
   %p = new Projectile()
   {
      dataBlock = "BoulderProjectile";
      initialVelocity = vectorAdd(%velocity,"0 0 2.5");
      initialPosition = %obj.getHackPosition();
      sourceObject = %obj;
      client = %obj.client;
      scale = "4 4 4";
   };
   MissionCleanup.add(%p);
   %obj.unMountImage(0);
}

datablock ExplosionData(MxRockExplosion : spearExplosion)
{
   soundProfile = "rock_hit_sound";
   impulseRadius = 5;
   impulseForce = 1000;
   radiusDamage = 20;
   damageRadius = 5;
};

AddDamageType("MxRockDirect",   '<bitmap:./icons/CI_MxRock> %1',       '%2 <bitmap:./icons/CI_MxRock> %1',1,1);
AddDamageType("MxRockRadius",   '<bitmap:./icons/CI_MxRock> %1', '%2 <bitmap:./icons/CI_MxRock> %1',1,0);
datablock ProjectileData(MxRockProjectile)
{
   projectileShapeName = "./models/MxRockProjectile.dts";
   directDamage        = 10;
   directDamageType  = $DamageType::MxRockDirect;
   radiusDamageType  = $DamageType::MxRockRadius;
   impactImpulse	   = 5;
   verticalImpulse	   = 5;
   explosion           = MxRockExplosion;
   particleEmitter     = SpearTrailEmitter;

   brickExplosionImpact = false;

   muzzleVelocity      = 50;
   velInheritFactor    = 1;

   armingDelay         = 0;
   lifetime            = 20000;
   fadeDelay           = 19500;
   bounceElasticity    = 0;
   bounceFriction      = 0;
   isBallistic         = true;
   gravityMod = 1.0;

   hasLight    = false;
   uiName = "";
};

datablock ShapeBaseImageData(MxRockImage)
{

   shapeFile = "./models/MxRock.dts";
   emap = true;

   mountPoint = 0;
   offset = "0 0 0";
   correctMuzzleVector = true;

   className = "WeaponImage";

   // Projectile && Ammo.
   item = "";
   ammo = " ";
   projectile = MxRockProjectile;
   projectileType = Projectile;

   melee = false;
   armReady = true;

   isChargeWeapon = true;


   doColorShift = true;
   colorShiftColor = "0.400 0.196 0 1.000";
	stateName[0]			= "Activate";
	stateTimeoutValue[0]		= 0.1;
	stateTransitionOnTimeout[0]	= "Ready";
	stateSequence[0]		= "ready";
	stateSound[0]					= weaponSwitchSound;

	stateName[1]			= "Ready";
	stateTransitionOnTriggerDown[1]	= "Charge";
	stateAllowImageChange[1]	= true;
	
	stateName[2]                    = "Charge";
	stateTransitionOnTimeout[2]	= "Armed";
	stateTimeoutValue[2]            = 0.3;
	stateWaitForTimeout[2]		= false;
	stateTransitionOnTriggerUp[2]	= "AbortCharge";
	stateScript[2]                  = "onCharge";
	stateAllowImageChange[2]        = false;
	
	stateName[3]			= "AbortCharge";
	stateTransitionOnTimeout[3]	= "Ready";
	stateTimeoutValue[3]		= 0.3;
	stateWaitForTimeout[3]		= true;
	stateScript[3]			= "onAbortCharge";
	stateAllowImageChange[3]	= false;

	stateName[4]			= "Armed";
	stateTransitionOnTriggerUp[4]	= "Fire";
	stateAllowImageChange[4]	= false;

	stateName[5]			= "Fire";
	stateTransitionOnTimeout[5]	= "Ready";
	stateTimeoutValue[5]		= 0.5;
	stateFire[5]			= true;
	stateSequence[5]		= "fire";
	stateScript[5]			= "onFire";
	stateWaitForTimeout[5]		= true;
	stateAllowImageChange[5]	= false;
	stateSound[5]				= spearFireSound;
};

function MxRockImage::onCharge(%this, %obj, %slot)
{
	%obj.playthread(2, spearReady);
	%obj.lastHESlot = %obj.currTool;
}

function MxRock::onAbortCharge(%this, %obj, %slot)
{
	%obj.playthread(2, root);
}

function MxRockImage::onFire(%this, %obj, %slot)
{
	%obj.playthread(3, spearThrow);
	Parent::OnFire(%this, %obj, %slot);

	%currSlot = %obj.lastHESlot;
	%obj.tool[%currSlot] = 0;
	%obj.weaponCount--;
	messageClient(%obj.client,'MsgItemPickup','',%currSlot,0);
	serverCmdUnUseTool(%obj.client);
}

function MxRock::onDone(%this,%obj,%slot)
{
	%obj.unMountImage(%slot);
}