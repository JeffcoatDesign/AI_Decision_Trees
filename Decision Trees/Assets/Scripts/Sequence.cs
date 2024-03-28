using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequence : Task
{
    public List<Task> children = new();

    public override TaskStatus Run()
    {
        foreach (var child in children)
        {
            if (child.Run() == TaskStatus.Failed)
                return TaskStatus.Failed;
        }
        return TaskStatus.Completed;
    }
}
