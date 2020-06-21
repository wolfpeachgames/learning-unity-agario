using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colour : MonoBehaviour
{
    public List<Material> mats = new List<Material>();


    private void Awake()
    {
        GetComponent<Renderer>().material = mats[Random.Range(0, mats.Count)];
    }
}
