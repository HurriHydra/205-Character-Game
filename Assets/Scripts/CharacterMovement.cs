using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    
    private bool ToggleDance1;
    private bool ToggleDance2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
         
            GetComponent<Animator>().SetFloat("Forward", 1);

            if (Input.GetKey(KeyCode.LeftShift))
            { 
                GetComponent<Animator>().SetFloat("Forward", 3);
            }

        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Animator>().SetTrigger("Left");
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Animator>().SetTrigger("Right");
        }

        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Animator>().SetFloat("Forward", -1);
        }

        if (Input.GetKey(KeyCode.J))
        {
            
            ToggleDance1 = !ToggleDance1;
            if (ToggleDance1 == true) 
            {
                GetComponent<Animator>().SetFloat("Dance", 2);
            }
            else if (ToggleDance1 == false)
            {
                GetComponent<Animator>().SetFloat("Dance", 0);
            }
        }

        if (Input.GetKey(KeyCode.K))
        {

            ToggleDance2 = !ToggleDance2;
            if (ToggleDance2 == true)
            {
                GetComponent<Animator>().SetFloat("Dance2", 2);
            }
            else if (ToggleDance2 == false)
            {
                GetComponent<Animator>().SetFloat("Dance2", 0);
            }
        }

    }
}
