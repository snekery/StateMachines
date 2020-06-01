# StateMachines

A Unity package that allows you to create finite state machines in Unity.

## Why?

1. Because I'd like to.
2. By creating a package, it's a lot easier to import this into a project.

## How do I install?

This package was technically created in 2019.3, but it's not really doing anything that isn't possible in 2018.3. Just copy the link to this Git repository and add it to the Unity Package Manager (through the GUI or through the manifest, whatever suits your fancy). After that, voila! You can now use state machines.

## Okay, so how do I use it?

Stupid simple, really:
1. Import it! Everything is under the namespace ElementStudio.StateMachines, so go ahead and use this line to do it:
```C#
using ElementStudio.StateMachines;
```
2. Create a StateMachine object somewhere in your code:
```C#
StateMachine stateMachine;
```
3. Initialize your StateMachine with a State:
```C#
stateMachine.Initialize(new State(stateMachine));
```
The StateMachine is passed in so the State can make changes to it.
4. Create new classes that extend the State class in order to create your own states!
```C#
using ElementStudio.StateMachines;

public class RadicalState : State {
    public override void PhysicsUpdate(float delta) {
        base.PhysicsUpdate(delta);
    }
}
```

## Anything else I need to know?

You can use StateMachine as is, but I'd highly recommend extending from it in order to implement your own properties. Maybe you want to use it on AI and you need to keep track of the AI object, or you're using it on the player and you need to change things about your player. I've not done any of that in this repository, so it's up to you to implement that. Also, cheers!
