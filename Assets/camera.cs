using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform player;
   

    public float sensitivity;

    float veritcalRotate = 0f;
    bool lockedCursor = true;

    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float inputY = Input.GetAxis("Mouse Y") * sensitivity;
        float inputX = Input.GetAxis("Mouse X") * sensitivity;

        veritcalRotate -= inputY;
        veritcalRotate = Mathf.Clamp(veritcalRotate, -90f, 90f);
        transform.localEulerAngles = Vector3.right * veritcalRotate;

        player.Rotate(Vector3.up * inputX);
    }
}