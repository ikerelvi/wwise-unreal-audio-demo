# Wwise x Unreal Audio Demo

Game audio implementation portfolio project. All sounds are designed and implemented by me, Iker Elorza Vidal.

**Status:** work in progress (started November 2026)

## Goal
A small playable scene that showcases core game audio implementation skills:
- Footsteps by surface (grass, metal, concrete) with variations and speed-driven parameters
- Reverb and ambience zones (outdoor to metal corridor)
- An interactive tool/weapon with layered sounds and environment-dependent tails
- Mix pass profiled with the Wwise Profiler

## Tech
- Unreal Engine 5.8
- Wwise 2024.1
- macOS (Apple Silicon)

## Roadmap
- [x] Unreal <-> Wwise integration working
- [ ] Footsteps by surface
- [ ] Reverb zones and ambiences
- [ ] Interactive tool with layered audio
- [ ] Mix pass and Profiler captures
- [ ] Demo reel

## Opening the project
The Wwise plugins are not included in this repository. Integrate Wwise 2024.1 into the Unreal project with the Audiokinetic Launcher. The Wwise project is in `AudioPortfolio_WwiseProject/`. SoundBanks are generated locally.

## Audio and licensing
All audio is original unless stated otherwise. Unreal Engine template content belongs to Epic Games.

## Author
Iker Elorza Vidal, audio engineer. https://ikerelvi.com