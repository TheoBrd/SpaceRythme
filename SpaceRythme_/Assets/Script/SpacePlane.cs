using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacePlane : MonoBehaviour
{
    // Start is called before the first frame update

    private List<Vector3> m_planeCorners;
    private float m_distance = 3;
    public int m_nbCol;

    void Awake()
    {
        m_planeCorners = new List<Vector3>();
        GetVertices();
        m_distance = Vector3.Distance(m_planeCorners[2], m_planeCorners[3]) / (float)m_nbCol;
    }

    void Start()
    {

    }
    void GetVertices()
    {

        List<Vector3> VerticeListe = new List<Vector3>(GetComponent<MeshFilter>().mesh.vertices);
        m_planeCorners.Clear();
        m_planeCorners.Add(transform.TransformPoint(VerticeListe[0]));
        m_planeCorners.Add(transform.TransformPoint(VerticeListe[10]));
        m_planeCorners.Add(transform.TransformPoint(VerticeListe[110]));
        m_planeCorners.Add(transform.TransformPoint(VerticeListe[120]));


    }
    // Update is called once per frame
    void Update()
    {

    }


    public List<Vector3> PlaneCorners { get => m_planeCorners; }
    public Vector3 GetCorners(int index)
    {

        return m_planeCorners[index];
    }
    public float GetDistance() 
    { 
        return m_distance; 
    }
}

