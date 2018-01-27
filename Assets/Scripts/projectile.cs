using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Player 2")
        {
            Debug.Log("Hit it. Fade it. Gone");
            Destroy(this.gameObject);
        }
        Destroy(this.gameObject);
    }

}
