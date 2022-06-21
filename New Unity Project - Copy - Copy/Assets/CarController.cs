using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
[RequireComponent(typeof(InputManager))]
public class CarController : MonoBehaviour
{
    public InputManager im;
    public List<WheelCollider> throttleWheels;
    public List<WheelCollider> steeringWheels;
    public float strengthcoefficient =  20000f;
    public float maxturn = 20f;
    public int collected = 0;
    public Transform handle;
    public Rigidbody rb;
    public AudioSource musi;
    public Transform wheel;
    // Start is called before the first frame update
    void Start()
    {
        musi = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        im = GetComponent<InputManager>();
        
    }

    // Update is called once per frame
    public void MouseDown() {
        print('d');
        foreach (WheelCollider wheel in throttleWheels)
        {
            wheel.brakeTorque = 200000000000000000000000f;
            
        }
    }

    public void MouseUp()
    {
        print('u');
        foreach (WheelCollider wheel in throttleWheels)
        {
            wheel.brakeTorque = 0f;
            
        }
    }
    void FixedUpdate()
    {
        
        foreach (WheelCollider wheel in throttleWheels)
        {
            wheel.motorTorque = strengthcoefficient * Time.deltaTime * im.throttle;
        }
        foreach (WheelCollider wheel in steeringWheels)
        {
            wheel.steerAngle = maxturn * im.steer;
        }
        if (im.i > 0 | im.i < 0){
            musi.Play();
        } else {
            musi.Stop();
        }
        
        handle.eulerAngles = new Vector3(0f,im.steer*30+transform.eulerAngles.y,im.steer*-30);
        wheel.Rotate(new Vector3(im.i*2f,0f,0f));
    }
}
