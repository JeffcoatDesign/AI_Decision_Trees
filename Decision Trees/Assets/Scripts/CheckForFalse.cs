using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForFalse : Task
{
    bool value;
    public CheckForFalse (bool value)
    {
        this.value = value;
    }
    public override TaskStatus Run()
    {
        return !value ? TaskStatus.Completed : TaskStatus.Failed;
    }
}