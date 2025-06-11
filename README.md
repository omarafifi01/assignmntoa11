# Color Match VR

A simple VR puzzle where players grab colored cubes and place them on matching platforms.

## Features
- Grab and release colored cubes using VR controllers
- Snap and lock cubes on correct placement
- Return cubes to start position with a buzz sound on incorrect drops
- "Puzzle Completed!" UI appears in front of the player when all cubes are placed
- Restart button to reload the puzzle

## Requirements
- Unity 2022.3 LTS
- XR Interaction Toolkit 3.1
- A VR headset (Quest, PC VR with OpenXR)
- (For Editor testing) XR Device Simulator or XR Controller (Device Simulator) prefabs

## Setup
1. **Clone the repository**  
   ```bash
   git clone <repository-url>
   cd <project-folder>
   ```
2. **Open in Unity** (2022.3 LTS)  
3. **Import Packages**  
   - Ensure **XR Interaction Toolkit** is installed (3.1)  
   - (Optional) Import the **Input Simulation** sample for Editor playtesting  
4. **Configure Interaction Layers** in **Project Settings ▶ XR Interaction Toolkit**: add **Red**, **Green**, **Blue** masks.

## Controls

### In VR
- **Grab / Release**: Trigger button  
- **Move (Teleport)**: Left-hand menu & pointer  
- **Restart Puzzle**: Point & click the UI button  

### In Editor (Simulation)
- **W/A/S/D**: Move the camera  
- **Right-click + Drag**: Look around  
- **Left Mouse**: Simulate right-hand trigger (grab)  
- **Right Mouse**: Simulate left-hand trigger (grab)  
- **Q/E**: Simulate grip on left/right hand  

## Build Instructions
1. **XR Plug-in Management** (Edit ▶ Project Settings ▶ XR Plug-in Management): enable **OpenXR** or your platform.  
2. **Build Settings** (File ▶ Build Settings): switch to **Android** (Quest) or **PC**.  
3. **Build And Run** on your target device.

## Demo Video
Record a 60-second walkthrough showing the player walking around the scene.  
> **Note:** For full interaction testing (grabbing & snapping cubes), use a VR headset.

## Contributing
1. Fork the repo  
2. Create a feature branch  
3. Commit your changes  
4. Open a pull request  

## License
This project is released under the MIT License.
