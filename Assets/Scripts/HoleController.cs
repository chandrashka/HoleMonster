using Packages.Joystick_Pack.Scripts.Joysticks;
using UnityEngine;

public class HoleController : MonoBehaviour
{
    [SerializeField] private new Rigidbody rigidbody;
    private FloatingJoystick floatingJoystick;
    [SerializeField] private float speed;

    private void Start()
    {
        floatingJoystick = FindObjectOfType<FloatingJoystick>();
    }

    private void FixedUpdate()
    {
        var newVelocity = new Vector3(floatingJoystick.Horizontal * speed,
            0, floatingJoystick.Vertical * speed);
        rigidbody.velocity = newVelocity;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer != LayerMask.NameToLayer("Collectables")) return;
        other.isTrigger = false;
        other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
    }
}