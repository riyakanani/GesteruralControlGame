# GesteruralControlGame
<p>This project is a gesture-controlled game that leverages MediaPipe's hand-tracking solution to create dynamic interactions between a particle system and a player’s hand movements, captured through camera input. The game responds to the player’s gestures, creating an immersive experience where virtual particles interact in real-time with the hand's motion, adding a sense of control over the environment. </p>

<h3> How to use </h3>
<p> - The game scene is located in: Assets/MediaPipeUnity/Samples/Scenes/Hand Tracking </p>
<p> - A detailed setup and usage tutorial can be found [here] (https://docs.google.com/document/d/1xZUi6wgtHe7gNXyvabZyk1M_NbhicoJHUrs2kmHQInA/edit?usp=sharing)</p>

<h3>My Contributions </h3>
<h5>1. Genesis Script: </h5>
<p> File: "GesteruralControlGame/Assets/MediaPipeUnity/Samples/Scenes/Hand Tracking/Genesis.cs". </p>
<p> Description: In the Genesis script, I set up the foundational framework for tracking and visualizing hand gestures by capturing the positions of the thumb and index finger in real time. I created spherical objects in Unity to represent these two fingers visually and implemented code to update their positions based on hand-tracking data. Using linear interpolation, the script maps MediaPipe’s raw coordinates to the Unity scene, ensuring smooth and accurate movement of the spheres that mirror the player’s hand gestures. </p>

<h5>2. Oscillator Script: </h5>
<p> File: "GestureControlGame/Assets/MediaPipeUnity/Samples/Scenes/Hand Tracking/Oscillator.cs" </p>
<p> Description: I implemented a dynamic particle system where spherical particles oscillate in a circular pattern. The script initializes a customizable number of particles, each with a random color and a set scale, to create visual variety. Each particle’s movement is controlled by oscillating functions based on trigonometric calculations, distributing them evenly in a circular formation around a central point. Using adjustable parameters for speed, width, and height, the script allows for flexible oscillation patterns, providing a visually engaging and responsive interaction that complements the hand-tracking gestures within the game. This oscillating motion is calculated and updated each frame, producing smooth, continuous movement that enhances the immersive experience. </p>

<h5>3. Collision Detection Script: </h5>
<p> File: "GestureControlGame/Assets/MediaPipeUnity/Samples/Scenes/Hand Tracking/Collision.cs" </p>
<p> Description: I implemented methods to detect and handle interactions between the player’s fingers, tracked as a virtual object, and specific target objects in the game, represented by particles. The script calculates the distance between the finger position and nearby particles, checking if the player’s finger is close enough to trigger an interaction. Upon contact, the script initiates an action, switching to a new scene. By creating an interactive element that responds to physical gestures, this Collision script deepens the gameplay by integrating intuitive touch-based triggers. </p>

<h5>4. Hand Tracking Solution Script: </h5>
<p> File: "GestureControlGame/Assets/MediaPipeUnity/Samples/Scenes/Hand Tracking/HandTrackingSolution.cs" </p>
<p> Description: I implemented the OnHandLandmarksOutput() method, which extracts the real-time x and y coordinates of the player’s thumb and index finger from the hand-tracking data. These coordinates are then used to update the Genesis script, allowing the virtual thumb and index finger in the game to follow the player’s hand movements with high accuracy. This function links live hand-tracking data to Unity objects, allowing for gesture recognition and interaction within the game. </p>



 
