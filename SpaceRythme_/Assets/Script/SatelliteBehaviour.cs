using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


enum ShipSide
{
    right,
    left
};

public class SatelliteBehaviour : MonoBehaviour
{
    private ShipSide side;

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
            side = ShipSide.right;
        }
        else if (name == "Satellite2")
        {
            transform.position = parentPosition - new Vector3(mScript.GetDistance(), 0, 0);
            GetComponent<Renderer>().material.color = Color.blue;
            side = ShipSide.left;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void ReverseShipSide()
    {
        if(side == ShipSide.left)
        {
            side = ShipSide.right;
        }
        else
        {
            side = ShipSide.left;
        }
    }

}


