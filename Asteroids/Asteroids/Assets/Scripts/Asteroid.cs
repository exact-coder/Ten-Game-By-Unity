using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public Sprite[] sprites;
    public float size = 1.0f;
    public float minSize = 0.5f;
    public float maxSize = 1.5f;

    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        //for random sprites
        _spriteRenderer.sprite = sprites[Random.Range(0, sprites.Length)];

        //for random rotations
        this.transform.eulerAngles = new Vector3(0.0f, 0.0f, Random.value * 360.0f);

        //for random mass
        this.transform.localScale = Vector3.one * this.size;

        _rigidbody.mass = this.size;
    }

}
