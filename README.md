# robloxmultiinstance
An C# application designed to allow multiple instances of Roblox.

## How does it work?
It uses this line of code,

```new Mutex(Running,"ROBLOX_singletonMutex");```

to disable Roblox's limitations on the number of instances.
