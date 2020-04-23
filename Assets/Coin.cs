using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float RotateSpeed;
    public float BobSpeed;
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, (Mathf.Sin(Time.time) * Mathf.Deg2Rad) / 2);
        transform.Rotate(0, RotateSpeed * Time.deltaTime, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Coin Collected");
    }
}
