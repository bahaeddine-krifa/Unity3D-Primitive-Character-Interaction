# 🎮 Unity 3D: Primitive Character & Physics Interaction

![Unity](https://img.shields.io/badge/Unity-2021+-000000?style=for-the-badge&logo=unity)
![C#](https://img.shields.io/badge/C%23-Scripting-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![3D](https://img.shields.io/badge/3D-Models%20&%20Physics-blueviolet?style=for-the-badge)
![Platform](https://img.shields.io/badge/Platform-Windows%20/%20Mac-lightgrey?style=for-the-badge)

A foundational 3D project built in **Unity** that explores the core mechanics of the Unity Editor, 3D spatial manipulation, physics components, and basic game interactions. The project features a custom "BonHomme" (Snowman/Character) built entirely from basic 3D primitives, interacting with a physical environment.

---

## 📑 Table of Contents
- [Project Overview](#-project-overview)
- [Key Features](#-key-features)
- [Concepts Demonstrated](#-concepts-demonstrated)
- [Prerequisites](#-prerequisites)
- [How to Run](#-how-to-run)
- [Project Structure](#-project-structure)
- [Acknowledgments](#-acknowledgments)

---

## 🌟 Project Overview
This project was developed as a hands-on introduction to 3D virtual environments in Unity. Instead of using imported 3D models, the main character ("BonHomme") is constructed programmatically and hierarchically using Unity's basic primitives (Spheres and Cubes). The project then applies materials, physics components, and environmental interactions to bring the scene to life.

---

## ✨ Key Features

### 🧍 Primitive Character Construction ("BonHomme")
- **Hierarchical Object Parenting**: Building a complex character from simple shapes.
  - **Head & Body**: 3D Spheres.
  - **Arms & Legs**: 3D Cubes (Parallelepipeds).
- **Transform Manipulation**: Precise positioning, scaling, and rotation of child objects relative to the parent.

### 🎨 Materials & Textures
- Creation and application of custom **Materials** (adjusting Albedo, metallic, and smoothness/shininess).
- Integration of external **Textures** to add visual detail to the primitives.

### 🧲 Physics & Collision System
- **Rigidbody & Colliders**: Implementing gravity and physical boundaries for the character and environment.
- **Environment Setup**: A ground plane (`Plane`) and a central obstacle (`Wall`).
- **Collision Handling**: Exploring and resolving collision detection between the character and the environment.

### 🎾 Interaction & Animation
- **Scene Duplication**: Mirroring the character setup on opposite sides of the arena.
- **Dynamic Interaction**: Implementing a mechanism for each character to spawn and throw a "Ball" (Sphere) toward the opposing character.

---

## 🧠 Concepts Demonstrated
| Unity Concept | Application in Project |
| :--- | :--- |
| **Hierarchy & Parenting** | Grouping primitives to form the "BonHomme". |
| **Transform Component** | Moving, rotating, and scaling the character on the platform. |
| **Physics Engine** | Using `Rigidbody` for gravity/mass and `Collider` for physical boundaries. |
| **Materials & Shaders** | Modifying visual properties (color, texture, shininess). |
| **Basic Scripting / Logic** | Handling the interaction logic for throwing the ball between characters. |

---

## ⚙️ Prerequisites
To open and run this project, you need:
- **Unity Hub** installed.
- **Unity Editor** (Version 2021.3 LTS or newer recommended).
- Basic understanding of the Unity Interface (Scene, Game, Hierarchy, Inspector windows).

---

## 🚀 How to Run

1. **Clone the Repository**
   ```bash
   git clone https://github.com/bahaeddine-krifa/Unity3D-Primitive-Character-Interaction.git
