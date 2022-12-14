using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor_lock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            Cursor.lockState = CursorLockMode.None;
    }
}