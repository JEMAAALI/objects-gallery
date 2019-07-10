using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace UnityEngine.UI.Extensions.ColorPicker
{
   public class SaveLoad: MonoBehaviour {

	//[SerializeField] private FinanceManager _managers;
	 public GameObject _manager;
	public GameObject[] _Objects;
	public Texture2D[] _SelectedTexture ;
	public float _rColor;
    public float _gColor;
    public float _bColor;
    public float _aColor;
 
 	void Start () 
	{
		// this array should be filled before you can use EncryptedPlayerPrefs :
		EncryptedPlayerPrefs.keys=new string[5];
		EncryptedPlayerPrefs.keys[0]="23Wrudre";
		EncryptedPlayerPrefs.keys[1]="SP9DupHa";
		EncryptedPlayerPrefs.keys[2]="frA5rAS3";
		EncryptedPlayerPrefs.keys[3]="tHat2epr";
		EncryptedPlayerPrefs.keys[4]="jaw3eDAs";
		Load();
 	}

	 
	 

	public void save()
	{


		foreach(GameObject item in _Objects)
        {
		  //Sauvegarde de Couleur RGBA de chaque objet 3D 
		  //Sauvegarde de la texture sélectionné de chaque objet 3D 
		  EncryptedPlayerPrefs.SetFloat(item.name+"R", +item.gameObject.GetComponent<Renderer>().material.color.r);
		  EncryptedPlayerPrefs.SetFloat(item.name+"G", +item.gameObject.GetComponent<Renderer>().material.color.g);
		  EncryptedPlayerPrefs.SetFloat(item.name+"B", +item.gameObject.GetComponent<Renderer>().material.color.b);
		  EncryptedPlayerPrefs.SetFloat(item.name+"A", +item.gameObject.GetComponent<Renderer>().material.color.a);
          EncryptedPlayerPrefs.SetInt(item.name+"Texture", +item.gameObject.GetComponent<Highlight>()._idTexture);
		  GameObject.Find("Selectionner").GetComponent<Text>().text="Sauvegarde réussie";
		
		}


		
 	}








	public void Load()
	{
		Scene scene = SceneManager.GetActiveScene();
		foreach(GameObject item in _Objects)
        {
          //Chargement et affectation des couleurs et textures sauvegardés 
		  float _r = EncryptedPlayerPrefs.GetFloat(item.name+"R", -1f);
		  float _g = EncryptedPlayerPrefs.GetFloat(item.name+"G", -1f);
		  float _b = EncryptedPlayerPrefs.GetFloat(item.name+"B", -1f);
		  float _a = EncryptedPlayerPrefs.GetFloat(item.name+"A", -1f);
		  if(_r!=-1)
		  {
		  Color _color = new Color (_r,_g,_b,_a);
		  item.gameObject.GetComponent<Renderer>().material.SetColor("_Color",_color);
          }
		  int _idTexture = EncryptedPlayerPrefs.GetInt(item.name+"Texture", -1);
		  if(_idTexture!=-1)
		  {
		  if(_idTexture!=11)
		  {
		  item.GetComponent<Renderer>().material.SetTexture ("_MainTex", _SelectedTexture[_idTexture]);
          if(scene.name!="Gallerie")
		  {
		  item.GetComponent<Highlight>()._idTexture=_idTexture;
		  }
		  }
		  }
		}
	}

 }












}
