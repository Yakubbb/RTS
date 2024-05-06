using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Unity.IO.LowLevel.Unsafe;

public class CameraController : MonoBehaviour
{
    public CinemachineVirtualCamera VCamera; 
    public float MouseSens = 1000;
    public float KeyboardSens = 1000;
    public float RotationSens = 5 ;
    public float ZoomSens  = 3;
    void Start(){
        
    }
    void Update()
    {
        float z = 0;
        float x = 0;
        if(Input.GetKey(KeyCode.Q)){
            VCamera.transform.rotation = Quaternion.Euler(VCamera.transform.eulerAngles.x,VCamera.transform.eulerAngles.y -  RotationSens * Time.deltaTime ,VCamera.transform.eulerAngles.z);
            }
        else if(Input.GetKey(KeyCode.E)){
                        VCamera.transform.rotation = Quaternion.Euler(VCamera.transform.eulerAngles.x,VCamera.transform.eulerAngles.y +  RotationSens * Time.deltaTime ,VCamera.transform.eulerAngles.z);
        }


        if(Input.GetMouseButton(2)){    

        float mouseX = Input.GetAxis("Mouse X")  / Screen.width  * MouseSens;
        float mouseZ = Input.GetAxis("Mouse Y") / Screen.height * MouseSens; 

        if(VCamera.transform.position.z - mouseZ > -10 && VCamera.transform.position.z - mouseZ < 950){
            z = -mouseZ;
        }
        if(VCamera.transform.position.x - mouseX > 15 && VCamera.transform.position.x - mouseX < 1000){
            x = -mouseX;
        }
        }
        else{
        float keyX = Input.GetAxis("Horizontal") / Screen.width * KeyboardSens; 
        float keyZ = Input.GetAxis("Vertical") / Screen.height * KeyboardSens; 
        Debug.Log(keyX);
        Debug.Log(keyZ);
        if(VCamera.transform.position.z + keyZ > -10 && VCamera.transform.position.z + keyZ < 950){
            z = +keyZ;
        }
        if(VCamera.transform.position.x + keyX > 15 && VCamera.transform.position.x + keyX < 1000){
            x = keyX;
        }

        }
        Vector3 transformVector = Quaternion.Euler(new Vector3(0, VCamera.transform.eulerAngles.y, 0)) * new Vector3(x, 0, z);
        VCamera.transform.position += transformVector;


        float scale = VCamera.m_Lens.OrthographicSize - Input.GetAxis("Mouse ScrollWheel") * ZoomSens;
        if(scale <= 22 && scale >= 5){
            VCamera.m_Lens.OrthographicSize = scale;
        }

    }
}
