# Kevin Contreras

# prep
repo: https://github.com/Kon-6/CS-110-GameProject
gitTest: I created my repository by logging into GitHub and clicking on New Repository. I gave my repository a name and created it. after that, I opened my repository in GitHub Codespaces so could work on my files. I used index.html to create and edit my webpage. I saved my changes, committed them, and pushed them to GitHub so my work would be saved in repository.
access: Solo
video1: The video introduces the game development process using Unity. I learned that creating a game involves different steps, including planning, designing, programming, and testing. I want to learn more about how Unity works and how C# is used to make games.
video2: The video explains why having a good mindset is important in game development. I learned developers need to be creative, patient, and willing to learn from their mistakes. It also talks about challenges like technical problems, adding too many features, and burnout. One thing I found useful was setting small goals and staying organized instead of trying to do everything at once, I think this can help me as I continue learning programming.
video3: I learned that organizing your folders and files is important when creating a game because it makes everything easier to find. The video showed how to create a main project folder and use different folders to keep things organized. One thing i found useful was the dolog.txt file because it helps you keep track of your progress. My question is, do we need to create all these folders manually, or can we use a tool to create them automatically.
video4: I learned that documentation is important when creating a game because it helps keep everything organized and makes it easier to understand the project. The video showed how a Game Development can be used to the game's features, goals, and progress. One thing i found useful was using README files to explain what each folder contains. My question is, do we need to create a Game Development Document even if we are working on a small game by ourselves? 
video5: I learned how to get started with Unity and how to create a new game project using Unity Hub. The video showed the different parts of the Unity Editor, like the Hierarchy, Scene View, Game View, and Inspector. One thing I found useful was learning how to test a game using the Play button and move the character with WASD. My question is, can I use the Third Person Core template to create my own game instead of starting completely from scratch?
video6: The video shows how to import a custom player into Unity instead of using the default character. I learned that you can customize your game by adding different character models and organizing their files in your project. One thing I found useful was seeing how the character can be changed to make the game more unique. My question is, can I use any 3D character model in Unity, or does it need to be compatible with the game?
opinion: I think this game development pipeline can help me create my own game by showing me how to plan and organize everything before starting. For my project, I want to make a simple 3D game where the player moves around and collects coins. The videos helped me understand how to set up a Unity project, organize files, and customize characters. I think following these steps will make it easier to build my game and fix problems along the way.
questions: Before starting my project, I want to know what the easiest way to create a simple game in Unity is. I also want to know how to organize my files, test my game, and upload everything to GitHub. Since I’m still learning, I want to keep my game simple and focus on making sure it works.

# communicationTables

## 0
id: 0dec4b4e-0920-479c-90ff-ea28250a3ab0
title: Team check-ins

### columns

#### 0
label: Kevin Contreras
type: text

#### 1
label: When · Pacific
type: datetime-local

#### 2
label: Agreed
type: checkbox

#### 3
label: New column
type: text

### rows

#### 0
0: Work solo on Unity Roll-a-Ball. Use GitHub to save progress and track decisions.
1: 
2: true
3: 

#### 1
0: Choose your next planned work session
1: 
2: true
3: 

#### 2
0: Check the box once you've confirmed your plan
1: 
2: true
3: 

## 1
id: d99e0bc3-4c15-46e5-8569-b367bbaa1890
title: Working agreements

### columns

#### 0
label: Agreement
type: text

#### 1
label: Owner / where recorded
type: text

#### 2
label: Confirmed
type: checkbox

### rows

#### 0
0: I will work independently and complete my 3D Roll-a-Ball game in Unity.
1: Kevin Contreras / GitHub
2: true

# huddle
communication: Team check-ins
Kevin Contreras | When · Pacific | Agreed | New column
Work solo on Unity Roll-a-Ball. Use GitHub to save progress and track decisions. |  | [x] | 
Choose your next planned work session |  | [x] | 
Check the box once you've confirmed your plan |  | [x] | 

Working agreements
Agreement | Owner / where recorded | Confirmed
I will work independently and complete my 3D Roll-a-Ball game in Unity. | Kevin Contreras / GitHub | [x]
code: Classes & components
Class | Responsibility | GameObject | New column
PlayerController | Moves the ball | Player | 
Rigidbody | Handles physics | Player | 
CameraFollow | Follows the ball | Main Camera | 

Variables / properties
Name : type | Value / purpose | Used by
moveSpeed : float | Controls ball speed | PlayerController
rb : Rigidbody | Controls ball speed | PlayerController
movement : Vector3 | Stores movement direction | PlayerController

f(x) · Functions
Function | Inputs → result | When called
Start() | Gets Rigidbody | Game starts
Update() | Reads keyboard input | Every frame
FixedUpdate()  | Reads keyboard input | Every physics step

Start / Update
Callback | What happens | Verified
Start() | Sets up ball physics | [x]
Update() | Reads player input | [x]
FixedUpdate()  | Applies movement | [x]

