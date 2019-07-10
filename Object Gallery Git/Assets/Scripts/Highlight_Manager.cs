using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.UI.Extensions.ColorPicker;
using UnityEngine.SceneManagement;

public class Highlight_Manager : MonoBehaviour
{   
    public GameObject[] _Objects ;    
    public string _selectedObject;
    public GameObject _ColorBtn;
    public GameObject _TextureBtn;
    public GameObject _SaveBtn;
    public GameObject _SelectionText;
    public int _idTexture; 
    public Texture2D[] _SelectedTexture; 
    
     

    void Update()
    {
        if(_selectedObject!="")
            {
                _ColorBtn.GetComponent<Button>().interactable=true;
                _TextureBtn.GetComponent<Button>().interactable=true;
                _SaveBtn.GetComponent<Button>().interactable=true;
                
            }
        Scene scene = SceneManager.GetActiveScene();
        
		//Supprimer la couleur/Outline pour chaque objet 3D non selectionné
        foreach(GameObject item in _Objects)
        {
         if(item.name!=_selectedObject)
         {
             if(scene.name=="Personnalisation 1"){
             item.GetComponent<Renderer>().material.SetFloat("_Outline",0.0f);
             }
             else{
             item.GetComponent<Renderer>().material.SetFloat("_Glossiness", 0.5f);
             }
         }    
        }
    }

    //Affécter une texture selectionné à un objet 3D
    public void AssignTexture()
    {
        foreach(GameObject item in _Objects)
        {
         if(item.name==_selectedObject)
         {
         item.GetComponent<Renderer>().material.SetTexture ("_MainTex", _SelectedTexture[_idTexture]);
         item.GetComponent<Highlight>()._idTexture=_idTexture;
         }
        }
    }



    //Supprimer une texture selectionné à un objet 3D .
    public void RemoveTexture()
    {
        foreach(GameObject item in _Objects)
        {
         if(item.name==_selectedObject)
         {
         item.GetComponent<Renderer>().material.SetTexture ("_MainTex", null);
         }
        }
    }



    
     
     
}
