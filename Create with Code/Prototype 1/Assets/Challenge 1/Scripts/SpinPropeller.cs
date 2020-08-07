using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(Vector3., Time.deltaTime * 1000);
        transform.Rotate(0, 0, Random.Range(0f, 360f));
    }
}
