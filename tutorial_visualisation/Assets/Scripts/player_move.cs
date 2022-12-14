using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    public float speed = 2.0f;
    public float horizontalSpeed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {      
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.UpArrow))
            transform.position += transform.forward * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.DownArrow))
            transform.position -= transform.forward * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.LeftArrow))
            transform.position -= transform.right * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.RightArrow))
            transform.position += transform.right * speed * Time.deltaTime;
            
        gameObject.transform.eulerAngles = new Vector3 (0, gameObject.transform.eulerAngles.y, 0);

        h = horizontalSpeed * Input.GetAxis("Mouse X");

        gameObject.transform.Rotate(0, h, 0);
    }
}
