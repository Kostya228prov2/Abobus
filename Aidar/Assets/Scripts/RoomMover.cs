using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMover : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.forward * speed;
    }
}
