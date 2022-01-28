using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPicker : MonoBehaviour
{
    public Image picker;
    private JoystickPlayerController joystickPlayerController;

    private void Start()
    {
        joystickPlayerController = FindObjectOfType<JoystickPlayerController>();
    }

    public void SetColor()
    {
        joystickPlayerController.SetPlayerColor(picker.color);
    }
}
