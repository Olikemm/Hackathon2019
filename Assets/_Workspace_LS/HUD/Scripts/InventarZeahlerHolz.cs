using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventarZeahlerHolz : MonoBehaviour
{
    Text ResourcenStand;
    // Start is called before the first frame update
    void Start()
    {
        ResourcenStand = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ResourcenStand.text = "Holz: " + Inventory.instance.getHolz();
    }
}
