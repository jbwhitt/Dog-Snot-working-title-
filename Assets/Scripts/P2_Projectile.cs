using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2_Projectile : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Player 2")
        {
            Debug.Log("Hit it. Fade it. Gone");
            Destroy(this.gameObject);
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player1>().health -= 1;
        }
        Destroy(this.gameObject);
    }
}
