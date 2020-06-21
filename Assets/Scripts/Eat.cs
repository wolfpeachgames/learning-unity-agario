using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{
    public string Tag;
    public float increase;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == Tag)
        {
            transform.localScale += new Vector3(increase, increase, increase);
            Destroy(other.gameObject);
        }
    }
}
