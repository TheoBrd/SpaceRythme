using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum PlanetType
{
    red,
    blue,
    white
};

public class NoteBehavior : MonoBehaviour
{
    public float NoteSpeed = 0.06f;
    public PlanetType planetType;

    private void Start()
    {
        if (planetType == PlanetType.red)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        else if (planetType == PlanetType.blue)
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (planetType == PlanetType.white)
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.06f);
    }
}
