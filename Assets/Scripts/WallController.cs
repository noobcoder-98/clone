using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    public int health;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReceiveDamge(int damage) {
        if (health - damage <= 0) {
            Destroy(gameObject);
        } else {
            health -= damage;
        }
    }
}
