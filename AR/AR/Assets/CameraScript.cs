using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CameraScript : MonoBehaviour
{ // Start is called before the first frame update
    public GameObject webCameraPlane;
   public Button fireButton;

    void Start()
    {

 if (Application.isMobilePlatform) {
      GameObject cameraParent = new GameObject ("camParent");
      cameraParent.transform.position = this.transform.position;
      this.transform.parent = cameraParent.transform;
      cameraParent.transform.Rotate (Vector3.right, 90);
    }

//Input.gyro.enabled = 
    Input.gyro.enabled = true;

  fireButton.onClick.AddListener (fire);


        WebCamTexture webCameraTexture = new WebCamTexture();
        webCameraPlane.GetComponent<MeshRenderer>().material.mainTexture = webCameraTexture;
        webCameraTexture.Play();
    }


  void fire(){

    GameObject bullet = Instantiate(Resources.Load("bullet", typeof(GameObject))) as GameObject;
    Rigidbody rb = bullet.GetComponent<Rigidbody>();
    bullet.transform.rotation = Camera.main.transform.rotation;
    bullet.transform.position = Camera.main.transform.position;
    rb.AddForce(Camera.main.transform.forward * 500f);
    Destroy (bullet, 3);

    GetComponent<AudioSource>().Play ();
  }



    // Update is called once per frame
    void Update()
    {
         Quaternion cameraRotation = new Quaternion (Input.gyro.attitude.x, Input.gyro.attitude.y, -Input.gyro.attitude.z, -Input.gyro.attitude.w);
    this.transform.localRotation = cameraRotation;

    if (GameObject.FindGameObjectsWithTag("GameController").Length == 0){
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      
    }

    }
}
