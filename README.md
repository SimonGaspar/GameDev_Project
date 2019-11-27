# GameDev_Project

### Level 0 (F1) - Basic level
### Level 1 (F2) - landmine; Šimon Gašpar (487583)

**_Press right click to set landmine_**

Created things:
  - Redesign of level
  - Mine (Prefab)
    - HitParticle (Particle system when landmine explode)
    - AudioSource (explosion)
    - BoxCollider (for activation)
    - Mine (Script)
      - Behavior of mine
  - LoadManager (Script)
    - Managment of levels
  - PlantMine (Script)
    - This script has Player and after that can set landmine

### Level 2 (F3) - power ups; Nikola Blaňárová (456465)
  - Redesign of level
  - PowerUp (Script)
    - Parent class for all power ups
  - PowerUpManager (Script)
    - Management of power up spawners
  - <Type>PowerUp (Prefab)
    - 3D Model
    - BoxCollider (for activation)
    - <Type>PowerUp (Script)
      - Behavior of specific power up
