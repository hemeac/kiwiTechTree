# Kiwi's Tech Tree Overhaul

## Version 0.8.0; 8 October 2020; Currently tested only in KSP 1.9.1

![Kiwi Tech Tree Overhaul](https://i.imgur.com/1MWP2O1.png)

A "Probes/Planes Before Crew" type overhaul of the Tech Tree inspired by Zee's [PBC Mod](https://forum.kerbalspaceprogram.com/index.php?/topic/181013-ksp-181-probes-before-crew-pbc-version-28/) and Spink Akron/theonegalen's [UnKerballed Start](https://forum.kerbalspaceprogram.com/index.php?/topic/196589-1101-unkerballed-start-v120-under-new-management-aug-28-2020/). It builds on that concept by further providing an upgrade path (via B9PS or the stock upgrade system when B9 is not available) for many of the parts, such as decreased dry mass, increased thrust/efficiency, or improved SAS levels.  I attempt to balance the improvements by having the upgrades come with an increased cost and come later in the tech tree.  This should leave a choice between getting upgraded tech at a slightly lower cost first.

## Dependencies (Not Included)
* [Community Tech Tree](https://forum.kerbalspaceprogram.com/index.php?/topic/90530-110x-community-tech-tree-august-1-2020/)
* [B9 Part Switch](https://forum.kerbalspaceprogram.com/index.php?/topic/140541-1101-b9partswitch-v2170-july-29/)
* [Module Manager](https://forum.kerbalspaceprogram.com/index.php?/topic/50533-18x-110x-module-manager-414-july-7th-2020-locked-inside-edition/)

## Strongly Recommended
* [Science Param Editor](https://github.com/DMagic1/Science-Param-Loader)
  * Support for Stock; OPM; MPE; GEP
* [BetterSRBs](https://forum.kerbalspaceprogram.com/index.php?/topic/175316-15-1101-bettersrbs-v123-29-july-2020/)
  * Better SRBs is how I am handling the "upgrades" for SRBs.  I mod SRBs from supported mods to behave like Better SRBs custom configs.
* [Rational Resources](https://forum.kerbalspaceprogram.com/index.php?/topic/184875-rational-resources-v1110-sep-20-2020/)
  * Rational Resources implements some cold gas RCS modes into stock, ReStock+ and NF RCS blocks.  I've added upgrades to these parts and this will be how the mod handles RCS upgrades.  Be aware that this mod changes the distribution of planet resources and ISRU chains.
* [StageRecovery](https://forum.kerbalspaceprogram.com/index.php?/topic/179306-19x-stagerecovery-recover-funds-from-dropped-stages/)
  * Entry costs can get expensive, so it is probably good to recover as much of your vessel as possible.
* [Custom Barn Kit](https://forum.kerbalspaceprogram.com/index.php?/topic/109027-18-custom-barn-kit-1120-19-october-2019-parachute-included/)
  * Increases the initial number of parts for the VAB and SPH to be 40 as I do not find arbitrary part counts to be a fun game mechanic.

## Objectives

The Kiwi Tech Tree (KTT) overhaul, like its predecessors, revolves around the premise that probes should come before crewed space missions.  While I really enjoyed both aforementioned mods, I found it took a bit too long to see my kerbals in game and I could could progress through most of the tech tree before leaving Kerbin's sphere of influence.  You begin with 0.625m parts and work progressively larger.  To try to limit early crewed missions using plane cockpits, I have nerfed the skin temperature of the spaceplanes, but provide higher skin temperatures to the spaceplanes once they reach the High Altitude tech node (same tier as the Mk3 cockpit). I have made heat shields available relatively early, so you are of course free to experiment with re-entry.

KTT is a Tech Tree mod at it's core, however, I have tried to align stock parts and other mods to have similar functionality available with Nertea's NF Suite (if the relevant NF mods are installed).  I further implement some optional mods within the NF Suite using B9PS functionality. This removes the need to choose one or the other within the gameplay environment. If you like to play with new parts as the modder intended, this is not the right tech tree mod for you. 

Many parts have available upgrades such as engine upgrades which increase thrust/isp or structural upgrades which decrease the mass of the part.  These upgrades generally come paired with a 50% increasee in the part cost and available later in the tech tree. The rebalance is an attempt to make my tech choices a bit more meaningful and allow my kerbins to spend some time testing jets in Kerbin's atmosphere earlier in the career prior to launching in space.  

I have added another 70+ tech nodes across the tree, but have tried to leave the general layout of the tree largely consistent with the Community Tech Tree.  The major changes are adding a separate branch for solid rocket boosters and if you have mods which have cryogenic engines, this will move them to a different branch from the Liquid Fuel Branch. I have also tried to separate out science more explicitly within the tech tree. While I have shifted some of the nodes around, I have not removed any, thus leaving some compatibility with any mod that I have not explictly supported. To balance the additional number of science nodes, I have reduced some of the costs.  Expect to need to collect around 40% more science points over the course of your career to unlock the majority of the tree with parts. Science multipliers have increased within Kerbin, but have generally been reduced outside of Kerbin's Sphere of Influence.  Expect to need to visit more planets to complete the tech tree.

I calibrated the nodes around stock, expansion packs, Restock/Restock+ and Missing History.  The name of the nodes do not fully indicate the type of technology within the node, but rather the type of technologies that you should expect to find along the branch.  However, some branches do not fully represent their current use (ie. miniaturization where you will find ground science).  I have decided at this point to not rename them. Given the number of nodes, you will benefit by having several parts mods.

I have not spent excessive time balancing costs.  Costs for some mods have been aligned roughly to stock costs.  My general feeling is that money rewards should not be set too low in the difficulty settings, particularly if you are paying for parts to unlock.  My cost revamps are fairly ad-hoc. If this a bug bear for you and you want to tackle a comprehensive review of the cost structure, please get in touch.  I may readjust a few pieces if they are fundamentally out of proportion to other parts, but revamping costs are beyond the scope of what I will tackle.

In some cases, I have added rescaled parts, but indicated when and from what mod I have rescaled the parts within the description.  In cases like Missing History, I will use the Restock texture when available for consistency in the visual style.  

I have asked Nertea for permission in regards to using Restock/NF models for resizing (if they are installed) and have tried to indicate in the part descriptions which parts I have added in order to avoid confusion. However, please do not take this as Nertea's endorsement of the mod.

## General Gameplay Changes
* Probe behavior changes in two ways:  First is I have kept PBC's Telemetry Report.  It is a nice and easy way to get some early science which is obviously needed given the additional nodes.  I also reduce probes SAS levels to the lowest level for all probes and begin with no SAS functionality.  SAS is turned on early through an upgrade in Engineering 1010 and further SAS functionality is added along the Flight Control tech path.
* Renamed the command pods to reflect the relative node in which they appear.
* Cockpit heat resistance has been reduced until High-Altitude Flight which is added through a B9PS upgrade.
* Rocket Engines have received an B9PS upgrade two tiers above them which adds 20% Thrust, 10% Efficiency for an additional 50% Cost and 5% Mass. As an added "bonus", the upgrade variants have custom names.
* Jet Engines have received a B9PS upgrade two tiers later which adds about 20% thrust.  The R.A.P.I.E.R. gets moved into the "unique" propulsion branch rather than part of the jet engines.
* Command Pods, Fuel Tanks and the Mk1-3 Spaceplane Systems, and other structural parts have B9 upgrade systems implemented that reduce their dry weight by 20% for an additional 50% cost.
* Revamped Science points; Set the scienceCap to the same level as the base level eliminating need to repeat experiments.  Reduced the level of transmit science of Mystery Goo, Material Lab to 14% of cap.  Increased the transmission to 100% for all other stock science experiments.
* Added around 72 new tech nodes.  This increases the cost to unlock early tech tiers substantially, but KTT lowers the early cost of research nodes in most cases so it balances to a 40% premium in required science over the long-run. 

## Kerbalism 3.11 Compliant
I started off KTT without plans for Kerbalism, but this changed as I was developing the mod.  I have added support to a fair number of the mods that I support within KTT and believe that the Kerbalism experience will be enhanced when using KTT.  However, the tree does not require it to fully enjoy the tech tree.  I intend to add USI/MKS support in an upcoming update as a Kerbalism alternative.
* Balances the Kerbalism parts to correspond to general KTT placements
* Generally leaves the upgrades as is, the exception being pressure control upgrade which is a bit later in the tech tree corresponding to the later availability of command pods.  To that end, I have removed the unpressurized state of the Mk1 Command Pod.
* Added custom hard drive values to probes and command pods of supported mods.
* Integrated science experiments to Kerbalism for several mods that have custom experiments.
* Added radiation emitters to several atomic jets for mods not supported in-house by Kerbalism
* Added a few comfort upgrades to some station parts.
* Have nerfed the early reliability of engines slightly, both in terms of ignition failures and operation duration.  Duration is now a function of vacuum ISP (see note below). Vacuum engines have a higher baseline reliability than surface launchers.  While Kerbalism has an in-game mechanic to increase reliability, I add increases in the baseline reliability of engines through part upgrades.  
  * Ion engine duration is now finite, but argon thrusters now match Ion thruster durability.
  * Duration upgrades are engine specific and will come in the same upgrade that increases thrust, ISP, etc. that normally is available two tiers after the engine is first available.  E
  * Engine ignition reliability will be global between liquid fuel engines and separately, solid rocket boosters.  This allows some early fun at watching engines explode, but that will be less of a feature as the space program matures. This hopefully will avoid the game mechanic getting stale when you have spent several hours developing a craft and just want it to !@#%$#@$ work before you go to bed.
  * Note: When calculating rated duration of hydrolox engines, I divide the ISP by 30% to get an approximate ISP if the engine was Kerolox.
  

## Current Supported Mods (see details below for general changes):
* Airplane Plus 26.5
* B9 Procedural Wings Fork 1.0.0
* BetterSRBs 1.2.3
* BonVoyage 1.1.1
* Bumblebee 0.5
* Completely Non-Aggressive Rocketry 1.0.2
* Conformal Decals 0.2.0
* Cryogenic Engines 1.1.4
* CryoTanks 1.5.2
* Decoupler Shroud 0.7.2
* Deep Space Surface Habitat Unit Pack 1.10.1
* DeepFreeze 0.28.0
* DMagic Orbital Science 1.4.3
* Dodo Labs 1.3.1
* Duna Direct 1.10.1
* Extraplanetary Launchpads 6.8.2
* Fuji 1.1
* Grounded 5.00
* Heat Control 0.5.2
* Interkosmos 0.3
* Internal RCS 1.2
* James Webb 1.10
* KeR-7 1.0
* Kerbal Atomics 1.1.4
* Kerbal Attachment System 1.7
* Kerbal Engineer Redux 1.1.7.2
* Kerbal Inventory System 1.26
* Kerbal Planetary Base Systems 1.6.12
* Kerbal Reusability Expansion 2.8.6
* Knes  1.8.2
* KOOSE 2.0.5
* kOS 1.2.1.0
* Kraken Science 1.0
* LTech 0.5.1.5 [Beta]
* Luciole 1.5
* Making Alternate History 1.10.1
* The Martian 1.10.1.2
* M.O.L.E. 1.22.1 (Very Limited Support) 
* Mark IV Spaceplane System 3.1.2
* Missing History 1.8.2
* Mk-33 [Beta; 8 September 2020]
* Mk2 Stockalike Expansion 1.8.9.3
* Mk3 Stockalike Expansion 1.5.1
* Modular Launch Pads 2.1 [Alpha]
* Near Future Aeronautics 2.0.0
* Near Future Construction 1.2.3
* Near Future Electrical 1.1.3
* Near Future Exploration 1.0.10
* Near Future Launch Vehicles 2.0.3
* Near Future Propulsion 1.2.2
* Near Future Solar 1.2.3
* Near Future Spacecraft 1.3.3
* Rational Resources 1.11.0 (Based off Github repository dated 1 October 2020)
* RealPlume-Stock 4.0.1
* Restock/Restock+ 1.1.2
* SCANsat 20.4
* Science Pancake 1.0.0
* Science Param Editor 12.0
* SmartParts 1.9.16
* Smart Docking Aid 1.0
* Stockalike Mining Extension 1.1.6
* Stockalike Station Parts Expansion Redux 1.3.6
* Stockish Project Orion 1.8.1
* Super Heavy Boosters Historical - Nexus 2.0.200524 (Limited Support)
* TD Advanced Propulsion Systems - 0.6.200606 (Limited Support)
* Universal Storage 2 1.9.1.2
* Ж-20 "Moroz" Spaceplane 1.3

## Planned Mods
* Roadmap for [Version 1.0](https://github.com/hemeac/kiwiTechTree/milestone/1) to see what the planned mod support will be.  
* "Near Future" roadmap for [Version 1.5](https://github.com/hemeac/kiwiTechTree/milestone/2).  Some of these are a bit ambitious and not sure that I will practically get them done on my own.
* "Possible" roadmap for [Version 2.0](https://github.com/hemeac/kiwiTechTree/milestone/3)

## No Planned Support
* Firespitter Parts
  * The B9 system does not appear to be compatible with the switcher system in Firespitter, so will not upgrade any parts that use that system and will avoid any parts mod that exclusively uses it for engines. AirplanePlus was the exception as most motors relied on stock mechanics for the engines.
* Any BDArmory or related mod as that style of gameplay does not interest me.

## Known/Likely Issues
* Couple of upgrade lines in the Tech Tree may disappear when viewing them near the edges of the screen. This issue has disappeared "naturally" on my install.
* Many of the extras for the Near Future Suite that change the behavior of engines, etc. will most likely not lead to expected results if installed.  Check each mod above as some behaviors were adopted directly. This is not a bug and will not be fixed.
* Kerbal Research & Development's upgrade system appears to be incompatible with the upgrades that I have implemented.  I would expect bad things to happen.
* Realistic Power Draw modifies the science modules and given the ordering of the pass in MM, this will likely break the changes to the science system I am doing.  If you use this and want me to make a patch, get in touch.
* Removing parts from installed mods (either manually removing configs or Perma Prune in Janitor's Closet) that have part upgrades will very likely break upgrades for other parts.  If you remove the parts, you will need to remove the associated PARTUPGRADE node from the mod manually.
* This breaks support for Smart Docking Aid.  Considering how to best implement a compatibility patch.
* Very likely to break any mod that attempts to reconfigure engines or fuel tanks in any manner.
* Smart Docking Aid functionality is added by this mod to all probes due to an inability to tie it to probes once Level 3 SAS upgrades have been applied. Limited testing suggests it may not turn on until SAS 3, but need to test further.

## Airplane Plus 26.5
Reshuffled tech nodes, generally provide parts one or two tiers earlier than the default.  Added space worthiness upgrade to cockpits.  Added engine upgrades to engines with the exceptions of the rotors not using ModuleEngines as they cannot be modified by B9PS. **If Kerbalism is installed: Depressurized small cockpits; If FeatureScience is installed: Setup hard drive specs to be in-line with KTT's Stock levels.**

## B9 Procedural Wings Fork 1.0.0
Creates custom node off of Aviation if installed.  It is in the same tier, but the cost of the next tier.  Supports CryoTanksMethalox.

## BetterSRBs 1.2.3
Moved the new parts to the SRB tech nodes. Deprecate a couple of parts unless other Jade of Maar mods detected; Undeprecate the Missing History SRB in this stage to offer a third tier of SRBs in the 1.875m category.  Replace new SRB parts with Restock if available to maintain similar aesthetic.

## BonVoyage 1.1.1
Moved module to science node.  Kept upgrades in current path.

## Bumblebee 0.5
Shuffled the tech nodes.  Generally increased the prices, particularly the sensor package to create a cost to getting a rather large sensor suite in a very small package. Added decaying RTG support if Near Future Electrical and Decaying RTG extra is installed. If BonVoyage is installed, adds a BV module to the Bumblebee core. **If Kerbalism with FeatureScience is installed: Setup probe body to have larger HDD space and 9 science slots.**

## Completely Non-Aggressive Rocketry 1.0.2
Created a new node in the tech tree between the start and other tech nodes for these.  Shrunk the size to 0.625m to match the small size of the early rockets and balanced fuel and thrust size for similar performance to original.  Ensures that these will not be OP relative to other early career rockets.  Also added an antenna, added a temp and pressure to probe body and soft deprecated the experiments.  Added an upgrade to basicRocketry to allow the rocket to reach space.

## Conformal Decals 0.2.0
Moved the decals to the Other Parts node.

## Cryogenic Engines 1.1.4
Shuffled the Tech Tree with some cost rebalancing and B9PS engine upgrades. Will convert some Stock, Making History, and ReStock+ to cryogenic engines if they were originally based off crogenic engines. If CryoTanksMethalox is installed (ie. a blank folder with that name is added to GameData), will add methalox variants to all cryogenic engines along with custom methalox plumes if RealPlume is installed.  On the potential to-do list is add PlumeParty support if RealPlume is not available, but currently methalox engines without RealPlume uses the default hydrolox plumes.

## CryoTanks 1.5.2
Created 1.875m variants of the Hydrogen Tanks based off the 2.5m parts; Adding CryoTanks replaces the default fuel tank weight upgrades with a "composite" fuel type to avoid issues with massless hydrogen tanks.  It creates enough switches to look a busy...

## Decoupler Shroud 0.7.2
Moved the part to decoupler node in the tech tree. Don't forget to add Basic Procedural Textures for further compatibility.

## Deep Space Surface Habitat Unit Pack 1.10.1
Shuffled the tech nodes.  Added Decaying RTG support; B9PS Upgrade solar support if Near Future Solar installed; Standard structural piece B9 upgrades. **If Kerbalism with FeatureRadiation is installed: Adds small radiation emitted from RTG; If FeatureScience is installed: Adds lab science group; Also adds a greenhouse consistent with description.**

## DeepFreeze 0.28.0
Changed the tech nodes, placed later in the tech tree in the colonization branch.  Increased the costs.  Added a Glykerol wedge if US2 installed (based on the hydrogen wedge)

## DMagic Orbital Science 1.4.3
Shuffled the tech nodes.  Moved the Intelligence Satelites fairly late in the tech tree and nerfed their signal strength to 10% of default value.  Even after nerfing, should not be able to get that strong of relay satelites early in the game. Reduced the transmit values of the Bio Drill Scan, Solar Particles and Bathymetry Scan. ** Keeps existing configs for Kerbalism **

## Dodo Labs 1.3.1
Shuffled the tech nodes. Lowered the cost of the fairings. Slight renaming of a couple engines.  Usual B9 Part Upgrades.

## Duna Direct 1.10.1
Shuffled the tech nodes and cost rebalanced.  Nerfed the ISP of engines.  Added a Duna Direct System Upgrade in-line with Mk3 Spaceplane Upgrade System.  ** Has Built-in Kerbalism Support **

## Extraplanetary Launchpads 6.8.2
Shuffled the tech nodes and some cost balancing as some parts were missing entry costs.  I am not very familiar with the mod, so locations were set without much balancing and yet unsure how much I will use this mod.  No upgrades were applied to containers.

## Fuji 1.1
Shuffled the tech nodes, generally a bit later.  Cost rebalancing, generally more expensive to align with Stock/Restock.  Added the standard B9 part upgrades. **If Kerbalism with FeatureScience is installed: Adds custom HDD quantities; If FeatureComfort is installed, adds a TV to the orbital station part.**

## Grounded 5.0
Shuffled the tech nodes.  Some vehicles will be placed in their own Tier 1 tech node. If installed with Rational Resources, will add RR drill and isru support; this may be removed if Jade is happy with my pull request. 

## Heat Control 0.5.2
Shuffled the tech nodes lightly.  Duplicated the surface 3.75 radiator and scaled 50% to get a 1.875 m variant.  Have to say that I am not an expert in the heat mechanics, so any recommendations will be appreciated.

## Interkosmos 0.3
Shuffled the tech nodes. Rebalanced the science values, making the gas analyzer and hydrometer experiments require the data to be returned in order for the vast majority of the science to be recovered.  Otherwise, it returns only the minimum of 10%. **If Kerbalism with FeatureScience is installed: Conforms the science experiments to align with Kerbalism science.**

## Internal RCS 1.2
Shuffled the tech nodes.  Added upgrade to Liquid Fuel engines.  Nerfed the ISP of the LF and Monopropellant engines slightly.  To Do: Add RealPlume support. 

## James Webb 1.10
Tech reshuffle.  Nerfed the main antenna.  Added solar panel upgrades if Near Future Solar installed to deployable pieces (excluded main satelite). **If Kerbalism with FeatureScience is installed: Creates a new infrared experiment and applies it to the James Webb Telescope for long-term science gains.**

## Kerbalism 3.11
** See notes above. **

## KeR-7 1.0
Reshuffled tech tree and named the engines.  Standard B9 Engine Upgrades.  To Do: Add RealPlume support, but current attempt at a config results in compilation error. 

## Kerbal Atomics 1.1.4
Added B9PS Upgrades to engines.  Lowered ISPs of some engines in dense atmospheres; "Balanced" the aerospikes and added temporary RealPlume patches to Atomic aerospike engines.  If installed, adapts the Missing History BKN engine to the same LF/LH2 multimode design as the Kerbal Atomics patch for the Stock NERV and ReStock+ Cherenkov. ** Keeps existing configs for Kerbalism **

## Kerbal Attachment System 1.7
Reshuffled Tech Nodes.

## Kerbal Engineer Redux 1.1.7.2
Moved chips to Engineering 101.  If KerbalEngineerProbes folder is created (can be blank), will add Kerbal Engineering functionality to all probes. 

## Kerbal Inventory System 1.26
Reshuffled Tech Nodes.  Added B9 upgrades to containers.

## Kerbal Planetary Base Systems 1.6.12
Reshuffled Tech Nodes.  Added B9 upgrades to parts, mostly through a unique Kerbal Planetary Base Systems Upgrade.  Also supports mod support for Extraplanetary Launchpads, Lifesupport mods, DeepFreeze, KAS, and KIS.  If SSPX is installed, SSPX experiments will replace or add in a couple of experiments to KPBS parts. ** Keeps Kerbalism configs as is.  Appear to be some bugs that need to get tackled at some point **

## Kerbal Reusability Expansion 2.8.6
Reshuffled Tech Nodes. Added B9 Upgrades to structures and SuperDraco engines.

## Knes  1.8.2
Reshuffled tech nodes.  Cost rebalance, generally costs and entry costs of engines has been increased.  In some cases, have also modified the efficiency and thrust as an attempt to differentiate the engines from Near Future and stock performance. Name changes for many solid rocket boosters and engines. If BetterSRBs is installed, it will also adapt the configs to Knes Boosters. Cargo pods have had strict ore/crystal requirements removed in favor of B9 Cargo switches if SSPX is installed to make them more versatile outside of Crystal production ISRU chain introduced in Knes.  In addition to the standard structural and engine upgrades, three "system" upgrades are added included the ATV 2.5m, STEAM 1.25m and Lifting Bodies such as the Hermes. **If Kerbalism with FeatureScience is installed: Adds custom HDD values to probes and re-entry vessels; Adds the COLOR experiment to Lab Science, but deprecates a couple of the experiments. Cosmo Cat is a sample experiment in the same vein as Mystery Goo; Adds Exercise Comfort Module to Habitation Module.**

## Kraken Science 1.0
Reshuffled tech nodes of science tech and cost rebalancing.  Placed Kraken Juice related parts in deprecated node.

## KOOSE 2.0.5
Reshuffled tech nodes. Slight cost rebalancing. **If Kerbalism with FeatureScience is installed: Adds a custom HDD profile to pod **

## kOS 1.2.1.0
Reshuffled tech nodes.

## L-Tech Scientific Industries Continued 0.5.1.6
Reshuffled tech nodes.  Rebalanced costs.  Nerfed the science multiplier boost of the Skylab. **If Kerbalism with FeatureScience is installed: Merged radiation scan with Kerbalism; setup radio waves and film camera to be compatible with science system; put the digital camera as a group experiment to take both low and high quality experiments. Removed any experiments with Skylab and stripped camera features from the parts; Added Sample Slots and HDD space to Sample Bins. Note though that the Skylab component of the mod is redundant with Feature Science as it lab science occurs over time.  I had added support in Kerbalism as it has some nicely modelled science parts from CobaltWolf which I am using in my personal playthrough with Kerbalism.**

## Luciole 1.5
Reshuffled tech nodes and cost rebalancing (generally large increases in cost and entry cost to align with stock parts). Nerfed engine ISP to align more closely with stock, exception was aerospike engine which I decreased in vacuum, but significantly increased ISP in thick atmospheres to align with other aerospike engines; added B9PS engine upgrades. If Near Future Solar is installed, adds similar B9PS upgrade system. If Modular Launch Pads is installed, the launch pad is moved to General Launch Bases. **If Kerbalism with FeatureScience is installed: Adds custom HDD values to probes and re-entry vessels; Adds the student, customer and KSC and new government experiment cubesat experiment group.**

## Making Alternate History 1.10.1
Shuffled the tech nodes and cost rebalancing.  Nerfed the descent stage as ISP too high for liquid fuel engine. Convert the engines to hydrolox/methalox if CryoEngines/CryoTanksMethalox installed (currently does not have methalox RealPlume support, not high priority). Colony modules have RTGs installed if decaying rtg patch installed with NFE.  Added a MAH System Upgrade in-line with Mk3 Spaceplane Upgrade System. **If Kerbalism with FeatureRadiation is installed: Adds small radiation emitted from RTGs; If FeatureScience is installed: Adds lab science group and custom HDD values.**

## The Martian 1.10.1.2
Shuffled the tech nodes.  Stripped out the in-built support for Methalox engines, but have added in Hydrolox and Methalox support if Cryo Engines, CryoTanksMethalox are installed, respectively. Unlike other cryo engines, these engines maintain their kerolox support as well.  Part upgrades are mostly through the Mk4 Ares System Upgrade, outside of the solar battery and engines (as usual). **If Kerbalism with FeatureScience is installed: Adds a custom HDD profile to cockpits.**

## M.O.L.E. 1.22.1 (Partial Support)
I've taken a few selective pieces out for my personal playthrough and provided some configurations for them that are consistent with the features added in this mod, but note that it also strip out the WBI Experiment and Omniconverter functionality as I am not intending to use these systems in my playthrough.  I'm providing this this as is and not really planning on providing support for this.  But if you want some great looking Restock quality extensions to the Mk1 Cockpit, check out the updated Appaloosa textures in this mod, beautiful. **If Kerbalism with FeatureScience is installed: Adds a custom HDD profile to command modules.**

## Mark IV Spaceplane System 3.1.2
Shuffled the tech nodes. Added B9PS upgrade which reduces weight by 20%. If Rational Resources is installed, it will add additional cold gasses that are available to use with RCS blocks. **If Kerbalism with FeatureScience is installed: Adds a custom HDD profile to cockpits.**

## Missing History 1.8.2
Move liquid engines to deprecate node of Restock+ installed; move a few more parts to deprecated node if Restock+ is installed; Used Restock models if available. Engines have received an B9PS upgrade two tiers above them which adds 20% Thrust, 10% Efficiency for an additional 50% Cost and 5% Mass. If installed alongside Kerbal Atomics, will adapt the same LF/LH2 multimode design as the Stock NERV and ReStock+ Cherenkov and updates the RealPlume plume to match. **If Kerbalism with FeatureScience is installed: Adds custom HDD quantities; Adds RTG to Candle Engine and Radiation Emitter to nuclear propulsion if FeatureRadiation is installed.**

## Mk-33 Beta
Shuffled the tech nodes to correspond with the Mark IV Spaceplane System.  Added custom B9PS fuel tanks along with Methalox fuel tanks.  Linear Aerospike is able to run either as a Kerolox, Hydrolox, or Methalox engine.  Custom RealPlume support is forthcoming, but will likely wait for the final development. Note, this will remove the omni-storage modules if WBI Tools is installed, will require some manual editing or custom patch (not included) to restore. If Modular Launch Pads is installed, the launch pad is moved to General Launch Bases.

## MK2 Stockalike Expansion 1.8.9.3
Shuffled tech nodes.  If installed, will move the Stock Mk2 Cockpit one tier earlier to streamlined flight.  Upgraded E.V.E.R.Y. single engine, but have not currently added RealPlume support for engines not currently supporting it.  Added cockpits and structural parts to the Mk2 Spaceplane System Upgrade. **If Kerbalism with FeatureScience is installed: Adds custom HDD quantities and Lab Group science to Lab; Lowers the radiation emitter for the Atomic Engine to be aligned with NERV.**

## MK3 Stockalike Expansion 1.5.1
Shuffled the tech nodes.  Added engine B9 Upgrades.  Structural part upgrades part of the Mk3 Spaceplane System Upgrade.  If Better SRBs installed, added support for SRBs.  Have not currently added RealPlume support to engines lacking RealPlume support. **If Kerbalism with FeatureScience is installed: Adds custom HDD quantities and Lab Group science to Lab; Adds radiation emitter to atomic parts to be aligned with the modified Mk2 Stockalike Expansion configs.**

## Modular Launch Pads 2.1 [Alpha]
Adds support for launch pads installed by other mods into General Launch Pads.

## Near Future Aeronautics 2.0.0
Repositioning of the tech nodes. Some cost rebalancing  Added B9PS Upgrades to parts. If installed, it will move the stock Whiplash one level earlier to try to avoid it being obsolete upon researching it. ** If Kerbalism with FeatureRadiation is installed, it adds emitted radiation to atomic engines.**

## Near Future Construction 1.2.3
Repositioning of the tech nodes.  Added B9PS Upgrades to parts.

## Near Future Electrical 1.1.3
Slight repositioning of the tech nodes. If Decaying RTGs installed as an optional mod, doubles the half-life to allow the RTGs to be more useful for OPM or other large scale missions.  Also adds decaying RTGs to several mods with always-on generators.

## Near Future Exploration 1.0.10
Repositioning of the tech nodes.  Will move several of the stock antennae further into the tech tree, will require using multiple antenna and reflectors to get further from Kerbin earlier in the tech tree.  Adds methane variants to fuel tanks of CryoTanksMethalox is installed. **If Kerbalism with FeatureScience is installed: Modifies custom HDD quantities.**

## Near Future Launch Vehicles 2.0.3
Added B9 Engine Upgrades; Reposition stock and restock engines if LV is installed; Added B9 Upgrade to Fuel Tanks. Cost rebalancing of engines.

## Near Future Propulsion 1.2.2
If installed, we will move the Xenon tanks to noble gas fuel system nodes in the tech tree.  I've added B9 Part Upgrades to Argon and Xenon engines.  Of particular note, as a third tier upgrade to the Argon Hall Thrusters, I have added a Argon/Xenon mix based on the ideas of Diop, Gibert, and Bouchoule (2019) and Yamasaki, Yokota, and Shimamura (2019), that suggests that mixing Xenon and Argon can improve Argon efficiency, while the latter further notes that having a longer discharge channel is able to promote argon ionization, hence higher efficiency. As the hall thrusters had a bit higher thrust relative to xenon for the size class and efficiency, I balanced the VASIMR engines to reflect that gameplay element.  I also increased the cost of Xenon in the stock if Propulsion is installed.  Currently 2.5x the original cost and have modified any Xenon tank costs to reflect that change.

## Near Future Solar 1.2.3
If installed, this will place solar a touch earlier in the tech tree and place most stock parts available a bit earlier.  I've also added B9PS support to the panels, having advanced and concentrated panels similar to NF Solar (no visual difference as seen in Nertea's version). I also spread Nertea's solar parts further through the tech tree and added concentrated part variants to those parts which excluded (Just used the Advanced textures in cases where there were no concentrated versions of the textures). The basic layout is that fixed panels came first, then deployable, but non-tracking, then deployable and tracking.  Along the nodes we have upgrades to each of these variants.

Lastly, the advanced and concentrated versions of both Nertea and stock require a tech upgrade to access.  Advanced will occur one level above the part, Concentrated two levels.

## Near Future Spacecraft 1.3.3
Rebalanced Tech Nodes; Added LF/O Upgrade to Orbital Maneuvering Engines alongside PlumeParty/RealPlume support. Renamed a couple of command pods to align with my naming convention of the stock pods. Undeprecate the Monopropellant fuel tanks as they provide some variety to the fuel tanks, they don't look as bad as Nertea thinks they look. If Rational Resources is installed, it will add additional cold gasses that are available to use with RCS blocks. ** If Kerbalism with FeatureScience is installed, it will re-balance the HDD modules.  Adds a panoramic view to the Phoebe. If FeatureRadiation is installed, it adds a radiation emitter to the RTG in the 2.5m utility pod, but "balanced" by the fact that it has a radiation sickness bay added by Kerbalism (irony?)**

## Rational Resources 1.11.0
Shuffled the tech nodes.  Placed the engines in the deprecated node as they feel disconnected from other parts and re-use existing textures.

## RealPlume 4.0.1 / PlumeParty
Where I have modified engines such as rescaling CNAR or adding LF/O in NF Spacecraft, have tried to ensure that the RealPlume is patched for compliance. Where Real Plume is not installed, will use Plume Party.  Added temporary RealPlume patches to the Kerbal Atomics aerospikes. Modified the description text to turn it green to make it easier to pinpoint the engines that have RealPlume support.

## ReStock/ReStock+ 1.2.1
Shuffled the tech nodes. Slight cost rebalancing on a couple of science parts. Engines have received an B9PS upgrade two tiers above them which adds 20% Thrust, 10% Efficiency for an additional 50% Cost and 5% increased mass. If Rational Resources is installed, it will add additional cold gasses that are available to use with RCS blocks. Note that ReStock 1.2.1 is installed in 1.9.1, you will lose the Advanced Grabbing Unit Jr as a stock version is introduced in 1.10. It will also split the single nozzle and the quadruple nozzle variants of the Poodle into two engines.  The quad nozzle will become an SL engine with higher thrust, while the single longer nozzle, named the Malshi, will be the vacuum engine. ** If Kerbalism is installed, edits HDD and Science Slots to Experiment Return Unit so the Hard Drive is not a default 500 kB generic HDD.**

## SCANsat 20.4
Shuffled the tech nodes. Slight cost rebalancing. ** Do not currently change any features in SCANsat and Kerbalism **

## Science Pancake 1.0.0
Shuffled the tech node.

## Science Param Editor 12.0
Increases science within Kerbin slightly, but generally decreases the multiplier of most other planets.  Current support for Stock, OPM, GEP, and MPE.

## Smart Docking Aid 1.0
As SAS levels are available only through upgrades, the docking aid is added to ALL probes.  It currently is not possible to make it available when probes are upgraded.  It's use thus functionally needs to be "role played".

## SmartParts 1.9.16
Shuffled the tech node.  Added 0.625m and 5m fuel breakers.

## Stockalike Mining Extension 1.1.6
Shuffled the tech nodes.  Added B9 upgrades to mass driver engines.  If installed, will move the stock ISRU's one tier later in the tech tree.

## Stockalike Station Parts Expansion Redux 1.3.6
Shuffled the tech nodes.  Added B9PS Upgrades based on the size of the parts (1.25, 2.5, and 3.75). If installed, it will move a couple of the stock parts to align with the 2.5 meter parts in SSPXr.  Also adds the Visual Observation to stock and KPBS cupolas. ** Keeps the current Kerbalism configs intact. **

## Stockish Project Orion 1.8.1
Note in this version, some textures are incorrectly specified and the restock whitelist is missing some required textures.  If this mod has not been updated from 1.8.1, you can find the solutions within its Github issues page filed by hemeac. Shuffled the tech nodes. Reduced the cost of the atomic pulse units by 80% to make it a more viable form of transportation. Cost balancing of container parts as they were incorrectly specified. Standard B9 strucutral upgrades. Medusa and Orion engine have a mass reduction upgrade (untested if making them lighter is better as the mass may make them less controllable...) ** If Kerbalism with FeatureScience is installed, it adds custom HDD modules and Lab group science to the lab; If FeatureRadiation is installed, it will add emitters to Orion and Medusa engines; If FeatureComfort is installed, it adds Radiation shower and TV slots to station components. **

## Super Heavy Boosters Historical - Nexus 2.0.200524 (Partial Support)
Mod looks super promising as it is beautifully modelled and the very definition of MOAR BOOSTERS.  Unfortunately appears unfinished.  Default RealPlume configs appears to be broken and thus most engines currently fly without plumes with RealPlume installed. This will get better support when I get around to fixing the plumes and/or get closer to it in the tech tree. Currently shuffled the tech tree nodes.  Engines have not currently received upgrades.  Cost rebalancing, mostly made things more expensive and fixed the costs of the fuel tanks.  

## TD Advanced Propulsion Systems - 0.6.200606 (Partial Support)
Like the Nexus, this mod is beautiful and promising, but the RealPlume support is currently broken, so I have just moved these later in the nuclear propulsion node and will work on supporting this in a later update.

## Universal Storage 2 1.9.1.2
Shifted nodes; Added Methalox support to fuel tanks if CryoTanksMethalox. **If Kerbalism with FeatureScience is installed: Adds a custom HDD profile to probes.**

## Ж-20 "Moroz" Spaceplane 1.3
Shuffled the technodes.  Generally made it more expensive.  Added stuctural upgrades as part of the Moroz Spaceplane System.  Comes in a bit earlier than the Mk3 and is spaceplane capable, so useful if you would like as your first spaceplane. **If Kerbalism with FeatureScience is installed: Adds a custom HDD profile to cockpits.**

## Alternate Tech Tree Mods and/or Overhauls (In no particular order, but some are quite old)
* [UnKerballed Start](https://forum.kerbalspaceprogram.com/index.php?/topic/196589-1101-unkerballed-start-v120-under-new-management-aug-28-2020/)
* [PBC Mod](https://forum.kerbalspaceprogram.com/index.php?/topic/181013-ksp-181-probes-before-crew-pbc-version-28/)
* [TETRIX and SIMPLEX Tech Tree](https://forum.kerbalspaceprogram.com/index.php?/topic/174731-19x-tetrix-techtree-25-and-simplex-techtree-116/)
* [ETT - Engineering Tech Tree](https://forum.kerbalspaceprogram.com/index.php?/topic/112627-181-ett-engineering-tech-tree-may-4-2020/)
* [Remodeled Tech Tree](https://forum.kerbalspaceprogram.com/index.php?/topic/188286-173-remodeled-tech-tree-v016/)
* [The classic: SETI, Unmanned before Manned](https://forum.kerbalspaceprogram.com/index.php?/topic/95645-13x-seti-unmanned-before-manned-patreon/)
* [Historical Progression Tech Tree](https://forum.kerbalspaceprogram.com/index.php?/topic/144295-122-historical-progression-tech-tree-v20-updated-02-22-2017/)
* [Cold War Progression](https://forum.kerbalspaceprogram.com/index.php?/topic/153744-12x-cold-war-progression-techtree-mod-for-ksp-v020-alpha/)
* [OpenTree](https://www.curseforge.com/kerbal/ksp-mods/opentree)
* [RP-1](https://forum.kerbalspaceprogram.com/index.php?/topic/190040-rp-1-realistic-progression-one-v141-for-ksp-181/)
* [Less Real Than Real(ism)](https://forum.kerbalspaceprogram.com/index.php?/topic/189978-181-less-real-than-realism-rp-1-with-less-r-v12/)

## Changelog
* 0.8.0 (8 October 2020): Kerbalism Support - Full notes see variouus Github Issues in 1.0 milestone; Moved food and lifesupport wedge in US2 to recyling node; Removed changes to deployed science points in BreakingGround patch; Moved Survey Station to later tier in Extraplanetary Launchpads; Moved Large Science Return Bin from LTech to later tier; Moved Sciencebox from ReStockPlus to later tier; Confirmed support for LTech 5.1.7 and Conformal Decals 0.2.1; Readded a KiwiDeprecate pass to force parts to deprecated node; Fixed typo that prevented PlumeParty vents moving to otherParts node; Added upgrade to Fuji orbital station part; Added missing structural upgrade to Extraplanetary Launchpads station section; Added late pass to extra variable clean-up.
* 0.7.1 (2 October 2020): Verified ReStock/ReStock+ 1.2.1 is functional within 1.9.1 and allocated new parts; Returned Poodle to HeavyRocketry; Split ReStock/1.10 Poodle Variant to two parts, ASL Lifter and Vacuum Engine, if ReStock is installed with new RealPlume support; moved radial attachment points (Stock/ReStock+) in the tech tree and added parts upgrades.
* 0.7.0 (2 October 2020): Added Extraplanetary Launchpads, Grounded, Kerbal Planetary Base Systems, and Stockalike Mining Extension Support; Checked balance of science available versus science requirements across tech tiers. Increased telemetry science base to 2 and made it more biome specific.  Support for L-Tech moved to 0.5.1.6; Moved M-2 Cryogenic Gas Separator later in tech tree for Near Future propulsion; Added new tech node for some Grounded parts; Add Visual Observation experiment from SSPX to KPBS cupola; Added Noble Gas/Lithim Fuel System Branch to Template; Fixed typo in description of some upgraded parts in SSPX; Fixed duplicate upgrades for Stock xenon tanks if Near Future Propulsion is installed; Add support for cold gas RCS thrusters in Rational Resources update; Workaround for Smart Docking Aid.
* 0.6.1 (29 September 2020): Added Rational Resources support and partial Nexus and TDAPS support; added a deprecated node and placed a couple of parts from Missing History, BetterSRBs, Kraken Juice and Rational Resources to deprecated folder; Support for Scansat increased to Scansat 20.4; Moved Plume Party Vapor Vents to Other Parts node; Made telemetry science report biome specific for flying situations.
* 0.6.0 (28 September 2020): Added Orion Support; Renamed tech tree icons and configs to KTT from CTT to reflect that it isn't CTT; Rebalanced the science unlock costs in the tech tree; Added "Even Later" structural upgrade template to Stock Structural Upgrade config for easier reference.
* 0.5.1 (27 September 2020): Added BonVoyage, Decoupler Shroud, Dodo Labs, kOS, SmartParts, and The Martian for KSP Support; Lowered entry cost of Calypso engine in Knes; Fixed tech node for Multi-Role Kapsule DM in Knes; Added parachute upgrade support for KOOSE, Bumblebee, and Fuji; Added B9 Plural to Cryotanks patch (Fuel Mixes, copied from The Martian for KSP by bcink); Moved cubesats from Luciole to Unkerballed Tech and increased cost.
* 0.5.0 (27 September 2020): Added Knes Support; Added Custom Barn Kit and Hide Empty Node Support (code copied from Unkerballed Start 1.2.0 by SpinkAkron/theonegalen); Modified science values for SSPX; Added SSPX visual observation science experiments to stock cupola and SSPX 2.5m observation piece; Fixed placement of docking port in Luciole; Tweaked Mk3 Expansion SRBs thrust to be consistent with Better SRBs; Lowered entry cost of Otter in NFLV; Reduced the entry costs of parts from CNAR; Fixed bug that broke part upgrade system if not all mods with part upgrades available were not available; Fixed NEEDS and AFTER in KIS; Fixed Node placement for Atlas SRB when BetterSRBs installed; Moved a couple of stock antenna later in the tech tree if NF Exploration is installed; Added B9 Plural to Spaceworthiness switch.
* 0.4.8 (22 September 2020): Added MK3 Stockalike Expansion and Kerbal Reusability Expansion Support; Moved RoveMax Model XL3 one tier earlier in tech tree; Moved some AirplanePlus parts a touch earlier in the tech tree; Moved the decoupling and docking ports for Mk2 Stockalike Expansion
* 0.4.7 (20 September 2020): Added MK2 Stockalike Expansion Support; Slight tweak of Moroz; Fixed bug that Mk2-3 LF/O tanks had access to multiple upgrades when CryoTanks installed; Moved MkIV crew cabin to same branch as cockpit.
* 0.4.6 (19 September 2020): Added Ж-20 "Moroz" Spaceplane, Fuji, Internal RCS, KeR-7, DeepFreeze, KIS, KAS Support; Moved small Restock+ RCS thrusters earlier in the tech tree; Added Other Parts node in the tech tree; Updated the template.
* 0.4.5 (17 September 2020): Added AirplanePlus, Interkosmos, and Kraken Science Support; Lowered data scale of early science; Added 20 EC to probes to help balance lack of start battery; Lowered cost of radio experiments in LTech; Moved Circular Intake earlier; Moved the L-02 Beehive LaunchPad (Luciole) support for modular launch pads.
* 0.4.4 (16 September 2020): Added James Webb, Deep Space Surface Habitat Unit, Making Alternate History, and Duna Direct Support; Increased the additional mass for upgraded engines to 10% from 5%; Fixed Typos in Mk1-3 Part Upgrade Text
* 0.4.3 (15 September 2020): Added Luciole and Modular Launch Pads Support; Changed the color of RealPlume engine support indicator in part descriptions; fixed typo in 0.625 rescaled monoprop parts; Shifted KOOSE parts to re-entry module branch; Stock solar patches for Near Future Solar in an earlier pass.
* 0.4.2 (14 September 2020): Added Universal Storage 2, B9 Procedural Wings and Kerbal Engineering Support; Added US2 Support for DMagic Orbital Science; Slight tweak of ReStock+ nodes
* 0.4.1 (13 September 2020): Added Bumblebee Support; Science Pancake Support; KOOSE Support; slight tweak of tech tree.
* 0.4.0 (13 September 2020): Added Science Param Editor Support; Revamped science system; Nerfed L-Tech Skylab station multiplier; removed some extra scanning capability from DMagic Orbital Science parts
* 0.3.8 (12 September 2020): Added DMagic Orbital Science Support; Renamed Scanning Tech node title to Science Tech (which is what the underlying node is called called)
* 0.3.7 (12 September 2020): Added Stockalike Station Parts Expansion Redux Support; Added framework for antenna upgrade (not currently functional)
* 0.3.6 (10 September 2020): Added Near Future Exploration Support; Added additional EC to Stayputnik; Slight change in stock antenna tech nodes; Fixed typo in probe upgrades so it is researchable; Fixed overly general rcsblock patch in NF Spacecraft.
* 0.3.5 (9 September 2020): Added Near Future Aeronautics Support; Removed the Needs CommunityTechTree from some parts (felt redundant).  Moved Experimental Aircraft Engines to alternative propulsion branch; Added new node in aeronautics branch, one in flight systems, one in alternate propulsion.
* 0.3.4 (8 September 2020): Added Mk-33 Support; Moved the R.A.P.I.E.R engine to alternate propulsion branch; Added a new node A Bit More Exotic Propulsion; Added Plurals to B9PS Switches
* 0.3.3 (7 September 2020): Added Cryogenic Engines Support
* 0.3.2 (3 September 2020): Added Kerbal Atomics and CryoTanks Support; Modifies tank upgrades depending on CryoTanks installation; Changed color scheme for Engine Switches based on fuel types; Added new tier on Nuclear Propulsion for Kerbal Atomics Upgrades
* 0.3.1 (30 August 2020): Added Near Future Construction Support; Added upgrades to adapters, docking ports, etc.; Added a general tech node template.
* 0.3.0 (30 August 2020): Added upgrades to jet engines; Added upgrades to structural parts; moved some plane parts earlier, including Mk1 Cockpit to start. Color coded upgrades in B9PS; Lowered the cost of several structural parts, they relatively expensive relative to engines.
* 0.2.3 (26 August 2020): Added Near Future Launch Vehicles Support with Engine Upgrades; Added Fuel Tank Upgrade to Stock/Restock/NFLV; Added Structural Upgrades to Mk1,Mk2,Mk3 Spaceplane Systems; Added some rescaled parts such as 3.75m and 5m SAS modules; Minor Rebalancing.
* 0.2.2 (24 August 2020): Added Heat Control Support
* 0.2.1 (24 August 2020): Added B9PS Upgrades to Nuclear Engines in Stock/Restock/Missing History; Added 5% increased mass to upgraded engines.
* 0.2.0 (23 August 2020): Added B9PS Upgrades to Engines in Stock/Restock+; Moved SSME earlier in tree; light rebalancing.
* 0.1.11 (23 August 2020): Added Near Future Spacecraft support; Decaying RTG patch to Near Future Electrical; Added node for the special propulsion line; renamed command pods; Noted the license restrictions of supported mods.
* 0.1.10 (21 August 2020): Added Near Future Electrical support; Minor changes to Near Future Propulsion
* 0.1.9 (21 August 2020): Added Near Future Propulsion Support; Added nodes to Tech Tree for Ion Propulsion Fuel Systems Line; Balanced Xenon costs
* 0.1.8 (16 August 2020): Added SAS upgrades to probe parts, removed default SAS levels for all stock/modded probes.
* 0.1.7: Slight rebalance of solar parts; Added Near Future Solar support; Added Omega Solar Tech node in tree.
* 0.1.6: Added LTech Beta and SCANsat support; rebalanced stock resource scanners compared to SCANsat
* 0.1.5: Added a couple of nodes to support the command module strand.
* 0.1.4: Added Nuclear Power & Propulsion
* 0.1.3: Added CNAR support.
* 0.1.2: Added BetterSRBs support, Added couple of parts.  Began adding support for optional mod, KiwiDeprecated which soft deprecates parts on the basis of overlap of Nertea's mods if they don't fit in a stockalike style.
* 0.1.1: Added MkIV Spaceplane Support, Added part upgrades to Mk1-3 crewed parts to discourage those being used for the first crewed space missions, cost balancing for engines and SRBs.

## Disclaimer
This mod has not been endorsed by _Zee, Spink Akron, Nertea or any other mod/part creator referenced in the config files.  All errors are my own.  Please do not hassle mod authors if these configurations cause conflicts with other mods.

## License
Copyright (c) 2020, Trevor Kollmann

Kiwi Aeronautics is copyrighted by Trevor Kollmann. All rights reserved. Please rename any fork of this project to exclude "Kiwi Aeronautics" if you plan to redistribute on a Kerbal Space Program related website.

Configuration Files are distributed under a MIT License.

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

### Additional Licenses and attributions:
Core tech tree configuration files are based on files originally created by _Zee and redistributed under the same MIT license. Additional config files are likely to be influenced by their respective mod creators and the respective licenses of the config files are noted within the mod files within each subfolder in GameData\KiwiAerospace\TechTree\Configurations\Mods.  While some mods have no derivative requirements, I have not bundled code from those mods.  Any mod author who would like me to remove a configuration for their mod, please get in touch irrespective of your mods license requirements.

Some icons from Community Tech Tree by Nertea were modified bundled in this mod.  They are licensed under Creative Commons Attribution-NonCommercial 4.0.

Additional icons used within the tech tree were modified based on icons sourced from flaticon.com and thenounproject.com.  I purchased these as a premium member of these services.  Please check the licensing terms of these websites prior to any redistribution to ensure you remain in compliance with their terms.
