using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour{
    Vector3 mouse_pos;
    public float move_speed = 0.1f;
    Rigidbody2D rb;
    Vector2 pos = new Vector2(0f, 0f);


    private void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update(){
        mouse_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos = Vector2.Lerp(transform.position, mouse_pos, move_speed);
    }

    private void FixedUpdate(){
        rb.MovePosition(pos);
    }
}
