using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseController : MonoBehaviour
{
    [SerializeField] private LayerMask hitMask;

    void Update()
    {
       
    }
    public void MousePosition(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 100f, hitMask);
            if (hit.collider != null)
            {
                Transform t = hit.collider.transform;
                Vector3 point = ray.origin + (ray.direction * 4.5f);
                point.z = 0f;
                if (t.gameObject.tag == "Australia")
                {
                    PlayerController.instance.SetTarget(point);
                }
                else if (t.gameObject.tag == "Fire")
                {
                    PlayerController.instance.ShootWater(point);
                }
            }
        }
    }
}
