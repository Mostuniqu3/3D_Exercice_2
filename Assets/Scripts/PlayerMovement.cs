using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] GameObject head;
    [SerializeField] float speed = 0.2f;
    [SerializeField] float sensitivity = 1f;

    private float yawn = 0.0f;
    private float pitch = 0.0f;

    private void HandleMovement()
    {
        Vector3 deltaPosition = (
            head.transform.right * Input.GetAxis("Horizontal")
            + head.transform.forward * Input.GetAxis("Vertical")
        ) * speed;
        deltaPosition.y = 0f;
        transform.position += deltaPosition;
    }

    private void HandleCameraMovement()
    {
        pitch -= Input.GetAxis("Mouse Y") * sensitivity;
        yawn += Input.GetAxis("Mouse X") * sensitivity;
        pitch = Mathf.Clamp(pitch, -90f, 90f);
        head.transform.eulerAngles = new Vector3(pitch, yawn, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
        HandleCameraMovement();
    }
}
