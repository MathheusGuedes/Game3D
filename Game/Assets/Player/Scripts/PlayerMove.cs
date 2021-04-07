using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Animator anim;
    public float velRotacao;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Speed", Input.GetAxis("Vertical"));
        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * Time.deltaTime * velRotacao,0));
    }
}
