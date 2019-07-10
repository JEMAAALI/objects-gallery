using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




namespace UnityEngine.UI.Extensions.ColorPicker
{
public class Highlight : MonoBehaviour
{
    public GameObject _Manager;
    
    public int _idTexture =11;
    private Color ColorRed = Color.red; 

    void Start()
    {
         
    }

    void Update()
    {
        
    }


    // Pour chaque Objet 3D sélectionné on affecte un "Outline" ou un changement de couleur 
    //pour montrer à l'utilisateur l'objet 3D qui va être personnalisé.
	void OnMouseDown(){
        Scene scene = SceneManager.GetActiveScene();
		if(scene.name=="Personnalisation 1")
        {
         if (Application.platform == RuntimePlatform.Android){
         GetComponent<Renderer>().material.SetFloat("_Outline",0.02f); 
         }
         else
         {
         GetComponent<Renderer>().material.SetFloat("_Outline",0.2f);  
         }
         }
         else{
         GetComponent<Renderer>().material.SetFloat("_Glossiness", 1.0f);
         }
        _Manager.GetComponent<Highlight_Manager>()._selectedObject=this.name;
        _Manager.GetComponent<ColorPickerTester>().pickerRenderer=this.gameObject.GetComponent<Renderer>();
        GameObject.Find("Selectionner").GetComponent<Text>().text="";
        
	}
}
}
