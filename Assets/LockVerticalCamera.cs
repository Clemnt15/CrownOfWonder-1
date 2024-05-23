using UnityEngine;

public class LockVerticalCamera : MonoBehaviour
{
    public float minY = -30f; // Limite minimum de rotation verticale
    public float maxY = 60f;  // Limite maximum de rotation verticale

    private Transform cameraTransform;
    private Vector3 initialRotation;

    void Start()
    {
        cameraTransform = Camera.main.transform;
        initialRotation = cameraTransform.eulerAngles;
    }

    void LateUpdate()
    {
        Vector3 rotation = cameraTransform.eulerAngles;

        // Convert the rotation to a range between -180 and 180 degrees
        if (rotation.x > 180)
            rotation.x -= 360;

        // Clamp the rotation within the specified range
        rotation.x = Mathf.Clamp(rotation.x, minY, maxY);

        // Apply the clamped rotation
        cameraTransform.eulerAngles = new Vector3(rotation.x, initialRotation.y, initialRotation.z);
    }
}
