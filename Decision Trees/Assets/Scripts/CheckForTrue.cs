using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForTrue : Task
{
    bool value;
    public CheckForTrue (bool value)
    {
        this.value = value;
    }
    public override TaskStatus Run()
    {
        return value ? TaskStatus.Completed : TaskStatus.Failed;
    }
}