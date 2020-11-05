using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControlScript : MonoBehaviour
{
    public GameObject UpCube;
    public GameObject DownCube;
    public GameObject LeftCube;
    public GameObject RightCube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Up Key
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {          
            UpCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {         
            UpCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            UpCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            UpCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        // Down Key
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {        
            DownCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {           
            DownCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            DownCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            DownCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }


        // Left key
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {           
            LeftCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {           
            LeftCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            LeftCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            LeftCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }


        // Right Key
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {           
            RightCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {     
            RightCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            RightCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            RightCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }
    }
}
