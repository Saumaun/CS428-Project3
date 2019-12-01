using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorModifier : MonoBehaviour
{

    public MeshRenderer Object;
    public MeshRenderer Object2;
    public MeshRenderer Object3;
    public MeshRenderer Object4;
    public MeshRenderer Object5;
    public MeshRenderer Object6;
    public MeshRenderer Object7;
    public MeshRenderer Object8;
    public MeshRenderer Object9;
    public MeshRenderer Object10;
    public MeshRenderer Object11;
    public MeshRenderer Object12;
    public MeshRenderer Object13;
    public Slider red_slider;
    public Slider green_slider;
    public Slider blue_slider;
    public Slider red_slider2;
    public Slider green_slider2;
    public Slider blue_slider2;


    public void OnChange()
    {
        Color color = Object.material.color;
        color.r = red_slider.value;
        color.g = green_slider.value;
        color.b = blue_slider.value;
        Object.material.color = color;
        Object.material.SetColor("_EmissionColor", color);
        Object2.material.color = color;
        Object2.material.SetColor("_EmissionColor", color);
        Object3.material.color = color;
        Object3.material.SetColor("_EmissionColor", color);
        Object4.material.color = color;
        Object4.material.SetColor("_EmissionColor", color);
        Object5.material.color = color;
        Object5.material.SetColor("_EmissionColor", color);
        Object6.material.color = color;
        Object6.material.SetColor("_EmissionColor", color);
        Object7.material.color = color;
        Object7.material.SetColor("_EmissionColor", color);
        Object8.material.color = color;
        Object8.material.SetColor("_EmissionColor", color);
        Object9.material.color = color;
        Object9.material.SetColor("_EmissionColor", color);
        Object10.material.color = color;
        Object10.material.SetColor("_EmissionColor", color);
        Object11.material.color = color;
        Object11.material.SetColor("_EmissionColor", color);
        Object12.material.color = color;
        Object12.material.SetColor("_EmissionColor", color);
        Object13.material.color = color;
        Object13.material.SetColor("_EmissionColor", color);
    }

    public void OnChange2()
    {
        Color color = Object.materials[1].color;
        color.r = red_slider2.value;
        color.g = green_slider2.value;
        color.b = blue_slider2.value;
        Object.materials[1].color = color;
        Object.materials[1].SetColor("_EmissionColor", color);
        Object2.materials[1].color = color;
        Object2.materials[1].SetColor("_EmissionColor", color);

    }
}
