using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskIrAPunto : MonoBehaviour
{

    public Transform[] Waypoint;
    public float Rapidez;
    public int WaypointActual;
    public bool HacerPatrulla = true;
    public Vector3 Objetivo;
    public Vector3 DireccionMov;
    public Vector3 Velocidad;
    public Transform[] DetectarDistancia;
    public float RangoDetección;
    public Transform[] DistanciaObjetivo;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (WaypointActual < Waypoint.Length)
        {
            Objetivo = Waypoint[WaypointActual].position;
            DireccionMov = Objetivo - transform.position;
            Velocidad = GetComponent<Rigidbody>().velocity;

            if (DireccionMov.magnitude < 1)
            {
                WaypointActual++;
            }

            else
            {
                Velocidad = DireccionMov.normalized * Rapidez;
            }

        }
        else
        {
            if (HacerPatrulla)
            {
                WaypointActual = 0;

            }

            else
            {
                Velocidad = Vector3.zero;

            }


        }

        GetComponent<Rigidbody>().velocity = Velocidad;
        transform.LookAt(Objetivo);





    }


}