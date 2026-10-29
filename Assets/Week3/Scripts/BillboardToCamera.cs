using UnityEngine;

public class BillboardToCamera : MonoBehaviour
{
    [SerializeField] private Camera targetCamera;

    private void Update()
    {
        if (targetCamera == null)
            targetCamera = Camera.main;

        if (targetCamera == null)
            return;

        Transform cameraTransform = targetCamera.transform;
        transform.LookAt(
            transform.position + cameraTransform.rotation * Vector3.forward,
            cameraTransform.rotation * Vector3.up
        );
    }
}