using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class HoleController : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
    private FloatingJoystick _floatingJoystick;
    [SerializeField] private float speed;

    private void Awake()
    {
        _floatingJoystick = FindObjectOfType<FloatingJoystick>();
    }

    private void FixedUpdate()
    {
        rigidbody.velocity = new Vector3(_floatingJoystick.Horizontal * speed,
            0, _floatingJoystick.Vertical * speed);
    }
}