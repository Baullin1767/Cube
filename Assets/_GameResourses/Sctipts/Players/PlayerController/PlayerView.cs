using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]
public class PlayerView : MonoBehaviour
{
    Animator animator;
    Rigidbody rb;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }


    public void AddVelocity(Vector3 dir)
    {
        rb.velocity = dir;
    }

    public void AddForce(Vector3 dir, ForceMode forceMode)
    {
        rb.AddForce(dir, forceMode);
    }

    public bool SetBoolAnimation(string name, bool state)
    {
        animator.SetBool(name, state);
        return animator.GetBool(name);
    }
}
