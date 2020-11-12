using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    public Camera cam;
    private MeshRenderer material;
    public Material material1;


    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit))
        {
            //Debug.Log(hit.transform.name);


            if (hit.collider.tag == "James")
            {
                //Debug.Log("Hello World");

                hit.collider.gameObject.GetComponent<MeshRenderer>().material = material1;

              
                {
                    GameObject.Find("Timer").GetComponent<Timer>().WinFunction();
                }
                //play Sound on hit
                AudioManager.instance.PlaySound("ObjectChange");

                

            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //print("HelloWorld");
            Shoot();
        }
    }
}
