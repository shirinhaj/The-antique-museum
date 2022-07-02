using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imageviewer : MonoBehaviour
{
    public int numOFCurrentImage;

    public List<Material> materials = new List<Material>();

    public GameObject screen;

    public void PreviousFunc()
    {
        if(numOFCurrentImage >= 1)
        {
            numOFCurrentImage--;
            screen.GetComponent<Renderer>().material = materials[numOFCurrentImage];
        }
    }

    public void NextFunc()
    {
        if(numOFCurrentImage < materials.Count -1)
        {
            numOFCurrentImage++;
            screen.GetComponent<Renderer>().material = materials[numOFCurrentImage];
        }
    }

}
