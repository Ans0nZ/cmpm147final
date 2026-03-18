# 2D Roguelike Game (CMPM 147 Final Project)

## 🎮 Overview
This project is a fully playable 2D roguelike game developed in Unity. The player navigates through a series of combat encounters, gains experience, selects upgrades, and attempts to survive as long as possible.

The game emphasizes replayability through procedural generation systems that create variation in each run. No two playthroughs are exactly the same due to dynamic generation of upgrades, enemies, and encounter structure.

---

## 🔁 Core Gameplay Loop
- Start a new run
- Enter procedurally generated encounters
- Defeat enemies
- Gain experience and level up
- Choose one of several generated upgrades
- Progress to the next encounter
- Continue until death
- Restart with a new generated run

This loop supports multiple playthroughs and creates a classic roguelike progression structure.

---

## ⚙️ Procedural Generation Systems

This project includes **live procedural generation at runtime**, ensuring that gameplay content is generated during play rather than pre-authored.

### 1. Upgrade Generation (Runtime)
- Each level-up presents randomized upgrade options
- Upgrades are generated from stat ranges (damage, crit rate, speed, etc.)
- Players build different character configurations each run

### 2. Enemy / Encounter Generation (Runtime)
- Enemy types and group compositions vary per encounter
- Procedural variation affects difficulty and pacing
- Each room creates a different combat scenario

### 3. Progression Structure (Map Flow)
- Encounters are arranged in a procedurally determined sequence
- The order and pacing of gameplay differs across runs

These systems work together to produce meaningful variation rather than simple randomness.

---

## 🧠 Midterm Tool Usage

This project reuses multiple generator tools developed during the midterm.

### ✅ Upgrade Generator (Internal Tool)
- Generates randomized level-up options
- Directly used in gameplay
- Controls player progression and build diversity

### ✅ Map / Progression Generator (Internal Tool)
- Defines encounter flow and structure of each run
- Supports replayability by altering progression paths

### ✅ Affix / Modifier Generator (Internal Tool)
- Generates variations in enemy behavior or attributes
- Adds systemic complexity and emergent gameplay

---

## 🌐 External Tool

### Procedural Naming Generator

An external procedural naming generator was incorporated to enhance content variation and thematic consistency.

This tool dynamically generates names for:
- enemy types
- modifiers (affixes)
- potential encounter labels

It combines predefined word pools (prefixes, descriptors, and types) to produce names such as:
- "Flaming Splitter"
- "Swift Devourer"
- "Corrupted Guardian"

Although lightweight, this tool strengthens the perception of variety and reinforces the procedural nature of the game.

The tool was adapted and integrated into the content pipeline.

---

## 🌍 Live Procedural Requirement

At least one system (upgrade generation and enemy generation) runs **during gameplay**, ensuring true runtime procedural generation.

Even when using fixed seeds for testing, generation occurs live during each run.

---

## ▶️ Play the Game

👉 [INSERT YOUR LINK HERE]  
(e.g. Itch.io / GitHub Pages)

---

## 🧑‍🤝‍🧑 Team Contributions

- Anson F. — Game design, programming, procedural systems, UI implementation


---

## 📦 Credits

- Unity Engine
- Midterm generator tools (internal)
- External procedural naming system
- Any additional assets (if used)

---

## 🤖 AI Disclosure

AI tools (such as ChatGPT) were used for:
- brainstorming design ideas
- refining documentation
- debugging assistance

All final implementation, integration, and design decisions were completed by the developer.

---
