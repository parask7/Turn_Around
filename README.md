# 🎮 TurnAround

**TurnAround** is a 3D Unity action-combat game currently under development, focused on melee combat gameplay and enemy AI behavior.

---

## 🕹️ Current Features

### 🧍 Player
- ✅ Player movement (WASD)
- ✅ **Third-person camera system**
- ✅ Jump system (CharacterController based)
- ✅ Player health system
- ✅ Player melee attack system
- ✅ Attack affects **all enemies within range**
- ✅ Attack triggered using **Left Mouse Button**
- ✅ No attack cooldown (basic attack)

### 👾 Enemy AI
- ✅ Enemy spawning system (multiple enemies per level)
- ✅ Enemies chase the player **from the start**
- ✅ Enemy attack system
- ✅ Enemy health system
- ✅ Enemies continue chasing until defeated

---

## 🎯 Controls

| Key / Mouse | Action |
|------------|-------|
| **W A S D** | Move Player |
| **Mouse** | Rotate Camera |
| **Space** | Jump |
| **Left Mouse Button** | Attack |

---

## ⚔️ Combat System

- Player performs melee attacks using **Left Mouse Button**
- All enemies inside attack radius take damage
- No cooldown (normal attack)
- Enemy attacks damage the player
- Combat logic handled via modular scripts

---

## 🧠 Enemy Behavior

- Enemies spawn at predefined spawn points
- Enemies immediately chase the player
- Enemies attack when in range
- Movement is position-based (refinement planned)

---

## 🛠️ Built With

- **Unity Engine**
- **C#**
- **Unity New Input System**
- **CharacterController (Player)**
- **Rigidbody (Enemy)**

---

## ▶️ How to Run the Game

1. Clone the repository
2. Open the project in **Unity Hub**
3. Ensure **Input System Package** is enabled
4. Press **Play** in Unity Editor

---

## 🚧 Work in Progress / Planned Features

- Fix enemy overlapping (separation & collision avoidance)
- Enemy animations
- Player attack animations
- Improved enemy detection (FOV + Raycast)
- Audio system improvements
- UI for health display
- Level design improvements
- WebGL build & itch.io upload

---

## 👨‍💻 Developer

**Paras Kukreja**  
Indie Game Developer 🚀  
Learning Unity, Game Design, and Game Programming
