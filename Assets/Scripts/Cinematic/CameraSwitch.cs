// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class CameraSwitch : MonoBehaviour
// {
//     public GameObject cameraOne;
//     public GameObject cameraTwo;
//     private float CinematicTimer = 4.5f;
//     private float ChangeCameraTimer;
//     [SerializeField] private Canvas textExplication;
//     private float timeToDisplayExplication;
//     private bool active = true;

//     void Start()
//     {
//         textExplication.enabled = false;
//     }

//     void Update()
//     {

//         // if (active == true)
//         // {
//         CinematicTimer -= Time.deltaTime;
//         ChangeCameraTimer -= Time.deltaTime;
//         timeToDisplayExplication -= Time.deltaTime;
//         Debug.Log("timeToDisplayExplication : " + timeToDisplayExplication);

//         if (CinematicTimer >= 0)
//         {
//             Debug.Log("ok let's go ");
//             cameraOne.transform.Translate(Vector3.forward * Time.deltaTime * 9);

//             ChangeCameraTimer = 0.3f;
//             timeToDisplayExplication = 3f;
//         }

//         if (ChangeCameraTimer <= 0)
//         {
//             Debug.Log("ok changer de cam");
//             // textExplication.enabled = true;
//             // cameraOne.SetActive(false);
//             // cameraTwo.SetActive(true);
//         }

//         if (timeToDisplayExplication <= 0)
//         {
//             Debug.Log("fini !");
//             textExplication.enabled = true;
//             // textExplication.enabled = false;
//             cameraOne.SetActive(false);
//             cameraTwo.SetActive(true);
//             active = false;
//         }
//         // }

//     }
// }