using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c : MonoBehaviour {
    private Animator ani;

    // Use this for initialization
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ani.SetTrigger("吃飯觸發器");
        }

        ani.SetBool("跑步開關", Input.GetKey(KeyCode.R));
    }
}
