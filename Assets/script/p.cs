using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p : MonoBehaviour
{
    public Transform parents;
    float timeCounter;
    public float distance;
    public float speed;

    void Start()
    {
        transform.parent = parents;
        transform.Rotate(new Vector3(0, 0, 23.5f));
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 20, 0) * speed * Time.deltaTime);
        timeCounter += Time.deltaTime;
        Vector3 pos = new Vector3(Mathf.Cos(timeCounter) * distance, 0, Mathf.Sin(timeCounter)* distance);
        transform.position = pos;
    }
}
