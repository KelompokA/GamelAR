using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
   
	// Update is called once per frame
	void Update () {


	}
    
    void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(0))
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            //audio.Play(44100);
            //audio.PlayDelayed()
            Debug.Log("AAAAAAAAAAAAaaaaaaaaaaaaaaaaaaaaaa");
        }
    }
    
}
