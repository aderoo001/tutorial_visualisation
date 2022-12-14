using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move : MonoBehaviour
{
    public float hSpeed = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        float h = hSpeed * Input.GetAxis("Mouse Y");

        gameObject.transform.Rotate(-h, 0, 0);
    }
}
