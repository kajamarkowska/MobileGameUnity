using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMesh : MonoBehaviour
{
    public Mesh mesh;
    private JoystickPlayerController joystickPlayerController;

    private void Awake()
    {
        joystickPlayerController = FindObjectOfType<JoystickPlayerController>();
    }

    public void UseMesh()
    {
        joystickPlayerController.meshFilter.mesh = mesh;
    }
}
