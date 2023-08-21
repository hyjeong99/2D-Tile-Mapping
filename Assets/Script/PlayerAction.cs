using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAction : MonoBehaviour
{
    public float Speed;

    float h;
    float v;
    Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        //transform.Translate(new Vector2(h, v) * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        rigid.velocity = new Vector2(h, v) * Speed;
    }
}
