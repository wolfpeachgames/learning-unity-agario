using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public float speed;
    public float sizeSpeedMultiplier;


    // Start is called before the first frame update
    void Start() { }


    // Update is called once per frame
    void Update()
    {
        Vector3 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target.z = transform.position.z;

        //float movementSpeed = speed * Time.deltaTime * (transform.localScale.x * sizeSpeedMultiplier);
        float movementSpeed = speed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, target, movementSpeed);
    }
}
