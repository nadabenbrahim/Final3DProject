using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    TrailRenderer trailRenderer;
    public Transform center;
    public float radius;
    public float radiusSpeed;
    public float rotationSpeed;

    private Vector3 axis;
    private Vector3 desiredPosition;

    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = (transform.position - center.position).normalized * radius + center.position;    
        axis = Vector3.up;
        TrailRenderer myTrailRenderer = GetComponent<TrailRenderer>();
        myTrailRenderer.material.color = Color.white;
        trailRenderer = GetComponent<TrailRenderer>();
        trailRenderer.SetPosition(0, transform.position);
    }

    void Update()
    {
        transform.RotateAround(center.position,axis,rotationSpeed*Time.deltaTime);
        desiredPosition = (transform.position - center.position).normalized * radius + center.position;
        transform.position = Vector3.MoveTowards(transform.position, desiredPosition,Time.deltaTime * radiusSpeed);

    }
}
