using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private float parallaxEffect = -0.15f;
    private Camera cam;
    private Vector2 startPos;
    private Vector2 travel => (Vector2) cam.transform.position - startPos;

    private void Awake() {
        cam = Camera.main;
    }

    private void Start() {
        startPos = transform.position;
    }

    private void FixedUpdate() {
        //Vector2 distance = cam.transform.position - startPos;
        transform.position = startPos + travel * parallaxEffect;
    }
}
