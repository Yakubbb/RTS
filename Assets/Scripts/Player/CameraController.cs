using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Unity.IO.LowLevel.Unsafe;

public class CameraController : MonoBehaviour
{
    public Transform VCamera; 

    void Update()
    {

        if(Input.GetMouseButton(2)){        
        float mouseX = Input.GetAxis("Mouse X");
        float mouseZ = Input.GetAxis("Mouse Y") * 1.5f;
        
        Debug.Log(mouseX + " " + mouseZ);

        float z = VCamera.transform.position.z - mouseZ > -10 && VCamera.transform.position.z - mouseZ < 950?VCamera.transform.position.z-mouseZ:VCamera.transform.position.z;
        float x = VCamera.transform.position.x - mouseX > 15 && VCamera.transform.position.x - mouseX < 1000?VCamera.transform.position.x - mouseX:VCamera.transform.position.x;

        VCamera.transform.position = new Vector3(x, VCamera.transform.position.y,z);
        }

    }
}
