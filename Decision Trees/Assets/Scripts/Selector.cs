using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : Task
{
    public List<Task> children = new();
    public override TaskStatus Run()
    {
        foreach (var child in children)
        {
            if (child.Run() == TaskStatus.Completed)
                return TaskStatus.Completed;
        }
        return TaskStatus.Failed;
    }
}
