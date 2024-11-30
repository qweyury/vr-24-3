using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
//using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
public class NewBehaviourScript : MonoBehaviour
{
//    public GameObject Test;
    public int x = 0;
    public Text Mytxt;
    public int z;
    public int y;
    public int c;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     //   x++;
        
        if (x >= 100) this.gameObject.SetActive(false);
        Mytxt.text = x.ToString();


    }
    public void OnCollisionEnter(Collision collision)
    {
        x++;
        z = Random.Range(0, 255);
        y = Random.Range(0, 255);
        c = Random.Range(0, 255);
        this.GetComponent<Renderer>().material.color = new Color32((byte)z, (byte)y,(byte)c,1);
    }


}

