using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Task
{
    public abstract TaskStatus Run();
}

public enum TaskStatus
{
    Running,
    Completed,
    Failed
}