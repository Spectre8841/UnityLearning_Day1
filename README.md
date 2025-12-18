🎮 Unity RPG 2D – Week 1 Progress

Engine: Unity 2022.3 LTS
Genre: 2D Top-down RPG
Duration: Week 1 (Core Gameplay & Combat Foundation)

📌 Overview

Trong tuần đầu tiên, project tập trung xây dựng nền tảng gameplay cốt lõi cho một game RPG 2D, bao gồm:

Player movement & input system

Camera & map setup

NPC interaction

Combat system cơ bản

Enemy AI

Health & UI system

Mục tiêu của Week 1 là tạo ra một playable prototype hoàn chỉnh, đúng kiến trúc, sẵn sàng mở rộng trong các tuần tiếp theo.

🧠 Core Systems Implemented
1️⃣ Player System

Di chuyển 4 hướng (WASD) bằng Unity Input System

Animator điều khiển Idle / Walk

Sorting layer theo trục Y (đúng kiểu RPG top-down)

Interaction system (nhấn E để tương tác NPC)

2️⃣ Camera & Map

Cinemachine Virtual Camera

Confiner 2D giới hạn camera theo map

Tilemap + Collider 2D

Fix lỗi collider ảnh hưởng player khi dùng confiner

3️⃣ NPC Interaction

NPC với trigger zone

Hiển thị log khi player tương tác

Kiến trúc tách PlayerInteraction & NPC logic

Sẵn sàng mở rộng sang Dialogue System

4️⃣ Combat System (Foundation)

DamageDealer: gây damage bằng hitbox (reusable)

Health System:

maxHealth, currentHealth

TakeDamage()

Clamp HP về [0 – max]

Event onHealthChanged

Áp dụng cho cả Player & Enemy

5️⃣ Enemy AI

Enemy phát hiện player trong chaseRange

Di chuyển về phía player

Dừng lại ở stopDistance (không đâm đầu)

Kiến trúc sẵn sàng cho FSM (Idle / Chase / Attack)

6️⃣ HP Bar UI (Production-ready)

Canvas Screen Space – Overlay

HP Bar dùng Image Filled (không dùng Slider)

Background dùng Image Sliced

Fill dùng sprite trắng trơn (không padding)

Update UI bằng event-based system

Fix các bug thực tế:

Fill bị hở đầu/đuôi

HP không về 0 khi player chết

UI không update đúng thời điểm

🛠️ Technical Highlights

Tách biệt rõ:

Logic (Health, Damage)

Input

UI

Không lạm dụng Update()

Code dễ đọc, dễ mở rộng

Fix bug dựa trên root cause, không workaround

📂 Project Structure (Simplified)
Assets/_Project
├── Scripts
│   ├── Player
│   ├── Enemy
│   ├── Combat
│   └── UI
├── Art
├── Animations
└── Scenes

🧪 Known Issues / To Improve

Enemy chưa có attack animation

Chưa có knockback

Chưa có death animation

Chưa có sound effect

👉 Sẽ được xử lý trong Week 2
