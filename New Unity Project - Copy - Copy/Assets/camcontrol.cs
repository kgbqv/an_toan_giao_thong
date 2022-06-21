using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camcontrol : MonoBehaviour
{
    public GameObject player;
    public float xpos;
    public float ypos;
    public float zpos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = player.transform.position + player.transform.forward.normalized * zpos + new Vector3(0,ypos,0);
        transform.eulerAngles = player.transform.eulerAngles;
    }
}
