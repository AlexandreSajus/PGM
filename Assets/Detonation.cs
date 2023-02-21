using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detonation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // If spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Destroy the object
            Destroy(gameObject);
        }
    }
}
