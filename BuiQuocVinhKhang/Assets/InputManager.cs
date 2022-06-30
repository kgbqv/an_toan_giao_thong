
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputManager : MonoBehaviour
{
    public float throttle;
    public float steer;
    float rot;
    public bool pres;
    public FixedJoystick joystick;
    public List<WheelCollider> throttleWheels;
    public float i;
    public Rigidbody rb;
    public float maxSpeed = 2.5f;
    void FixedUpdate ()
    {
        if(rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
    }
    void Update(){
        if ((transform.eulerAngles.z != 0f)){
            transform.eulerAngles = new Vector3(transform.eulerAngles.x,transform.eulerAngles.y,0f);
        }
        if (Math.Round(joystick.Vertical,1,MidpointRounding.ToEven) == 0 & Math.Round(joystick.Horizontal,1,MidpointRounding.ToEven) == 0){
            foreach (WheelCollider wheel in throttleWheels)
            {
                wheel.brakeTorque = 0.0001f;
            
            }
        } else {
            foreach (WheelCollider wheel in throttleWheels)
            {
                wheel.brakeTorque = 00f;
            
            }
        }
        
        float zvel = transform.InverseTransformDirection(rb.velocity).z;
        
        
        
        
        i = (float)Math.Round(joystick.Vertical,1,MidpointRounding.ToEven)*0.5f;
        if (i > 0){
            if (zvel < -2){
                throttle = i*10;
            } else {
                throttle = i;
            }
            
        } else if (i < 0){
            if (zvel > 2){
                throttle = i*7;
            } else {
                throttle = i/1.5f;
            }
        }
        
        steer = (float)(joystick.Horizontal);
        
        
    }
    public void res(){
        Vector3 temp = new Vector3(0,7.0f,0);
        gameObject.transform.position += temp;
        
        
        transform.RotateAround(transform.position,transform.up,180f);
        Debug.Log("Hey!");
    }
}