Packages / using
Package / namespace | Why included | Tested
UnityEngine | Allows C# to use Unity features like physics and movement | [x]
System.Collections | Supports collections if needed | [x]
System.Collections.Generic | Supports lists of game objects if needed | [x]
mission: I chose to create a simple 3D Roll-a-Ball game using Unity. The player will control a ball using the keyboard and move it around a platform. My goal is to make a basic playable game that works correctly.
framework: I decided to use the ADD/P2P framework to help organize my project. I will start by planning my simple 3D Roll-a-Ball game, then build it step by step in Unity. I will test the ball movement, fix any problems, and make sure the game works before submitting it.
pipeline: Make a 3D Roll-a-Ball game · 2026-11-10T12:45 to 2026-11-10T13:45 Pacific
Unity, sphere, platform, C# · 2026-11-10T13:45 to 2026-11-10T14:45 Pacific
Create objects and ball movement · 2026-11-10T14:45 to 2026-11-10T15:45 Pacific
Playable 3D game · 2026-11-10T15:45 to 2026-11-10T16:45 Pacific
Test controls and fix errors
My production plan is to create a simple 3D Roll-a-Ball game in Unity. First, I will create a platform and a sphere. Next, I will add a C# script to control the ball using the keyboard. Finally, I will test the game, fix any errors, and make sure the ball moves correctly. I will complete all tasks myself.
tech: I decided to use Unity 6 to create my 3D Roll-a-Ball game because it has the tools needed to build a simple 3D game. I will use C# to program the ball’s movement and Visual Studio Code to write and edit my scripts. I will use basic Unity objects like a sphere and a cube for the ball and platform, so I won’t need extra assets or packages. I will also use GitHub to save my project. Since I am working alone, I will check everything myself by testing the game and making sure the controls work correctly.
reuse: I can reuse the player movement script, camera controls, and basic game objects in future Unity projects. These will help me create other simple 3D games faster. I will use Unity’s built-in tools and my own code. If I use outside assets or code, I will check their licenses and give credit when required.
boardNotes: I decided to create a simple 3D Roll-a-Ball game using Unity and C#. My plan is to make a ball that moves around a platform using keyboard controls. I will work alone and use GitHub to save my progress. My main question is how to make the movement and camera work correctly. I will test the game in Unity and fix any problems I find. There are no team disagreements because I am working solo.

# codeTables

## 0
id: acfd9e48-3f11-4e24-8963-0f55c0269723
title: Classes & components

### columns

#### 0
label: Class
type: text

#### 1
label: Responsibility
type: text

#### 2
label: GameObject
type: text

#### 3
label: New column
type: text

### rows

#### 0
0: PlayerController
1: Moves the ball
2: Player
3: 

#### 1
0: Rigidbody
1: Handles physics
2: Player
3: 

#### 2
0: CameraFollow
1: Follows the ball
2: Main Camera
3: 

## 1
id: fe1e8e45-00db-4e7a-9c15-f6df443ee5c2
title: Variables / properties

### columns

#### 0
label: Name : type
type: text

#### 1
label: Value / purpose
type: text

#### 2
label: Used by
type: text

### rows

#### 0
0: moveSpeed : float
1: Controls ball speed
2: PlayerController

#### 1
0: rb : Rigidbody
1: Controls ball speed
2: PlayerController

#### 2
0: movement : Vector3
1: Stores movement direction
2: PlayerController

## 2
id: d44c5bbe-988d-43c8-969e-c3870abdb520
title: f(x) · Functions

### columns

#### 0
label: Function
type: text

#### 1
label: Inputs → result
type: text

#### 2
label: When called
type: text

### rows

#### 0
0: Start()
1: Gets Rigidbody
2: Game starts

#### 1
0: Update()
1: Reads keyboard input
2: Every frame

#### 2
0: FixedUpdate() 
1: Reads keyboard input
2: Every physics step

## 3
id: c06ad1c0-d012-47ed-aeb6-cc31886faed7
title: Start / Update

### columns

#### 0
label: Callback
type: text

#### 1
label: What happens
type: text

#### 2
label: Verified
type: checkbox

### rows

#### 0
0: Start()
1: Sets up ball physics
2: true

#### 1
0: Update()
1: Reads player input
2: true

#### 2
0: FixedUpdate() 
1: Applies movement
2: true

## 4
id: 15ce594d-5c47-4733-81e4-1ace0e263d66
title: Packages / using

### columns

#### 0
label: Package / namespace
type: text

#### 1
label: Why included
type: text

#### 2
label: Tested
type: checkbox

### rows

#### 0
0: UnityEngine
1: Allows C# to use Unity features like physics and movement
2: true

#### 1
0: System.Collections
1: Supports collections if needed
2: true

#### 2
0: System.Collections.Generic
1: Supports lists of game objects if needed
2: true

# prepBoard
notes: This is my plan for creating a simple 3D obstacle course game in Unity. I will start by creating the project, then add a player, platform, and obstacles. After that, I will test the game to make sure the player can move and jump. Finally, I will save my project to GitHub. I am working on this project by myself, and my goal is to keep everything simple and organized.

