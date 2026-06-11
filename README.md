# \# 2D Platformer (Unity)

# 

# !\[Gameplay Demo](Media/gameplay.gif) 

# 

# \## 📌 Overview

# A feature-rich 2D platformer developed in Unity, demonstrating advanced character controllers, dynamic enemy behaviors, and robust game state management. This project focuses on delivering a highly responsive, "tight" platforming experience while showcasing clean, modular C# architecture and object-oriented design principles.

# 

# \## 🚀 Key Features

# \* \*\*Advanced Player Movement:\*\* Highly tuned platforming mechanics including adjustable jump heights, double jumping, wall-jumping, and "Coyote Time" for forgiving ledge transitions.

# \* \*\*Complex Enemy AI \& Traps:\*\* Features a variety of threats including patrolling enemies, animated fire traps with delayed activation, and "Spikeheads" that utilize 4-directional raycasting to detect and dive at the player.

# \* \*\*Health \& Checkpoint System:\*\* Comprehensive damage handling with temporary invulnerability (iFrames), visual feedback (sprite flashing), collectible health items, and a robust checkpoint-based respawn system.

# \* \*\*Persistent Audio \& UI:\*\* Custom-built UI with keyboard-driven menu navigation. Includes a persistent Sound Manager (`DontDestroyOnLoad`) that saves player volume preferences across scenes using `PlayerPrefs`.

# \* \*\*Smooth Camera Tracking:\*\* Custom camera follow logic utilizing `Mathf.Lerp` for dynamic look-ahead based on the player's facing direction.

# 

# \## ⚙️ Technical Architecture

# The codebase is designed for scalability and performance:

# \* \*\*Physics \& Raycasting:\*\* Replaced standard trigger collisions with `Physics2D.BoxCast` and `RaycastHit2D` for precise ground, wall, and player detection, eliminating common physics glitches.

# \* \*\*Object-Oriented Design (OOP):\*\* Utilized inheritance (e.g., base `EnemyDamage` class extended by specific enemy types) to reduce code duplication and maintain modularity.

# \* \*\*Coroutines for Timing:\*\* Effectively leveraged `IEnumerator` for handling complex time-based events like trap activation sequences and invulnerability frame loops.

# \* \*\*Singleton Managers:\*\* Implemented the Singleton pattern for `SoundManager` and `UIManager` to easily manage global game states, pausing (`Time.timeScale`), and scene transitions.

# 

# \## 🛠️ Built With

# \* \*\*Engine:\*\* Unity 2022.3.21f1

# \* \*\*Language:\*\* C#

# \* \*\*UI:\*\* Unity standard UI / Canvas

