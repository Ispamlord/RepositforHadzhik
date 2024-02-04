using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Weapone : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject otherObject; 
    private SpriteRenderer otherSpriteRenderer;
    private Transform tr;
    Vector2 mv;
    private void Awake()
    {
        tr = GetComponent<Transform>();
        otherSpriteRenderer = otherObject.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        mv = transform.position;
        if (otherSpriteRenderer != null && otherSpriteRenderer.flipX)
        {
            transform.position =  new Vector2(-mv.x, mv.y);
        }
        else
        {
            transform.position = new Vector2(-mv.x, mv.y);
        }
        
    }
}
