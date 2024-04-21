using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    // GameObject (Player)
        // Transform
        // PlayerController

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            transform.position += new Vector3(0, 0, 1.0f) * Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.S)) 
        {
            transform.position -= new Vector3(0, 0, 1.0f) * Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(1, 0, 0.0f) * Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0.0f) * Time.deltaTime * _speed;
        }
    }
}
