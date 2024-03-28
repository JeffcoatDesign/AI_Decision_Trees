using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Door door;
    public Transform inFrontOfDoor;
    public Transform goal;
    Task main;
    void Start()
    {
        Task openDoor = new OpenDoor(door);
        Task checkDoorClosed = new CheckForFalse(door.isOpen);
        Task checkDoorOpen = new CheckForTrue(door.isOpen);
        Task checkDoorNotLocked = new CheckForFalse(door.isLocked);
        Task goToRoom = new GoTo(transform, goal);
        Task goToDoor = new GoTo(transform, inFrontOfDoor);

        Sequence doorOpen = new ();
        doorOpen.children.Add(checkDoorOpen);
        doorOpen.children.Add(goToRoom);

        Sequence checkLock = new Sequence();
        checkLock.children.Add(checkDoorNotLocked);
        checkLock.children.Add(openDoor);

        Sequence checkBarge = new Sequence();
        checkBarge.children.Add(checkDoorClosed);
        checkBarge.children.Add(new Barge(door));

        Selector checkDoor = new Selector();
        checkDoor.children.Add(checkLock);
        checkDoor.children.Add(checkBarge);

        Sequence doorNotOpen = new Sequence();
        doorNotOpen.children.Add(goToDoor);
        doorNotOpen.children.Add(checkDoor);
        doorNotOpen.children.Add(goToRoom);

        Selector mainSelector = new Selector();
        mainSelector.children.Add(doorOpen);
        mainSelector.children.Add(doorNotOpen);

        main = mainSelector;
    }

    public void Run()
    {
        main.Run();
    }
}
