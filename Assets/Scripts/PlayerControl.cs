using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerControl : MonoBehaviour
{
    public float Speed = 5f;

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");

        Vector3 dir = new Vector3(h, 0);

        if(dir.magnitude > 1)
        {
            dir.Normalize();
        }

        transform.position += dir * Speed * Time.deltaTime;
        
    }

}