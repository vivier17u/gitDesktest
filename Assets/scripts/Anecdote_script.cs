using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anecdote_script : MonoBehaviour
{
    public int compteur = 1;
    public bool isPaused = false;
    public GameObject anecdote__1;
    public GameObject anecdote__2;
    public GameObject anecdote__3;
    public GameObject anecdote__4;
    public GameObject anecdote__5;
    public GameObject square;
    // Start is called before the first frame update
    void Start()
    {
        Update();
    }



    public void Anecdote_affiche ()
    {
	if  (compteur == 1)
	{
		compteur +=1;
		isPaused = true;
		square.SetActive(true);
		anecdote__1.SetActive(true);
	}
	else if (compteur == 2)
	{
		compteur +=1;
		isPaused = true;
		square.SetActive(true);
		anecdote__2.SetActive(true);
	}
	else if (compteur == 3)
	{
		compteur +=1;
		isPaused = true;
		square.SetActive(true);
		anecdote__3.SetActive(true);
	}
	else if (compteur == 4)
	{
		compteur +=1;
		isPaused = true;
		square.SetActive(true);
		anecdote__4.SetActive(true);
	}
	else if (compteur == 5)
	{
		compteur +=1;
		isPaused = true;
		square.SetActive(true);
		anecdote__5.SetActive(true);
	}

    }
    // Update is called once per frame
    void Update()
    {
	if (Input.GetKeyDown("enter"))
	{
		isPaused = false;
		Time.timeScale = 1;
		anecdote__1.SetActive(false);
		anecdote__2.SetActive(false);
		anecdote__3.SetActive(false);
		anecdote__4.SetActive(false);
		anecdote__5.SetActive(false);
		square.SetActive(false);

		
	}
        if (isPaused)
	{
		Time.timeScale = 0;

	}
    }
}