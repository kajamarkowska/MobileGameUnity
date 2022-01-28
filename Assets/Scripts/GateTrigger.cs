using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class GateTrigger : MonoBehaviour
{
    [SerializeField] private GameObject goalEffect;
    [SerializeField] private Transform effectParent;

    public PostProcessVolume processVolume;
    private Vignette vignette;
    private ColorGrading colorGrading;

    private GameObject currentEffect;

    private void Start()
    {
        processVolume.profile.TryGetSettings(out vignette);
        processVolume.profile.TryGetSettings(out colorGrading);
        colorGrading.active = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            currentEffect = Instantiate(goalEffect, effectParent);
            colorGrading.active = true;
            vignette.active = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if(currentEffect != null)
            {
                vignette.active = true;
                colorGrading.active = false;
                Destroy(currentEffect);
            }
        }
    }
}
