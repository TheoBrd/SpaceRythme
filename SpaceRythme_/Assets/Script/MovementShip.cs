using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MovementShip : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        GetComponent<Renderer>().material.color = Color.green;

    }


    // Update is called once per frame
    void Update()
    {
        Vector3 nextSatellitePosition = new Vector3();
        SpacePlane planeScipt = transform.parent.GetComponent<SpacePlane>();
        GameObject satel1 = transform.GetChild(0).gameObject;
        GameObject satel2 = transform.GetChild(1).gameObject;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            nextSatellitePosition = this.transform.position - new Vector3(2* planeScipt.GetDistance(), 0, 0);
            if (nextSatellitePosition.x > planeScipt.GetCorners(3).x)
            {
                this.transform.position -= new Vector3(planeScipt.GetDistance(), 0, 0);
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            nextSatellitePosition = this.transform.position + new Vector3(2* planeScipt.GetDistance(), 0, 0);
            if (nextSatellitePosition.x < planeScipt.GetCorners(2).x)
            {
                this.transform.position += new Vector3(planeScipt.GetDistance(), 0, 0);
            }
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 tempPos = satel1.transform.position;
            satel1.transform.position = satel2.transform.position;
            satel2.transform.position = tempPos;
            satel1.GetComponent<SatelliteBehaviour>().ReverseShipSide();
            satel2.GetComponent<SatelliteBehaviour>().ReverseShipSide();

        }

    }


}
