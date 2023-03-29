using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(new Vector3(0, 0, 23.5f));





    }
    void Update()
    {
        transform.Rotate(new Vector3(0, 20, 0) * Time.deltaTime);

    }
}
