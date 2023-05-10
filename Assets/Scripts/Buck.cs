using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buck : MonoBehaviour
{
    public GameObject player;
    public GameObject camera;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        camera.transform.position = new Vector3(25, 0, -10);
        player.transform.position = new Vector3((float)18, player.transform.position.y, 0);
        
    }
}
