using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankDestroyed : MonoBehaviour
{
    public GameObject turret;
    public GameObject fire_fx;
    // Start is called before the first frame update
    void Start()
    {
        // Get Cube.017 object as turret
        turret = GameObject.Find("Cube.017");
        // Get fire_fx object
        fire_fx = GameObject.Find("Fx_OilSplashHIGH_Root");
    }

    // Update is called once per frame
    void Update()
    {
        // If spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Apply force to turret
            turret.GetComponent<Rigidbody>().AddForce(100, 800, 200);
            // Apply torque to turret
            turret.GetComponent<Rigidbody>().AddTorque(30, 20, 50);
            // Enable gravity on turret
            turret.GetComponent<Rigidbody>().useGravity = true;
            // Start Particle System
            fire_fx.GetComponent<ParticleSystem>().Play();
            Debug.Log("Direct Hit!");
        }
    }
}
