using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendTexture : MonoBehaviour
{
 
    // Déterminer la texture à appliquer et l'envoyer à <Highlight_Manager> pour l'appliquer sur
    // l'objet 3D sélectionné
    public void Send()
    {
        
        GameObject.Find("Objects").GetComponent<Highlight_Manager>()._idTexture=int.Parse(this.gameObject.name)-1;
        if(int.Parse(this.gameObject.name) < 13)
        {
        GameObject.Find("Objects").GetComponent<Highlight_Manager>().AssignTexture();
        }
        else
        {
        GameObject.Find("Objects").GetComponent<Highlight_Manager>().RemoveTexture();    
        }
    }
}
