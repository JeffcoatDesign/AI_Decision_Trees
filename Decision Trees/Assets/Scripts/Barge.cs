using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barge : Task
{
    Door door;
    public Barge (Door door)
    {
        this.door = door;
    }

    public override TaskStatus Run()
    {
        if (door == null) return TaskStatus.Failed;
        door.Barge();
        return TaskStatus.Completed;
    }
}
