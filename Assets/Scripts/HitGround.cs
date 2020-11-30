using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitGround : MonoBehaviour
{
    private float thrust = 10.0f;
    private bool isDedek = false;
    private Collider2D _playerCollider2D;

    // Update is called once per frame
    void Update()
    {
        if (isDedek && _playerCollider2D)
        {
            _playerCollider2D.attachedRigidbody.AddForce(new Vector2(thrust * -20, thrust));
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isDedek = true;
            _playerCollider2D = other;
        }
    }

}
