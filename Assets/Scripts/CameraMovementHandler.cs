using UnityEngine;

public class CameraMovementHandler : MonoBehaviour
{
    [SerializeField] private Transform body;
    [SerializeField] private Transform cameraHolder;

    public float sensitivityX = 5f;
    public float sensitivityY = 5f;

    private float xRotation = 0f;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivityX;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivityY;

        // Rotate body left/right
        body.Rotate(Vector3.up * mouseX);

        // Rotate cameraHolder up/down
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        cameraHolder.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}
