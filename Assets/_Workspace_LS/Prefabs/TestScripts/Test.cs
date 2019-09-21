using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Transform camPilot;
    float heading;
    Vector2 input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        heading += Input.GetAxis("Mouse X") * 100;
        camPilot.rotation = Quaternion.Euler(0,heading,0);

        input = new Vector2 (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        input = Vector2.ClampMagnitude(input, 1);

        transform.position += new Vector3(input.x,0,input.y)*Time.deltaTime*5;
    }
}
