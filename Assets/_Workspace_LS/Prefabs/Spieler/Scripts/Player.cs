using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float walkSpeed = 6f;
    public float speedSmoothing = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
       // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis ("Vertical");
		movement *= Time.deltaTime;

		this.transform.Translate 
		(Vector3.forward * walkSpeed * movement);
         
        transform.rotation = Quaternion.identity;
        
        if(Input.GetKey(KeyCode.Space))
            transform.Translate(Vector3.up * walkSpeed * Time.deltaTime);
        
    }
}
