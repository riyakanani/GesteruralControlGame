using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    public int particleCount = 3;
    public float speed = .5f;
    public float width = 5;
    public float height = 5;
    float timeCounter = 0;
    GameObject[] particles;

    void Awake()
    {
        particles = new GameObject[particleCount];

    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < particleCount; i++)
        {
            particles[i] = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            SphereController sphereController = particles[i].AddComponent<SphereController>();
            sphereController.myNumber = i + 1;
            particles[i].transform.localScale = new Vector3(2, 2, 2);
            particles[i].tag = "Target";
            Color customColor = Color.HSVToRGB(Random.Range(0, 1f), Random.Range(0.8f, 1f), Random.Range(0.5f, 1f));
            particles[i].GetComponent<Renderer>().material.SetColor("_Color", customColor);

        }
    }

    // Update is called once per frame
    void Update()
    {
        float angleStep = 360f / particleCount; // Angle step for even distribution

        for (int i = 0; i < particleCount; i++)
        {
            float angle = i * angleStep;
            float radians = Mathf.Deg2Rad * angle;

            timeCounter += Time.deltaTime * speed;
            float x = Mathf.Cos(timeCounter + radians) * width;
            float y = Mathf.Sin(timeCounter + radians) * height;
            float z = 0;
            if(particles[i] != null){
                particles[i].transform.position = new Vector3(x, y, z);
            }
        }
    }
}
