using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{
    [SerializeField] public bool Active = false;
    public GameObject Inventar;
    // Start is called before the first frame update
    void Start()
    {
      //  gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)) 
        {
            Active = !(Active);
            Inventar.SetActive(Active);
        } 

    }  
}
