# UnityHelpers
A set of utilities for Unity game engine.

Adds some useful menus under "Unity Helpers", such as:

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

The package should work with Unity 2019.1 and above under .NET 4.x or Standard. You can reference it as a Git dependency with URL <https://github.com/nick-morhun/UnityHelpers.git?path=/Packages/NickMorhun/UnityHelpers>.
