using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{
    public Animator animator;
    public Animator colorAnimator;
    public Text panelButtonLabel;
    private bool isPanelOpen = false;
    private bool isColorPanelOpen = false;

    private void Start()
    {
        Screen.orientation = ScreenOrientation.Landscape;
    }

    public void ChangePanelVisibility()
    {
        isPanelOpen = !isPanelOpen;
        animator.SetBool("Show", isPanelOpen);
        panelButtonLabel.text = isPanelOpen ? "<" : ">";
    }

    public void ChangeColorPanelVisibility()
    {
        isColorPanelOpen = !isColorPanelOpen;
        colorAnimator.SetBool("Open", isColorPanelOpen);
    }
}