## pen
color: #153f48
size: 3

# pitch
understand: My goal is to create a very simple 3D game in Unity where the player controls a ball and moves it around a platform. I want to keep the game basic so I can finish it quickly. I will create a platform, add a ball, and write a simple script to control its movement. The project will be finished when the ball moves using the keyboard and the game runs without errors.
offer: I can contribute by creating the basic game environment in Unity, adding the ball and platform, and working on the movement controls. I’m still learning how to code, but I can follow tutorials, test the game, and fix problems as I go. I will also help keep the project organized and save my progress on GitHub.
limits: I still need to learn how to use Unity better, especially how to create objects and make them move. I also need more practice with C# so I can write a simple script to control the ball using the keyboard. I may need help fixing errors and testing the game to make sure everything works correctly.
availability: 
Preferred contact: Classroom
I will be working independently on my Unity game project. My goal is to finish a simple 3D Roll-a-Ball game as soon as possible. I can communicate through the classroom if I need help.
tools: I will use Unity to create my 3D game and add the ball and platform. I will use Visual Studio Code to write a simple C# script that lets the player move the ball with the keyboard. I will also use GitHub to save my project and keep track of my progress. These tools will help me create, test, and organize my game.
aiTool: AI: ChatGPT
Task: I will use ChatGPT to help me create a simple 3D game in Unity, write basic C# scripts, and fix errors when I get stuck.
Verification: I will test the code in Unity, check for errors, and make sure the ball moves correctly when I play the game.

# availability
notes: I will be working independently on my Unity game project. My goal is to finish a simple 3D Roll-a-Ball game as soon as possible. I can communicate through the classroom if I need help.

# aiPlan
name: ChatGPT
task: I will use ChatGPT to help me create a simple 3D game in Unity, write basic C# scripts, and fix errors when I get stuck.
verify: I will test the code in Unity, check for errors, and make sure the ball moves correctly when I play the game.

# pipelineBoard
notes: My production plan is to create a simple 3D Roll-a-Ball game in Unity. First, I will create a platform and a sphere. Next, I will add a C# script to control the ball using the keyboard. Finally, I will test the game, fix any errors, and make sure the ball moves correctly. I will complete all tasks myself.

# huddleBoard
notes: I am working solo on a simple 3D Roll-a-Ball game. My plan is to create a platform, add a ball as the player, write a C# movement script, and test the controls in Unity. I will be responsible for all tasks. My goal is to make a playable game where the ball moves using the keyboard.

# tasks

## 0
id: f5d93306-5d04-409e-aafa-28e369b16699
task: Set up Unity Project
owner: PERSON-E0E2BBE703A2746405945512
due: 2026-11-12T23:30
done: false
result: 

## 1
id: fced2d50-8d5f-43ae-b568-803b26bf1d49
task: Create platform and player ball
owner: PERSON-E0E2BBE703A2746405945512
due: 2026-11-12T20:30
done: false
result: 

## 2
id: aefbecf4-db1c-40ee-aa63-f68b8a836f74
task: Add C# player movement
owner: PERSON-E0E2BBE703A2746405945512
due: 2026-11-12T20:30
done: false
result: 

## 3
id: 200ef515-8d03-40dd-b1eb-b79ac36a3644
task: Test the game
owner: PERSON-E0E2BBE703A2746405945512
due: 2026-11-12T20:30
done: false
result: 

## 4
id: fc6d3616-0c76-4c37-864d-650b1689faec
task: Document project and upload to GitHub
owner: PERSON-E0E2BBE703A2746405945512
due: 2026-11-12T20:30
done: false
result: 

## 5
id: d902358e-be4c-4b8b-90f5-5dac07d3cf49
task: 
owner: PERSON-E0E2BBE703A2746405945512
due: 2026-11-12T20:30
done: false
result: 
returnToB: true

# reportA
checkpoint: Today I worked on planning my 3D Roll-a-Ball game in Unity. I decided to work independently and organized the steps needed to complete my project. I identified the tools, scripts, and game objects I will need, including the player, camera, and collectibles. I also created a task plan and assigned myself the responsibilities. My next step is to begin building the game in Unity, test the player movement, and make sure the collectibles work correctly.
evidence: I am working independently on my 3D Roll-a-Ball game using Unity and C#. I saved my project progress to my GitHub repository.

GitHub repository: https://github.com/Kon-6/CS-110-GameProject

next: My next step is to start building my 3D Roll-a-Ball game in Unity. I will create the player ball, floor, and walls, then use C# to make the ball move. After that, I will add collectible objects and test the game. My goal is to complete the basic game by November 12, 2026. If I run into problems with the code or Unity, I will review tutorials, check for errors, and troubleshoot them before continuing.

# reportABoard
notes: This diagram shows my progress on my 3D Roll-a-Ball game. I completed the planning stage and organized the tasks I need to finish. My next step is to set up the game in Unity, add player movement, create collectible coins, and test everything. I am working independently and will track my progress on GitHub.