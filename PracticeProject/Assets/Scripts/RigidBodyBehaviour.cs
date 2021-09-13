using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class RigidBodyBehaviour : MonoBehaviour
{
    private Rigidbody _rb;
    public float force;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.AddExplosionForce(force, Vector3.forward, 30f);
    }
    
}
