using Mediapipe.Unity.Holistic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genesis : MonoBehaviour {
    public static Genesis gen;
    public Vector3[] pos = new Vector3[2]; // 0 = thumb, 1 = index
    private Vector3 thumbPos, indexPos;
    private GameObject index, thumb;
    private float distance;

    private void Awake() {
        if (Genesis.gen == null) {
            Genesis.gen = this;
        }
    }

    void Start() {
        index = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        index.tag = "Player";
        thumb = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        thumb.tag = "Player";
    }

    void Update() {
        thumbPos.x = Mathf.Lerp(-9.5f, 4.4f, pos[0].x);
        thumbPos.y = Mathf.Lerp(4.8f, -3.4f, pos[0].y);
        indexPos.x = Mathf.Lerp(-9.5f, 4.4f, pos[1].x);
        indexPos.y = Mathf.Lerp(4.8f, -3.4f, pos[1].y);

        thumb.transform.position = thumbPos;
        index.transform.position = indexPos;

        distance = (thumbPos - indexPos).magnitude;
        // Debug.Log(distance);

    }

}
