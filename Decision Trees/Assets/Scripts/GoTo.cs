using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoTo : Task
{
    Transform character;
    Transform target;
    public GoTo (Transform character, Transform target)
    {
        this.character = character;
        this.target = target;
    }
    public override TaskStatus Run()
    {
        if (character == null || target == null) return TaskStatus.Failed;
        character.transform.position = target.position;
        return TaskStatus.Completed;
    }
}
