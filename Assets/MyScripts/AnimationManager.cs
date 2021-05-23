using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public Camera cam;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 20f))
            {
                if (hit.collider.CompareTag("DoorButton"))
                {
                    animator.Play("Button_Press_Animation");
                    animator.Play("Left_Door_Open_Animation");
                    animator.Play("Right_Door_Open_Animation");
                }

            }

        }
    }
}
