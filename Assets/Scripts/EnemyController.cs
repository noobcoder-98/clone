using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int health;
    public int damage;
    public float movementSpeed;
    public float damageCooldown;

    private bool isStopped;

    public void ReceiveDamge(int damage) {
        if (health - damage <= 0) {
            transform.parent.GetComponent<SpawnPoint>().enemies.Remove(gameObject);
            Destroy(gameObject);
        } else {
            health -= damage;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isStopped)
            transform.Translate(new Vector3(0, movementSpeed * -1, 0));
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.layer == 8) {
            StartCoroutine(Attack(collision));
            isStopped = true;
        }
    }

    IEnumerator Attack(Collider2D collision) {
        if (collision == null) {
            isStopped = false;
        } else {
            collision.gameObject.GetComponent<WallController>().ReceiveDamge(damage);
            yield return new WaitForSeconds(damageCooldown);
            StartCoroutine(Attack(collision));
        }
        
    }

}
