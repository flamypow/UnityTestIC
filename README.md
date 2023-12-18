Hello,
This is one of the results of a test. 
here are the requirements:
UNITY TEST:

- You *must* use Unity 2021.3.16f1 (LTS) with the built-in pipeline.
- Your project *must* build and run correctly for *both* Windows/PC and Android.
- You are not required to spend more than 1 hour on the task, and you will not be penalized if you do not finish 
the task in 1 hour, but you are welcome to spend additional time as you prefer.

- Do not use any additional assets beyond what Unity provides when creating a new project.
-- This restriction includes (but is not limited to-) textures, models, sounds, and plugins.
-- The only exceptions are the Post-Processing, TextMeshPro, and Shader Graph packages from the Package Manager.

- You *must* submit as a repository using either GitHub or GitLab.
-- Make sure to use the appropriate .gitignore for Unity projects.

- You may ask for clarification if needed.

Conceptual Application Structure:

- Home Scene
-- Content Scene 1
-- Content Scene 2
-- Content Scene 3

The above is only a summary of the application's navigational structure.
These scenes may be implemented as actual Unity scenes, or GameObjects that are toggled on/off, or however else you see fit.

- Each scene should have a title somewhere so we know where we currently are in the app.

- Between each scene *must* be a transition. It's up to you what this is. Cross-fade, fade-in/fade-out, dissolve, etc. 
-- The transition itself can be the same between all scenes.

- Add animations anywhere as you see fit.
- Add post-processing as you see fit. You may use an HDR camera.

The prettier things look, the better.

Home Scene:

- Contains the name of the project (whatever you want), and your full name.
- Must have a button to progress to the main content scenes.

Content Scenes:

- Must have a button to return to the home scene in the top left corner of the screen.
- Must have buttons to *cycle* through all content scenes, being able to go backwards and forward.

- There must be anywhere between 2-5 unique 3D objects that can be clicked/tapped to toggle an active/inactive state.
-- Here, active/inactive refers to the object's *visual* state, not the state of the GameObject.
-- All objects when entering a scene are inactive by default, even if they were previously active when leaving the scene.
-- Active objects should be clearly differentiated from their inactive state.
-- Activating/deactivating an object should show/hide some kind of label revealing the name of the object near the object itself.
-- Only one object can be active in the current scene at any given time.
-- If you interact with another object, the current active object (if any) will revert to being inactive.
-- Interacting with an object (at the moment when you click/tap on it) should produce some kind of visual effect.

Include a brief written summary about your project which should draw our attention to anything specific you 
want us to take a look at that may impress us or explain your thought process (choice of implementation).
If you were unable to complete the application in the allotted time, please describe your plan of attack 
(how you would continue to develop the application if you were to continue) in this summary.
You may write down any assumptions in this summary.
