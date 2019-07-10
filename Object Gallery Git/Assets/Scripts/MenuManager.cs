using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject[] _Gallery;
    public int i = 0;
    public void LoadLevel()
    {
		SceneManager.LoadScene(this.gameObject.name);
    }

    public void LoadSelection()
    {
		SceneManager.LoadScene("Selection");
    }

    public void LoadMainMEnu()
    {
		SceneManager.LoadScene("MainMenu");
    }

    public void Next()
    {
      i=i+1;
      if(i>4)
      {
        i=4;
      }
      for(int j=0; j<_Gallery.Length;j++)
      {
        if(j==i)
        {
          _Gallery[j].gameObject.SetActive(true);
        }
        else
        {
          _Gallery[j].gameObject.SetActive(false);
        }
      }
    }
    
    public void Previous()
    {
      i=i-1;
      if(i<0)
      {
        i=0;
      }
      for(int j=0; j<_Gallery.Length;j++)
      {
        if(j==i)
        {
          _Gallery[j].gameObject.SetActive(true);
        }
        else
        {
          _Gallery[j].gameObject.SetActive(false);
        }
      }
    }
    
 

     
}
