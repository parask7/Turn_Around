# 🎮 TurnAround

**TurnAround** is a 3D Unity game currently under development, focused on combat-based gameplay with intelligent enemy behavior.

---

## 🕹️ Current Features

### 🧍 Player
- ✅ Player movement (WASD)
- ✅ First-person camera
- ✅ Jump system
- ✅ Player health system
- ✅ Player attack system (melee)
- ✅ Attack triggered using **F key**
- ✅ Attack range & cooldown implemented

### 👾 Enemy AI
- ✅ Enemy patrol system using patrol points
- ✅ Enemy chase system when player enters detection range
- ✅ Enemy attack system
- ✅ Enemy switches between patrol, chase, and attack states
- ✅ Enemy continues chasing player until one is defeated

### 🔊 Audio
- ✅ Footstep sound while walking
- ✅ Jump sound
- ✅ Landing sound
- ✅ Audio managed through a dedicated player audio script

---

## 🎯 Controls

| Key | Action |
|----|-------|
| **W A S D** | Move Player |
| **Mouse** | Look Around |
| **Space** | Jump |
| **F** | Attack |

---

## ⚔️ Combat System

- Player attacks using **F key**
- Attacks work only within a defined range
- Cooldown prevents continuous spam
- Enemies have health and can be defeated
- Enemies damage the player when in attack range

---

## 🧠 Enemy Behavior

- Enemies patrol between multiple patrol points
- Enemy detects player within a defined chase range
- Enemy chases player once detected
- Enemy attacks player when close enough

---

## 🛠️ Built With

- **Unity Engine**
- **C#**
- **Unity New Input System**
- **Rigidbody-based logic**

---

## ▶️ How to Run the Game

1. Clone the repository
2. Open the project in **Unity Hub**
3. Make sure **Input System package** is enabled
4. Press **Play** in Unity Editor

---

## 🚧 Work in Progress / Planned Features

- Enemy animations
- Player attack animations
- Improved enemy detection (FOV + Raycast)
- UI for health and stamina
- Sound polishing
- Level design improvements
- WebGL build support

---- Enemy does **not stop chasing** until player or enemy is defeated

## 👨‍💻 Developer

**Paras Kukreja**  
Indie Game Developer 🚀  
Learning Unity, Game Design, and Game Programming

---
