# Unity Homework 3 – Gameplay Patterns and Triggers

## 🧩 Task Implemented – Assignment 2: Score UI using Canvas

HW3 assignment, I implemented **Task 2** from the optional changes list:

> ✳️ _"The player's score should no longer appear above the spaceship, but instead at a fixed position on the screen (e.g., top-right corner). The score display must remain correctly positioned even when the screen size or orientation changes. Use a Canvas."_

### ✔️ What was implemented:
- Created a **Canvas** with a `TextMeshProUGUI` text element positioned at the **top-right corner** of the screen.
- Used appropriate **anchors and offsets** to ensure responsive positioning for any screen size.
- Attached a `NumberField` script to the text element to allow displaying numbers.
- Attached a `GameStatusReader` script that **updates the score live from the `GAME_STATUS.playerScore` static variable**.
- Verified that score updates appear instantly on screen during gameplay.
- Used `TextMeshPro` for sharper text rendering and added a `.gitignore` file to exclude unnecessary Unity-generated files from the repository.

---

A project with step-by-step scenes illustrating some of the formal elements of game development in Unity, including: 

* Prefabs for instantiating new objects;
* Colliders for triggering outcomes of actions;
* Coroutines for setting time-based rules.

Text explanations are available 
[here](https://github.com/gamedev-at-ariel/gamedev-5782) in folder 04.

## Cloning
To clone the project, you may need to install git lfs first (if it is not already installed):

    git lfs install 

To clone faster, you can limit the depth to 1 like this:

    git clone --depth=1 https://github.com/<repository-name>.git

When you first open this project, you may not see the text in the score field.
This is because `TextMeshPro` is not in the project.
The Unity Editor should hopefully prompt you to import TextMeshPro;
once you do this, re-open the scenes, and you should be able to see the texts.

## Credits

Programming:
* Maoz Grossman
* Erel Segal-Halevi

Online courses:
* [The Ultimate Guide to Game Development with Unity 2019](https://www.udemy.com/the-ultimate-guide-to-game-development-with-unity/), by Jonathan Weinberger

Graphics:
* [Matt Whitehead](https://ccsearch.creativecommons.org/photos/7fd4a37b-8d1a-4d4c-80a2-4ca4a3839941)
* [Kenney's space kit](https://kenney.nl/assets/space-kit)
* [Ductman's 2D Animated Spacehips](https://assetstore.unity.com/packages/2d/characters/2d-animated-spaceships-96852)
* [Franc from the Noun Project](https://commons.wikimedia.org/w/index.php?curid=64661575)
* [Greek-arrow-animated.gif by Andrikkos is licensed under CC BY-SA 3.0](https://search.creativecommons.org/photos/2db102af-80d0-4ec8-9171-1ac77d2565ce)
