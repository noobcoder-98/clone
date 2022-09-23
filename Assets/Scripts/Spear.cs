using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : MonoBehaviour
{
    public float movementSpeed;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, movementSpeed, 0));
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.layer == 9) {
            collision.gameObject.GetComponent<EnemyController>().ReceiveDamge(damage);
            Destroy(gameObject);
        }
    }
}
