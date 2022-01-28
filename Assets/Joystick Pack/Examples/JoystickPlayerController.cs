using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerController : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;
    public MeshFilter meshFilter;
    public Material playerMaterial;

    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }

    public void SetPlayerColor(Color color)
    {
        playerMaterial.color = color;
    }
}