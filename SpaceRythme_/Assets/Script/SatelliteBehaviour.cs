using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


enum SatelliteType
{
    red,
    blue
};

public class SatelliteBehaviour : MonoBehaviour
{
    private SatelliteType side;

    // Start is called before the first frame update
    void Start()
    {
        SpacePlane mScript = transform.parent.gameObject.transform.parent.GetComponent<SpacePlane>();
        Vector3 parentPosition = transform.parent.position;

        print(mScript.GetDistance());
        if (name == "Satellite1")
        {
            transform.position = parentPosition + new Vector3(mScript.GetDistance(), 0, 0);
            GetComponent<Renderer>().material.color = Color.red;
            side = SatelliteType.red;
        }
        else if (name == "Satellite2")
        {
            transform.position = parentPosition - new Vector3(mScript.GetDistance(), 0, 0);
            GetComponent<Renderer>().material.color = Color.blue;
            side = SatelliteType.blue;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void ReverseShipSide()
    {
        if(side == SatelliteType.blue)
        {
            side = SatelliteType.red;
        }
        else
        {
            side = SatelliteType.blue;
        }
    }

}


