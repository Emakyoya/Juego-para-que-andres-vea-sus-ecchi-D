using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskSalto : MonoBehaviour {


    void Jump()
    {

    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Invoke("Jump", 2);
        Invoke("Jump", 2);



    }
   
    
}
