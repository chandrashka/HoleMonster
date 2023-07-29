using System;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform holeTransform;
    [SerializeField] private float distanceToHoleZ = -12;

    private void LateUpdate()
    {
        var holeTransformPosition = holeTransform.position;
        var cameraTransform = transform;

        cameraTransform.position =
            new Vector3(holeTransformPosition.x, cameraTransform.position.y, 
                holeTransformPosition.z + distanceToHoleZ);
    }
}