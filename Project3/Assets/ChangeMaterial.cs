using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public MeshRenderer Object;
    public MeshRenderer Object2;
    public Material mat;

    public void ChangeWhite()
    {
        Object.materials[1].color = Color.white;
        Object2.material.color = Color.white;
    }

    public void ChangeBlack()
    {
        Object.materials[1].color = Color.black;
        Object2.material.color = Color.black;
    }

    public void ChangeBlue()
    {
        Object.materials[1].color = Color.blue;
        Object.material.color = Color.blue;
    }
    public void ChangeGray()
    {
        Object.materials[1].color = Color.gray;
        Object2.material.color = Color.gray;
    }

    public void ChangeCustom()
    {
        Object.materials[1].color = Color.black;
        Object2.material.color = Color.black;
    }
}
