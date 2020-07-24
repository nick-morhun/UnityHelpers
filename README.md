# UnityHelpers
A set of utilities for Unity game engine.

Add some useful menus to the Editor such as:

- Selection/Print Asset Path
- Selection/Print Global Position
- Selection/Ping Inspected Object
- Assets/Upgrade All Assets (allows a single click reserialization of all assets in a new Unity version after an upgrade)
- Other/Open Persistent Data Path (opens the directory in Explorer / Finder).

At runtime:
- AnimationHash can be added to Animator states to see their short name hashes.

Also contains a few extension methods such as:
- GameObject.GetFullName()
- the Component.DestroyObject() overloads.

The project is created in Unity 2019.2.15f1. Tested with Unity 2017.4 and above under .NET 4.x or Standard.
