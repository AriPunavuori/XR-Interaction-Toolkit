XR-Interaction-Toolkit

Note: For play mode to work needs Oculus desktop app

Installed packages:
- Universal RP
- Input System (Restart editor to enable input system backend)
- XR Plugin Management
- Oculus XR Plugin
- XR Interaction Toolkit + Starter Assets from package samples (Provides default input actions)

Setup project for XR

1. Tracking

- Check Oculus - Plug-in Provider from ProjectSettings/XR Plug-in Management on PC, Mac & Linux standalone settings
- Install XROrigin: Add XROrigin(Action-based) to scene hierarchy from menu (Removes Main Camera from hierarchy)
- Change tracking Origin Mode from XR Origin component to "floor"
- Add Input Action Manager component to XROrigin
- Add XRI Default Input Actions to Input Action Manager components Action Assets
- Choose presets for both left and right hand XR controllers (Under: XROrigin/Camera Offset/...)
- Confirm that camera and controller tracking is working

2. Locomotion_Snap_Turn

- Add locomotion System component to XROrigin
- Add Snap Turn Provider(Action-based) component to XROrigin
- Select preset for Snap Turn Provider, uncheck from left hand
- Confirm that snap turning is working (Thumbstick right)

3. Locomotion_Teleportation

- Add Teleportation component to XROrigin
- Add Teleportation are component to plane
- Confirm that teleporting is working (Triggers with Grip button on both controllers when has valid target)

4. Locomotion_Continuous_Move

- Add Continuous Move Provider(Action-based) component to XROrigin
- Select preset for Continuous Move Provider, uncheck right hand
- Confirm that continuous moving is working (Thumbstick left)

5. Ray_Interaction

- Add Grab Interactable from menu to hierarchy (Position 0, 1.05f, 0.65f)
- Confirm that interactable is working (Point ray to object and push Grip button)

6. Direct_Interaction

- Remove XR Interactor Line Visual, Line Renderer and Ray Interactor components from right hand
- Add Direct Interactor component to right hand
- Add Sphere Collider component to right hand, scale to .1f and set it as a trigger
- Add Sphere gameobject as a child of right hand, scale to .1f and remove Sphere Collider component (Just for visuals)
- Confirm that direct interaction is working (Put controller on object and press Grip button)

7. Direct_Interaction_Advanced

- Scale x on Grab Interactable to .75f
- Try grabbing from edges (Snaps to middle of object)
- Add AdvancedInteraction component to Grab Interactable
- Confirm that grabbing works from all parts of Grab Interactable

8. UI_Interaction

- Create a UI Canvas (XR version; contains Tracked Device Graphic Raycaster)
- Set position to 1.25f on Y-Axis and 2 on the Z-Axis
- Set width and height to 1
- Add UIInteraction component to Canvas GO
- Add TMPro button as a child
- Set the button Rect Transform to stretch from left to right and height to .4f and pos -.25f on Y-Axis
- Set Text Rect Transform to stretch everywhere
- Set font size to .15 
- Add Canvas GO and assign UIInteraction -> BTN_ChangeText method to buttons OnClick
- Confirm button working with left controller (point and pull trigger button)

-------------- Boss Level --------------

9. UI_Interaction_Advanced

- Figure out how gaze UI should work