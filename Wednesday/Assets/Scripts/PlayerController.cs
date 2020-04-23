using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public AudioSource ScreamingSource;
    public AudioSource GunSource;
    public AudioClip PewPew;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(new Vector2(Input.GetAxis("Horizontal"), 0f) * speed);
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            ScreamingSource.UnPause();
        else
            ScreamingSource.Pause();
        if (Input.GetKeyDown(KeyCode.F))
            GunSource.PlayOneShot(PewPew);
    }
}
