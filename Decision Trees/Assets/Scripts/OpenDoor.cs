using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : Task
{
    Door door;
    public OpenDoor(Door door)
    {
        this.door = door;
    }
    public override TaskStatus Run()
    {
        if (door == null) return TaskStatus.Failed;
        if (!door.Open()) return TaskStatus.Failed;
        return TaskStatus.Completed;
    }
}
