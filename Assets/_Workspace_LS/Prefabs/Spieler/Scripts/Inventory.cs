using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    [SerializeField] public float Holz;
    [SerializeField] public float Stein;
    void Awake()
    {
        instance = this;
    }
    public void setHolzPlus1()
    {
        Holz++;
    }
    public void setSteinPlus1()
    {
        Stein++;
    }
    public void setHolzMinus1()
    {
        Holz--;
    }
    public void setSteinMinus1()
    {
        Stein--;
    }
    public float getHolz()
    {
        return Holz;
    }
    public float getStein()
    {
        return Stein;
    }
}
