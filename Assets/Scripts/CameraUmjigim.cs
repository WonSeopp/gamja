using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraUmjigim : MonoBehaviour
{
    public GameObject player;
    
    public int roomNum = 0;

    public GameObject yaho;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    private void Update()
    {
        if (player.transform.position.x >= 9.4f)
        {
            yaho.transform.position = new Vector3(18, 0, -10);
        }
        else
        {
            yaho.transform.position = new Vector3(0, 0, -10);
        }
    }
}
