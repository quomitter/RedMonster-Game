using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Granny : MonoBehaviour
{

    public AudioClip aHit1;
    AudioSource audioSource1;

    // Start is called before the first frame update
    void Start()
    {
        audioSource1 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        
            if (other.gameObject.CompareTag("Player"))
            {
                Vector2 direction = other.GetContact(0).normal;
                if (direction.y == -1 || direction.y == 1)
                {
                    GetComponent<Collider2D>().enabled = false;
                    audioSource1.PlayOneShot(aHit1, 0.7F);
                    Destroy(this.gameObject);
                }
                else
                {
                    SceneManager.LoadScene(2);
                }
            }
        
    }
}