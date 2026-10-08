using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(Keycode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(Keycode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        if (Input.GetKeyDown(Keycode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(Keycode.P))
        {
            GetComponent<Renderer>().material.color = Color.pink;
        }
        if (Input.GetKeyDown(Keycode.W))
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
        if (Input.GetKeyDown(Keycode.T))
        {
            GetComponent<Renderer>().material.color = Color.turqouise;
        }
        if (Input.GetKeyDown(Keycode.P))
        {
            GetComponent<Renderer>().material.color = Color.purple;
        }
    }
