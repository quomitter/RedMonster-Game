using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesScript : MonoBehaviour
{
    public AudioClip aDeathSound;

    private SavePoint sp;
    private Checkpoint checkpoint;


    AudioSource myAudioSource;
    public AudioClip spikeHit;
    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        sp = GameObject.FindGameObjectWithTag("SP").GetComponent<SavePoint>();
        checkpoint = GameObject.FindGameObjectWithTag("Checkpoint").GetComponent<Checkpoint>();
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player") {
            AudioSource.PlayClipAtPoint(aDeathSound, Camera.main.transform.position, 0.5F);
            Lives.Instance.MinusLife();
            myAudioSource.PlayOneShot(spikeHit, 0.7f);
            other.gameObject.transform.position = sp.lastCheckPointPos;
            checkpoint.dead = true;
        }
    }
}
