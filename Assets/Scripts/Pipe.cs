using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    private Character character;

    // Start is called before the first frame update
    void Start()
    {
        character = FindObjectOfType<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        if (character.transform.position.x - transform.position.x > 5)
        {
            float xRan = Random.Range(0, 10);
            float yRan = Random.Range(-5, 5);
            Instantiate(gameObject, new Vector2(character.transform.position.x + 15 + xRan, -10 + yRan), transform.rotation);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            character.Death();
        }
    }
}
