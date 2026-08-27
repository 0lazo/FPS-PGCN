using UnityEngine;
using UnityEngine.InputSystem;

public class CameraRotation : MonoBehaviour
{
    [SerializeField]
    private Camera cam;

    private float xRotation = 0;

    [SerializeField]
    private float xSensivity = 100;
    [SerializeField]
    private float ySensivity = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current == null) return;

        Vector2 mouseInput = Mouse.current.delta.ReadValue();
        xRotation -= mouseInput.y * ySensivity;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        transform.Rotate(0f, mouseInput.x * xSensivity, 0);
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
    }
}
