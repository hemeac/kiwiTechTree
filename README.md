# Kiwi's Tech Tree Overhaul

## Version 0.4.7; 20 September 2020; Currently tested in KSP 1.9.1

![Kiwi Tech Tree Overhaul](https://i.imgur.com/1MWP2O1.png)

A "Probes/Planes Before Crew" type overhaul of the Tech Tree inspired byZee's [PBC Mod](https://forum.kerbalspaceprogram.com/index.php?/topic/181013-ksp-181-probes-before-crew-pbc-version-28/) and Spink Akron/theonegalen's [UnKerballed Start](https://forum.kerbalspaceprogram.com/index.php?/topic/196589-1101-unkerballed-start-v120-under-new-management-aug-28-2020/). It builds on that concept by providing an upgrade path (via B9PS or the stock upgrade system) for many of the parts, such as decreased dry mass, increased thrust/efficiency, or improved SAS levels.  I attempt to (hopefully) balance the improvements by having the upgrades come with an increased cost and come later in the tech tree.  This should leave a choice between getting upgraded tech at a slightly lower cost first.

## Dependencies (Not Included)
* [Community Tech Tree](https://forum.kerbalspaceprogram.com/index.php?/topic/90530-110x-community-tech-tree-august-1-2020/)
* [B9 Part Switch](https://forum.kerbalspaceprogram.com/index.php?/topic/140541-1101-b9partswitch-v2170-july-29/)
* [Module Manager](https://forum.kerbalspaceprogram.com/index.php?/topic/50533-18x-110x-module-manager-414-july-7th-2020-locked-inside-edition/)

## Strongly Recommended
* [Science Param Editor](https://github.com/DMagic1/Science-Param-Loader)
  * Support for Stock; OPM; MPE; GEP

## Recommended
* [PlumeParty](https://github.com/JadeOfMaar/PlumeParty) (Alternative to RealPlume)

## Objective

This Tech Tree overhaul, like its predecessors, revolves around the premise that probes should come before crewed space missions.  While I really enjoyed both aforementioned mods, I found it took a bit too long to see my kerbals in game and I could could progress through most of the tech tree before leaving Kerbin's sphere of influence.  While it is a Tech Tree mod at it's core, I have spent a fair bit of time trying to align the stock parts to have similar functionality available with Nertea's NF Suite (if relevant mods are installed).  In addition, I have tried to implement optional mods in Near Future using B9PS functionality, thus removing the restriction of having to choose one or the other within the gameplay environment. While I have tried to keep changes relatively minimial, if you like to play with new parts as the modder intended, this is probably not the right tech tree mod for you.

The rebalance is an attempt to make my tech choices a bit more meaningful and allow my kerbins to spend some time testing jets in Kerbin's atmosphere earlier in the career prior to launching in space.  I have added another 69+ tech nodes across the tree, but have tried to leave the general layout of the tree largely intact.  The major changes are adding a separate branch for solid rocket boosters and if you have mods which have cryogenic engines, this will move them to a different branch from the Liquid Fuel Branch. I have also tried to separate out science more explicitly within the tech tree. While I have shifted some of the nodes around, I have not removed any, thus leaving some compatibility with any mod that I have not explictly supported.

Like UnKerballed Start, you start with 0.625 meter engines and tanks and work progressively larger.  To try to limit early crewed missions using spaceplane parts, I have nerfed the skin temperature of the spaceplanes, but provide higher skin temperatures to the spaceplanes once they reach the High Altitude tech node (same tier as the Mk3 cockpit). I used Zee's PBC mod to start the mod to learn MM, but the design has significantly diverged, so you should expect a different gameplay experience. If you are looking for just a tech tree revamp, UnKerballed Start is back in active development.

I calibrated the nodes around stock, expansion packs, Restock/Restock+ and Missing History.  The name of the nodes do not fully indicate the type of technology within the node, but rather the type of technologies that you should expect to find there.  Some nodes do not fully represent their current use (ie. miniaturization), but have decided at this point to not rename them. Given the number of nodes, you will benefit by having several parts mods.

In some cases, I have added rescaled parts, but have attempted to indicate when and from what mod I have rescaled the parts within the description.  In some cases such as Missing History, I will use the Restock texture when available for consistency in the visual style.  

I have asked Nertea for permission in regards to using Restock/NF models for resizing (if they are installed) and have tried to indicate in the part descriptions which parts I have added in order to avoid confusion. However, please do not take this as Nertea's endorsement of the mod.

## General Gameplay Changes
* Probe behavior changes in two ways:  First is I have kept PBC's Telemetry Report.  It is a nice and easy way to get some early science which is obviously needed given the additional nodes.  I also remove ALL probes SAS levels by default and add in the functionality through the stock upgrade system which follows the Flight Control tech path. 
* Renamed the command pods to reflect the relative node in which they appear.
* Cockpit heat resistance has been reduced until High-Altitude Flight which is added through a B9PS upgrade.
* Rocket Engines have received an B9PS upgrade two tiers above them which adds 20% Thrust, 10% Efficiency for an additional 50% Cost and 5% Mass.
* Jet Engines have received a B9PS upgrade two tiers later which adds about 20% thrust.  The R.A.P.I.E.R. gets moved into the "unique" propulsion branch rather than part of the jet engines.
* Command Pods, Fuel Tanks and the Mk1-3 Spaceplane Systems, and other structural parts have B9 upgrade systems implemented that reduce their dry weight by 20% for an additional 50% cost.
* Revamped Science points; Set the scienceCap to the same level as the base level eliminating need to repeat experiments.  Reduced the level of transmit science of Mystery Goo, Material Lab to 14% of cap.  Increased the transmission to 100% for all other stock science experiments.

## Current Supported Mods (see details below for general changes):
* Airplane Plus 26.5
* B9 Procedural Wings Fork 1.0.0
* BetterSRBs 1.2.3
* Bumblebee 0.5
* Completely Non-Aggressive Rocketry 1.0.2
* Cryogenic Engines 1.1.4
* CryoTanks 1.5.2
* Deep Space Surface Habitat Unit Pack 1.10.1
* DeepFreeze 0.28.0
* DMagic Orbital Science 1.4.3
* Duna Direct 1.10.1
* Fuji 1.1
* Heat Control 0.5.2
* Interkosmos 0.3
* Internal RCS 1.2
* James Webb 1.10
* KeR-7 1.0
* Kerbal Atomics 1.1.4
* Kerbal Attachment System 1.7
* Kerbal Engineer Redux 1.1.7.2
* Kerbal Inventory System 1.26
* KOOSE 2.0.5
* Kraken Science 1.0
* LTech 0.5.1.5 [Beta]
* Luciole 1.5
* Making Alternate History 1.10.1
* M.O.L.E. (Very Limited Support) 1.22.1
* Mark IV Spaceplane System 3.1.2
* Missing History 1.8.2
* Mk-33 [Beta; 8 September 2020]
* Mk2 Stockalike Expansion 1.8.9.3
* Modular Launch Pads 2.1 [Alpha]
* Near Future Aeronautics 2.0.0
* Near Future Construction 1.2.3
* Near Future Electrical 1.1.3
* Near Future Exploration 1.0.10
* Near Future Launch Vehicles 2.0.3
* Near Future Propulsion 1.2.2
* Near Future Solar 1.2.3
* Near Future Spacecraft 1.3.3
* RealPlume-Stock 4.0.1
* Restock/Restock+ 1.1.2
* SCANsat 20.2
* Science Pancake 1.0.0
* Science Param Editor 12.0
* Stockalike Station Parts Expansion Redux 1.3.6
* Universal Storage 2 1.9.1.2
* Ж-20 "Moroz" Spaceplane 1.3

## Plan of Attack for Mods (In no particular order):
* Provenance Aerospace (after part revamp)
* The Martian (after part revamp)
* Stockalike Mk1 Open cockpit (after part revamp)
* Mk3 Stockalike Expansion
* Rational Resources
* USI
* MKS
* Knes
* Dodo Labs
* Stockish Project Orion
* Stockalike Mining Expansion
* Lander Can Mk12
* Tundra Exploration
* Picoport Shielded
* Waterfall (Will explore as development continues)

## Great Mods, but not likely to be added by me (Happy to accept help):
* Kerbal Planetary Base Systems
  * It is a large mod and will likely stick to MKS, but if there is enough interest, will consider.
* BDB and Tantares
  * (Scale and Scope are huge and hard to break down like Near Future). As they also have a strong historical basis, I feel they are out of scope for this mod and probably deserve someone who has a deeper appreciation for the history of spaceflight than I do.  However, if anyone would like to tackle this, I am definitely open for it.  As for BDB though, I would ask that you work towards the 1.7 development build.
* Kerbalism
  * (Not sure I will try going this "real", yet the Science Only configuration looks interesting and I will likely explore)
* KSP Interstellar Extended
  * This a large mod that does a lot of things.  I may look to see how hard it is to patch the tiers together, but that won't be in the near future.
* SpaceY
  * There are unique parts, but overlaps with Near Future and textures that aren't up to 2020 standards, so not something I need in game, but will add support if anyone provides a patch.
* OPT
  * Not likely to add in my personal game, but this could be added if there is enough interest.
* SDHI Service Module System
  * It disables the Restock Mk1-3 cockpit model and I am not interested in having both stock and Restock within my game, although this is a beautifully executed concept. If someone provides a patch, will add.

## No Planned Support
* Firespitter Parts
  * The B9 system does not appear to be compatible with the switcher system in Firespitter, so will not upgrade any parts that use that system and will avoid any parts mod that exclusively uses it for engines. AirplanePlus was the exception as most motors relied on stock mechanics for the engines.
  
## Airplane Plus 26.5
Reshuffled tech nodes, generally provide parts one or two tiers earlier than the default.  Added space worthiness upgrade to cockpits.  Added engine upgrades to engines with the exceptions of the rotors not using ModuleEngines as they cannot be modified by B9PS. 

## B9 Procedural Wings Fork 1.0.0
Creates custom node off of Aviation if installed.  It is in the same tier, but the cost of the next tier.  Supports CryoTanksMethalox.

## BetterSRBs 1.2.3
Moved the new parts to the SRB tech nodes. Deprecate a couple of parts unless other Jade of Maar mods detected; Undeprecate the Missing History SRB in this stage to offer a third tier of SRBs in the 1.875m category.  Replace new SRB parts with Restock if available to maintain similar aesthetic.

## Bumblebee 0.5
Shuffled the tech nodes.  Generally increased the prices, particularly the sensor package to create a cost to getting a rather large sensor suite in a very small package. Added decaying RTG support if Near Future Electrical and Decaying RTG extra is installed.

## Completely Non-Aggressive Rocketry 1.0.2
Created a new node in the tech tree between the start and other tech nodes for these.  Shrunk the size to 0.625m to match the small size of the early rockets and balanced fuel and thrust size for similar performance to original.  Ensures that these will not be OP relative to other early career rockets.  Also added an antenna, added a temp and pressure to probe body and soft deprecated the experiments.  Added an upgrade to basicRocketry to allow the rocket to reach space

## Cryogenic Engines 1.1.4
Shuffled the Tech Tree with some cost rebalancing and B9PS engine upgrades. Will convert some Stock, Making History, and ReStock+ to cryogenic engines if they were originally based off crogenic engines. If CryoTanksMethalox is installed (ie. a blank folder with that name is added to GameData), will add methalox variants to all cryogenic engines along with custom methalox plumes if RealPlume is installed.  On the potential to-do list is add PlumeParty support if RealPlume is not available, but currently methalox engines without RealPlume uses the default hydrolox plumes.

## CryoTanks 1.5.2
Created 1.875m variants of the Hydrogen Tanks based off the 2.5m parts; Adding CryoTanks replaces the default fuel tank weight upgrades with a "composite" fuel type to avoid issues with massless hydrogen tanks.  It creates enough switches to look a bit busy...

## Deep Space Surface Habitat Unit Pack 1.10.1
Shuffled the tech nodes.  Added Decaying RTG support; B9PS Upgrade solar support if Near Future Solar installed; Standard structural piece B9 upgrades.

## DeepFreeze 0.28.0
Changed the tech nodes, placed later in the tech tree in the colonization branch.  Increased the costs.  Added a Glykerol wedge if US2 installed (based on the hydrogen wedge)

## DMagic Orbital Science 1.4.3
Shuffled the tech nodes.  Moved the Intelligence Satelites fairly late in the tech tree and nerfed their signal strength to 10% of default value.  Even after nerfing, should not be able to get that strong of relay satelites early in the game. Reduced the transmit values of the Bio Drill Scan, Solar Particles and Bathymetry Scan.

## Duna Direct 1.10.1
Shuffled the tech nodes and cost rebalanced.  Nerfed the ISP of engines.  Added a Duna Direct System Upgrade in-line with Mk3 Spaceplane Upgrade System.

## Fuji 1.1
Shuffled the tech nodes, generally a bit later.  Cost rebalancing, generally more expensive to align with Stock/Restock.  Added the standard B9 part upgrades.

## Heat Control 0.5.2
Shuffled the tech nodes lightly.  Duplicated the surface 3.75 radiator and scaled 50% to get a 1.875 m variant.  Have to say that I am not an expert in the heat mechanics, so any recommendations will be appreciated.

## Interkosmos 0.3
Shuffled the tech nodes. Rebalanced the science values, making the gas analyzer and hydrometer experiments require the data to be returned in order for the vast majority of the science to be recovered.  Otherwise, it returns only the minimum of 10%.

## Internal RCS 1.2
Shuffled the tech nodes.  Added upgrade to Liquid Fuel engines.  Nerfed the ISP of the LF and Monopropellant engines slightly.  To Do: Add RealPlume support. 

## James Webb 1.10
Tech reshuffle.  Nerfed the main antenna.  Added solar panel upgrades if Near Future Solar installed to deployable pieces (excluded main satelite).

## KeR-7 1.0
Reshuffled tech tree and named the engines.  Standard B9 Engine Upgrades.  To Do: Add RealPlume support, but current attempt at a config results in compilation error. 

## Kerbal Atomics 1.1.4
Added B9PS Upgrades to engines.  Lowered ISPs of some engines in dense atmospheres; "Balanced" the aerospikes and added temporary RealPlume patches to Atomic aerospike engines.  If installed, adapts the Missing History BKN engine to the same LF/LH2 multimode design as the Kerbal Atomics patch for the Stock NERV and ReStock+ Cherenkov.

## Kerbal Attachment System 1.7
Reshuffled Tech Nodes.

## Kerbal Engineer Redux 1.1.7.2
Moved chips to Engineering 101.  If KerbalEngineerProbes folder is created (can be blank), will add Kerbal Engineering functionality to all probes. 

## Kerbal Inventory System 1.26
Reshuffled Tech Nodes.  Added B9 upgrades to containers.

## Kraken Science 1.0
Reshuffled tech nodes of science tech and cost rebalancing.  Placed Kraken Juice related parts in a far future tier and significantly increased costs.

## KOOSE 2.0.5
Reshuffled tech nodes. Slight cost rebalancing.

## L-Tech Scientific Industries Continued 0.5.1.5
Reshuffled tech nodes.  Rebalanced costs.  Nerfed the science multiplier boost of the Skylab.

## Luciole 1.5
Reshuffled tech nodes and cost rebalancing (generally large increases in cost and entry cost to align with stock parts). Nerfed engine ISP to align more closely with stock, exception was aerospike engine which I decreased in vacuum, but significantly increased ISP in thick atmospheres to align with other aerospike engines; added B9PS engine upgrades. If Near Future Solar is installed, adds similar B9PS upgrade system. If Modular Launch Pads is installed, the launch pad is moved to General Launch Bases.

## Making Alternate History 1.10.1
Shuffled the tech nodes and cost rebalancing.  Nerfed the descent stage as ISP too high for liquid fuel engine. Convert the engines to hydrolox/methalox if CryoEngines/CryoTanksMethalox installed (currently does not have methalox RealPlume support, not high priority). Colony modules have RTGs installed if decaying rtg patch installed with NFE.  Added a MAH System Upgrade in-line with Mk3 Spaceplane Upgrade System.

## M.O.L.E. 1.22.1
I've taken a few selective pieces out for my personal playthrough and provided some configurations for them that are consistent with the features added in this mod, but note that it also strip out the WBI Experiment and Omniconverter functionality as I am not intending to use these systems in my playthrough.  I'm providing this this as is and not really planning on providing support for this.  But if you want some great looking Restock quality extensions to the Mk1 Cockpit, check out the updated Appaloosa textures in this mod, beautiful.

## Mark IV Spaceplane System 3.1.2
Shuffled the tech nodes. Added B9PS upgrade which reduces weight by 20%

## Missing History 1.8.2
Soft-deprecate liquid engines of Restock+ installed; hide a few more parts if Restock+ is installed; Used Restock models if available. Engines have received an B9PS upgrade two tiers above them which adds 20% Thrust, 10% Efficiency for an additional 50% Cost and 5% Mass. If installed alongside Kerbal Atomics, will adapt the same LF/LH2 multimode design as the Stock NERV and ReStock+ Cherenkov and updates the RealPlume plume to match.

## Mk-33 Beta
Shuffled the tech nodes to correspond with the Mark IV Spaceplane System.  Added custom B9PS fuel tanks along with Methalox fuel tanks.  Linear Aerospike is able to run either as a Kerolox, Hydrolox, or Methalox engine.  Custom RealPlume support is forthcoming, but will likely wait for the final development. Note, this will remove the omni-storage modules if WBI Tools is installed, will require some manual editing or custom patch (not included) to restore. If Modular Launch Pads is installed, the launch pad is moved to General Launch Bases.

## MK2 Stockalike Expansion 1.8.9.3
Shuffled tech nodes.  If installed, will move the Stock Mk2 Cockpit one tier earlier to streamlined flight.  Upgraded E.V.E.R.Y. single engine, but have not currently added any missing RealPlume planes.  Added cockpits and structural parts to the Mk2 Spaceplane System Upgrade.

## Modular Launch Pads 2.1 [Alpha]
Adds support for launch pads installed by other mods into General Launch Pads.

## Near Future Aeronautics 2.0.0
Repositioning of the tech nodes. Some cost rebalancing  Added B9PS Upgrades to parts. If installed, it will move the stock Whiplash one level earlier to try to avoid it being obsolete upon researching it.

## Near Future Construction 1.2.3
Repositioning of the tech nodes.  Added B9PS Upgrades to parts.

## Near Future Electrical 1.1.3
Slight repositioning of the tech nodes. If Decaying RTGs installed as an optional mod, doubles the half-life to allow the RTGs to be more useful for OPM or other large scale missions.

## Near Future Exploration 1.0.10
Repositioning of the tech nodes.  Will move several of the stock antennae further into the tech tree, will require using multiple antenna and reflectors to get further from Kerbin earlier in the tech tree.  Adds methane variants to fuel tanks of CryoTanksMethalox is installed.

## Near Future Launch Vehicles 2.0.3
Added B9 Engine Upgrades; Reposition stock and restock engines if LV is installed; Added B9 Upgrade to Fuel Tanks. Cost rebalancing of engines.

## Near Future Propulsion 1.2.2
If installed, we will move the Xenon tanks to noble gas fuel system nodes in the tech tree.  I've added B9 Part Upgrades to Argon and Xenon engines.  Of particular note, as a third tier upgrade to the Argon Hall Thrusters, I have added a Argon/Xenon mix based on the ideas of Diop, Gibert, and Bouchoule (2019) and Yamasaki, Yokota, and Shimamura (2019), that suggests that mixing Xenon and Argon can improve Argon efficiency, while the latter further notes that having a longer discharge channel is able to promote argon ionization, hence higher efficiency. As the hall thrusters had a bit higher thrust relative to xenon for the size class and efficiency, I balanced the VASIMR engines to reflect that gameplay element.  I also increased the cost of Xenon in the stock if Propulsion is installed.  Currently 2.5x the original cost and have modified any Xenon tank costs to reflect that change.

## Near Future Solar 1.2.3
If installed, this will place solar a touch earlier in the tech tree and place most stock parts available a bit earlier.  I've also added B9PS support to the panels, having advanced and concentrated panels similar to NF Solar (no visual difference as seen in Nertea's version). I also spread Nertea's solar parts further through the tech tree and added concentrated part variants to those parts which excluded (Just used the Advanced textures in cases where there were no concentrated versions of the textures). The basic layout is that fixed panels came first, then deployable, but non-tracking, then deployable and tracking.  Along the nodes we have upgrades to each of these variants.

Lastly, the advanced and concentrated versions of both Nertea and stock require a tech upgrade to access.  Advanced will occur one level above the part, Concentrated two levels.

## Near Future Spacecraft 1.3.3
Rebalanced Tech Nodes; Added LF/O Upgrade to Orbital Maneuvering Engines alongside PlumeParty/RealPlume support. Renamed a couple of command pods to align with my naming convention of the stock pods. Undeprecate the Monopropellant fuel tanks as they provide some variety to the fuel tanks, they don't look as bad as Nertea thinks they look.

## RealPlume 4.0.1 / PlumeParty
Where I have modified engines such as rescaling CNAR or adding LF/O in NF Spacecraft, have tried to ensure that the RealPlume is patched for compliance. Where Real Plume is not installed, will use Plume Party.  Added temporary RealPlume patches to the Kerbal Atomics aerospikes. Modified the description text to turn it green to make it easier to pinpoint the engines that have RealPlume support.

## Restock/Restock+ 1.1.2
Shuffled the tech nodes. Slight cost rebalancing on a couple of science parts. Engines have received an B9PS upgrade two tiers above them which adds 20% Thrust, 10% Efficiency for an additional 50% Cost and 5% increased mass.

## SCANsat 20.2
Shuffled the tech nodes. Slight cost rebalancing.

## Science Pancake 1.0.0
Shuffled the tech node.

## Science Param Editor 12.0
Increases science within Kerbin slightly, but generally decreases the multiplier of most other planets.  Current support for Stock, OPM, GEP, and MPE.

## Stockalike Station Parts Expansion Redux 1.3.6
Shuffled the tech nodes.  Added B9PS Upgrades based on the size of the parts (1.25, 2.5, and 3.75). If installed, it will move a couple of the stock parts to align with the 2.5 meter parts in SSPXr

## Universal Storage 2 1.9.1.2
Shifted nodes; Added Methalox support to fuel tanks if CryoTanksMethalox.

## Ж-20 "Moroz" Spaceplane 1.3
Shuffled the technodes.  Generally made it more expensive.  Added stuctural upgrades as part of the Moroz Spaceplane System.  Comes in a bit earlier than the Mk3 and is spaceplane capable, so useful if you would like as your first spaceplane.

## Alternate Tech Tree Mods (In no particular order)
* [UnKerballed Start](https://forum.kerbalspaceprogram.com/index.php?/topic/181932-18x-unkerballed-start-v110-updated-oct-27-2019/)
* [PBC Mod](https://forum.kerbalspaceprogram.com/index.php?/topic/181013-ksp-181-probes-before-crew-pbc-version-28/)
* [TETRIX and SIMPLEX Tech Tree](https://forum.kerbalspaceprogram.com/index.php?/topic/174731-19x-tetrix-techtree-25-and-simplex-techtree-116/)
* [ETT - Engineering Tech Tree](https://forum.kerbalspaceprogram.com/index.php?/topic/112627-181-ett-engineering-tech-tree-may-4-2020/)
* [Remodeled Tech Tree](https://forum.kerbalspaceprogram.com/index.php?/topic/188286-173-remodeled-tech-tree-v016/)
* [The classic: SETI, Unmanned before Manned](https://forum.kerbalspaceprogram.com/index.php?/topic/95645-13x-seti-unmanned-before-manned-patreon/)
* [Historical Progression Tech Tree](https://forum.kerbalspaceprogram.com/index.php?/topic/144295-122-historical-progression-tech-tree-v20-updated-02-22-2017/)


## Changelog
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

## Known/Likely Issues
* Couple of upgrade lines in the Tech Tree disappear when viewing them near the edges of the screen.
* Many of the extras for the Near Future Suite that change the behavior of engines, etc. will most likely not lead to expected results if installed.  Check each mod above as some behaviors were adopted directly.
* Kerbal Research & Development's upgrade system appears to be incompatible with the upgrades that I have implemented.  I would expect bad things to happen.
* Realistic Power Draw modifies the science modules and given the ordering of the pass in MM, this will likely break the changes to the science system I am doing.  If you use this and want me to make a patch, get in touch.


## Disclaimer

This mod has not been endorsed by _Zee, Spink Akron, Nertea or any other mod/part creator referenced in the config files.  All errors are my own.  Please do not hassle mod authors if these configurations cause conflicts with other mods.

## License
Copyright (c) 2020, Trevor Kollmann

Kiwi Aeronautics is copyrighted by Trevor Kollmann. All rights reserved.

Configuration Files are destributed under a MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

### Additional Licenses and attributions:
Some tech tree configuration files are based on files originally created by _Zee and redistributed under the same MIT license. Additional config files are likely to be influenced by their respective mod creators and the respective licenses of the config files are noted within the mod files within each subfolder in GameData\KiwiAerospace\TechTree\Configurations\Mods

Icons from Community Tech Tree by Nertea were modified and included in this mod and are licensed under Creative Commons Attribution-NonCommercial 4.0.

Additional icons used within the tech tree were modified based on incons sourced from flaticon.com and thenounproject.com.  I purchased these as a premium member of these services.  Please check the licensing terms of these websites prior to any redistribution to ensure you remain in compliance with their terms.
