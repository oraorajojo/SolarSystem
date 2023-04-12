using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p : MonoBehaviour
{
    public Transform parents;
    float timeCounter;
    public float distance;
    public float rotationSpeed;
    public float revolutionSpeed;
    public float axisOfRotation;

    void Start()
    {
        transform.parent = parents;
        transform.Rotate(new Vector3(0, 0, axisOfRotation));
        distance = transform.position.x;
    }

    void Update()
    {
        Rotation();
        Revolution();
        timeCounter += Time.deltaTime;
    }

    void Rotation()
    {
        transform.Rotate(new Vector3(0, 20, 0) * rotationSpeed * Time.deltaTime);
    }

    void Revolution()
    {
        float x = Mathf.Cos(timeCounter * revolutionSpeed) * distance;
        float z = Mathf.Sin(timeCounter * revolutionSpeed) * distance;

        Vector3 pos = new Vector3(x, 0, z);

        transform.localPosition = pos;

    }
}
