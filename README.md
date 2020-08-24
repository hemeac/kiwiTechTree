# Kiwi's CTT Overhaul

## Version 0.2.2; 24 August 2020; Made for KSP 1.9.1

![Kiwi CTT Overhaul](https://i.imgur.com/StiyWnp.png)

A CTT "Probes/Planes Before Crew" type Overhaul originally based on the Zee's [PBC Mod](https://forum.kerbalspaceprogram.com/index.php?/topic/181013-ksp-181-probes-before-crew-pbc-version-28/) and inspired by Spink Akron's [UnKerballed Start](https://forum.kerbalspaceprogram.com/index.php?/topic/181932-18x-unkerballed-start-v110-updated-oct-27-2019/).

## Dependencies
* [Community Tech Tree](https://forum.kerbalspaceprogram.com/index.php?/topic/90530-110x-community-tech-tree-august-1-2020/)
* [B9 Part Switch](https://forum.kerbalspaceprogram.com/index.php?/topic/140541-1101-b9partswitch-v2170-july-29/) (Not Included)
* [Module Manager](https://forum.kerbalspaceprogram.com/index.php?/topic/50533-18x-110x-module-manager-414-july-7th-2020-locked-inside-edition/) (Not Included)

## Recommended
* [PlumeParty](https://github.com/JadeOfMaar/PlumeParty) (Alternative to RealPlume)

## Objective

This overhaul, like its predecessors, revolves around the premise that probes should come before crewed space missions.  While I really enjoyed both aforementioned mods, I found two issues: It took a bit too long to see my kerbals in game and I could get a good way through the tech tree before leaving Kerbin's sphere of influence.  While it is a Tech Tree Mod, I have also spent a fair bit of time trying to align the stock parts to have similar functionality available with Nertea's NF Suite.  In addition, I have tried to implement optional mods in Near Future using B9PS functionality, thus removing the restriction of having to choose one or the other within the gameplay environment. While I have tried to keep changes relatively minimial, if you like to play with new parts as the modder intended, this is probably not the right tech tree mod for you.

The rebalance is an attempt to make my tech choices a bit more meaningful and allow my kerbins to spend some time testing jets in Kerbin's atmosphere earlier in the career prior to launching in space.  I have added another 69+ tech nodes across the tree, but have tried to leave the general layout of the tree largely intact.  The major changes are adding a separate branch for solid rocket boosters and if you have mods which have cryogenic engines, this will move them to a different branch from the Liquid Fuel Branch. I have also tried to separate out science more explicitly within the tech tree. While I have shifted some of the nodes around, I have not removed any, thus leaving some compatibility with any mod that I have not explictly supported.

Like UnKerballed Start, I have started with 0.625 meter engines and tanks and work progressively larger.  To try and prevent early crewed missions using spaceplane parts, I have nerfed the skin temperature of the spaceplanes, but have provided higher skin temperatures to the spaceplanes once they reach the High Altitude tech node (same as the introduction of the Mk3 spaceplane). I have used Zee's PBC mod to start the mod going, but even at this point, there is much that is different, so you should expect a different gameplay experience.

I calibrated the basic idea around stock and the expansion packs alongside Restock/Restock+ and Missing History.  Ultimately, given the number of nodes, you will benefit by having several parts mods.

In some cases, I have added rescaled parts and a couple more if Restock is installed.  In other cases such as Missing History, I will use the Restock texture when available for consistency in the visual style.  I have asked Nertea for permission in regards to using Restock/NF models for resizing (if they are installed) and have tried to indicate in the part descriptions which parts I have added in order to avoid confusion. However, please do not take this as Nertea's endorsement of the mod.

I've currently given myself a "Mk0" inline cockpit in the start node because I am terrible at plane design and it is a bit cheaty.  This will probably change as this develops.

## Current Supported Mods (see details below for general changes):
* BetterSRBs 1.2.3
* Completely Non-Aggressive Rocketry 1.0.2
* Heat Control 0.5.2
* LTech 0.5.1 Beta
* Mark IV Spaceplane System 3.1.2
* Missing History 1.8.2
* M.O.L.E. (Very Limited Support) 1.22.1
* Near Future Electrical 1.1.3
* Near Future Propulsion 1.2.2
* Near Future Solar 1.2.3
* Near Future Spacecraft 1.3.3
* RealPlume-Stock 4.0.1
* Restock/Restock+ 1.1.2
* SCANsat 20.2

## Plan of Attack for Mods (Roughly): 
* Nertea's Full Suite of Parts mods excluding the current Far Future due to his current revamp
* DMagic Orbital Science
* Universal Storage 2
* Luciole
* B9 Procedural Wings
* AirplanePlus
* Stockalike Mk1 Open cockpit
* Mk2/Mk3 Expansion
* Rational Resources
* MKS
* Knes
* KIS/KAS
* Stockish Project Orion
* Mining Expansion
* Waterfall (Will continue to watch this as Nertea develops)

## Great Mods, but not likely to be added by me (Happy to accept help):
* BDB and Tantares (Scale and Scope are huge and hard to break down like Near Future). As they also have a strong historical basis, I feel they are out of scope for this mod and probably deserve someone who has a deeper appreciation for the history of spaceflight than I do.  However, if anyone would like to tackle this, I am definitely open for it.  As for BDB though, I would ask that you work towards the 1.7 development build.
* Kerbalism (Doesn't fit my personal playstyle, yet the Science Only configuration that I came across recently looks interesting and I will explore that)

## General Gameplay Changes
* Probe behavior changes in two ways:  First is I have kept PBC's Telemetry Report.  It is a nice and easy way to get some early science which is obviously needed given the additional nodes.  I also remove ALL probes SAS levels by default and add in the functionality through the stock upgrade system which follows the Flight Control tech path. 
* Renamed the command pods to reflect the relative node in which they appear.
* Cockpit heat resistance has been reduced until High-Altitude Flight.
* Engines have received an B9PS upgrade two tiers above them which adds 20% Thrust, 10% Efficiency for an additional 50% Cost and 5% Mass.

## BetterSRBs 1.2.3
Moved the new parts to the SRB tech nodes. Deprecate a couple of parts unless other Jade of Maar mods detected; Undeprecate the Missing History SRB in this stage to offer a third tier of SRBs in the 1.875m category.  Replace new SRB parts with Restock if available to maintain similar aesthetic.

## Completely Non-Aggressive Rocketry 1.0.2
Created a new node in the tech tree between the start and other tech nodes for these.  Shrunk the size to 0.625m to match the small size of the early rockets and balanced fuel and thrust size for similar performance to original.  Ensures that these will not be OP relative to other early career rockets.  Also added an antenna, added a temp and pressure to probe body and soft deprecated the experiments.  Added an upgrade to basicRocketry to allow the rocket to reach space

## Heat Control 0.5.2
Shuffled the tech nodes lightly.  Duplicated the surface 3.75 radiator and scaled 50% to get a 1.875 m variant.  Have to say that I am not an expert in the heat mechanics, so any recommendations will be appreciated.

## Mark IV Spaceplane System 3.1.2
Shuffled the tech nodes.

## Missing History 1.8.2
Soft-deprecate liquid engines of Restock+ installed; hide a few more parts if Restock+ is installed; Used Restock models if available. Engines have received an B9PS upgrade two tiers above them which adds 20% Thrust, 10% Efficiency for an additional 50% Cost and 5% Mass.

## M.O.L.E. 1.22.1
I've taken a few selective pieces out for my personal playthrough and provided some configurations for them that also strip out the WBI Experiment and Omniconverter functionality as I am not intending to use these systems in my playthrough.  I'm providing this only because I can't be bothered putting another folder for this, so consider this incomplete.  But if you want some great looking Restock quality extensions to the Mk1 Cockpit, check out the updated Appaloosa textures in this mod, beautiful.

## Near Future Electrical 1.1.3
Slight repositioning of the tech nodes. If Decaying RTGs installed as an optional mod, doubles the half-life to allow the RTGs to be more useful for OPM or other large scale missions.

## Near Future Propulsion 1.2.2
If installed, we will move the Xenon tanks to noble gas fuel system nodes in the tech tree.  I've added B9 Part Upgrades to Argon and Xenon engines.  Of particular note, as a third tier upgrade to the Argon Hall Thrusters, I have added a Argon/Xenon mix based on the ideas of Diop, Gibert, and Bouchoule (2019) and Yamasaki, Yokota, and Shimamura (2019), that suggests that mixing Xenon and Argon can improve Argon efficiency, while the latter further notes that having a longer discharge channel is able to promote argon ionization, hence higher efficiency. As the hall thrusters had a bit higher thrust relative to xenon for the size class and efficiency, I balanced the VASIMR engines to reflect that gameplay element.  I also increased the cost of Xenon in the stock if Propulsion is installed.  Currently 2.5x the original cost and have modified any Xenon tank costs to reflect that change.

## Near Future Solar 1.2.3
If installed, this will place solar a touch earlier in the tech tree and place most stock parts available a bit earlier.  I've also added B9PS support to the panels, having advanced and concentrated panels similar to NF Solar (no visual difference as seen in Nertea's version). I also spread Nertea's solar parts further through the tech tree and added concentrated part variants to those parts which excluded (Just used the Advanced textures in cases where there were no concentrated versions of the textures). The basic layout is that fixed panels came first, then deployable, but non-tracking, then deployable and tracking.  Along the nodes we have upgrades to each of these variants.

Lastly, the advanced and concentrated versions of both Nertea and stock require a tech upgrade to access.  Advanced will occur one level above the part, Concentrated two levels.

## Near Future Spacecraft 1.3.3
Rebalanced Tech Nodes; Added LF/O Upgrade to Orbital Maneuvering Engines alongside PlumeParty/RealPlume support. Renamed a couple of command pods to align with my naming convention of the stock pods.

## RealPlume 4.0.1 / PlumeParty
Where I have modified engines such as rescaling CNAR or adding LF/O in NF Spacecraft, have tried to ensure that the RealPlume is patched for compliance. Where Real Plume is not installed, will use Plume Party.

## Restock/Restock+ 1.1.2
Shuffled the tech nodes. Slight cost rebalancing on a couple of science parts. Engines have received an B9PS upgrade two tiers above them which adds 20% Thrust, 10% Efficiency for an additional 50% Cost and 5% increased mass.

## SCANsat 20.2
Shuffled the tech nodes. Slight cost rebalancing.

## Alternate Tech Tree Mods (In no particular order)
* [UnKerballed Start](https://forum.kerbalspaceprogram.com/index.php?/topic/181932-18x-unkerballed-start-v110-updated-oct-27-2019/)
* [PBC Mod](https://forum.kerbalspaceprogram.com/index.php?/topic/181013-ksp-181-probes-before-crew-pbc-version-28/)
* [TETRIX and SIMPLEX Tech Tree](https://forum.kerbalspaceprogram.com/index.php?/topic/174731-19x-tetrix-techtree-25-and-simplex-techtree-116/)
* [ETT - Engineering Tech Tree](https://forum.kerbalspaceprogram.com/index.php?/topic/112627-181-ett-engineering-tech-tree-may-4-2020/)
* [Remodeled Tech Tree](https://forum.kerbalspaceprogram.com/index.php?/topic/188286-173-remodeled-tech-tree-v016/)
* [The classic: SETI, Unmanned before Manned](https://forum.kerbalspaceprogram.com/index.php?/topic/95645-13x-seti-unmanned-before-manned-patreon/)
* [Historical Progression Tech Tree](https://forum.kerbalspaceprogram.com/index.php?/topic/144295-122-historical-progression-tech-tree-v20-updated-02-22-2017/)


## Changelog
* 0.2.2 (24 August 2020); Added Heat Control Support
* 0.2.1 (24 August 2020); Added B9PS Upgrades to Nuclear Engines in Stock/Restock/Missing History; Added 5% increased mass to upgraded engines.
* 0.2.0 (23 August 2020); Added B9PS Upgrades to Engines in Stock/Restock+; Moved SSME earlier in tree; light rebalancing.
* 0.1.11 (23 August 2020); Added Near Future Spacecraft support; Decaying RTG patch to Near Future Electrical; Added node for the special propulsion line; renamed command pods; Noted the license restrictions of supported mods.
* 0.1.10 (21 August 2020); Added Near Future Electrical support; Minor changes to Near Future Propulsion
* 0.1.9 (21 August 2020); Added Near Future Propulsion Support; Added nodes to Tech Tree for Ion Propulsion Fuel Systems Line; Balanced Xenon costs
* 0.1.8 (16 August 2020); Added SAS upgrades to probe parts, removed default SAS levels for all stock/modded probes.
* 0.1.7 Slight rebalance of solar parts; Added Near Future Solar support; Added Omega Solar Tech node in tree.
* 0.1.6 Added LTech Beta and SCANsat support; rebalanced stock resource scanners compared to SCANsat
* 0.1.5 Added a couple of nodes to support the command module strand.
* 0.1.4 Added Nuclear Power & Propulsion
* 0.1.3 Added CNAR support.
* 0.1.2 Added BetterSRBs support, Added couple of parts.  Began adding support for optional mod, KiwiDeprecated which soft deprecates parts on the basis of overlap of Nertea's mods if they don't fit in a stockalike style.
* 0.1.1 Added MkIV Spaceplane Support, Added part upgrades to Mk1-3 crewed parts to discourage those being used for the first crewed space missions, cost balancing for engines and SRBs.

## Known Issues
* Couple of upgrade lines in the Tech Tree disappear when viewing them near the edges of the screen.

## Disclaimer

This mod has not been endorsed by _Zee, Spink Akron, Nertea or any other mod/part creator referenced in the config files.  All errors are my own.  Please do not hassle mod authors if these configurations cause conflicts with other mods.

## License

MIT License
Copyright (c) 2020, Hemeac

Permission is hereby granted, free of charge, to any person obtaining a copy of this software 
and associated documentation files (the "Software"), to deal in the Software without restriction, 
including without limitation the rights to use, copy, modify, merge, publish, distribute, 
sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is 
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or 
substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING 
BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, 
DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

### Additional Licenses and attributions:
Tech tree reconfigs were based on config files originally created by _Zee and redistributed under the same MIT license. Additional config files are likely to be influenced by their respective mod creators and the respective licenses of the config files are noted within the mod files within each subfolder in GameData\KiwiAerospace\TechTree\Configurations\Mods

Icons from Community Tech Tree by Nertea were modified and included in this mod and are licensed under Creative Commons Attribution-NonCommercial 4.0.

Additional icons sourced from flaticon.com and thenounproject.com.
