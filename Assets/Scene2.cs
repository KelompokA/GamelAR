using UnityEngine;
using System.Collections;

public class Scene2 : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
	public void onClick(int sceneId)
	{
        Application.LoadLevel(sceneId);
	}

	public int cek = 0;
	public int cekk= 0;
	public void apapun()
	{
		if (cek==1)
		{		GameObject.FindGameObjectWithTag ("HowTo").transform.position = new Vector2 (0, 1000);
		cek=0;
		}
		else if (cek==0)
		{		GameObject.FindGameObjectWithTag ("HowTo").transform.position = new Vector2 (417, 127);
			cek= 1;
		}
	}
    
	public void apapun1()
	{
		if (cekk==1)
		{		GameObject.FindGameObjectWithTag ("AboutUs").transform.position = new Vector2 (0, 1000);
			cekk=0;
		}
		else if (cekk==0)
		{		GameObject.FindGameObjectWithTag ("AboutUs").transform.position = new Vector2 (417, 127);
			cekk= 1;
		}
	}
/*    public void OnPointerClick()
    {
        Application.LoadLevel(1);
    }
    
    public void OnPointerDown()
    {
        Application.LoadLevel(1);
    }   */
}
