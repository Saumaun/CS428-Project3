using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorModifier2 : MonoBehaviour
{
    public MeshRenderer Object;
    public MeshRenderer Object2;
    public Slider red_slider;
    public Slider green_slider;
    public Slider blue_slider;


    public void OnChange()
    {
        Color color = Object.materials[1].color;
        color.r = red_slider.value;
        color.g = green_slider.value;
        color.b = blue_slider.value;
        Object.materials[1].color = color;
        Object.materials[1].SetColor("_EmissionColor", color);
        Object2.material.color = color;
        Object2.material.SetColor("_EmissionColor", color);

    }
}
