using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fgd : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 70, player.transform.position.z);
    }
}
