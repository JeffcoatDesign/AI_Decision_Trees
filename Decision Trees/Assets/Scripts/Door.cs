using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool isOpen;
    public bool isLocked;

    private void Start()
    {
        if (isOpen)
            transform.rotation = Quaternion.Euler(0, 75, 0);
    }

    public void Barge()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0, 100, -10), ForceMode.VelocityChange);
    }

    public bool Open () {
        if (isLocked) return false;
        isOpen = true;
        transform.rotation = Quaternion.Euler(0, 75, 0);
        return true;
    }

    public void SetIsOpen(bool isOpen)
    {
        this.isOpen = isOpen;
        if (isOpen) transform.rotation = Quaternion.Euler(0, 75, 0);
        else transform.rotation = Quaternion.identity;
    }

    public void SetIsLocked (bool isLocked) => this.isLocked = isLocked;
}
