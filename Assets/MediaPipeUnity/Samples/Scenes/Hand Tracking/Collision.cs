using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mediapipe.Unity;

public class Collision : MonoBehaviour
{
    public float interactionDistance = 0.0f;

    void Update()
    {  
        GameObject[] hintObjects = GameObject.FindGameObjectsWithTag("Target");
        GameObject[] fingerObjects = GameObject.FindGameObjectsWithTag("Player"); 
        if (hintObjects != null){
            // Check each child collider
            foreach (GameObject hintObject in hintObjects)
            {
                foreach (GameObject fingerObject in fingerObjects)
                {
                        float distance = Vector3.Distance(fingerObject.transform.position, hintObject.transform.position);
                        if (distance <= interactionDistance)
                        {
                            PerformAction(hintObject);
                            return;
                        }
                }
            }

        }
        
        
    }

    void PerformAction(GameObject hint)
    {
        
        switch(hint.GetComponent<SphereController>().myNumber) {
            case 1:
                //do something
                break;
            case 2:
                //do something
                break;
            case 3:
                //do something
                break;
        }
        Destroy(hint);
    }

}

