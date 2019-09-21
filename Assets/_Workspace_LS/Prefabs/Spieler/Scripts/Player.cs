using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /*var anteil = 0.05f; //5% an jeder Kante
    var xSpace = Screen.width * anteil;
    var ySpace = Screen.height * anteil;*/
    public float walkSpeed = 6f;
    public float speedSmoothing = 10f;
    // Start is called before the first frame update
    void Start()
    {
        transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationZ;
        transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX;
    }
       // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.identity;
        if(Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * walkSpeed * Time.deltaTime);
        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
            transform.Translate(Vector3.forward * speedSmoothing * Time.deltaTime);
        if(Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * walkSpeed * Time.deltaTime);
        if(Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * walkSpeed * Time.deltaTime);
        if(Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * walkSpeed * Time.deltaTime);
        if(Input.GetKey(KeyCode.Space))
            transform.Translate(Vector3.up * walkSpeed * Time.deltaTime);
        
    }
}
