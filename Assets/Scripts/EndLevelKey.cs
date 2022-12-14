using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelKey : MonoBehaviour
{
    private SavePoint sp;
    // Start is called before the first frame update
    void Start()
    {
        sp = GameObject.FindGameObjectWithTag("SP").GetComponent<SavePoint>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            sp.lastCheckPointPos = sp.startCheckPointPos;

            SceneManager.LoadScene(4);
            Destroy(this.gameObject);
            
        }
    }
  
}