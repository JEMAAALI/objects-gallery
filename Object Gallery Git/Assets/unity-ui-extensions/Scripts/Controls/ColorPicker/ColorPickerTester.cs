///Credit judah4
///Sourced from - http://forum.unity3d.com/threads/color-picker.267043/
using UnityEngine.UI;

namespace UnityEngine.UI.Extensions.ColorPicker
{
    public class ColorPickerTester : MonoBehaviour
    {
        public Renderer pickerRenderer;
        public ColorPickerControl picker;
        public float _rColor;
        public float _gColor;
        public float _bColor;
        public float _aColor;
        
        void Awake()
        {
            
        }
        void Start()
        {
            picker.onValueChanged.AddListener(color =>
            {
                pickerRenderer.GetComponent<Renderer>().material.SetColor("_Color",color);
                _rColor=color.r;
                _gColor=color.g;
                _bColor=color.b;
                _aColor=color.a;
                print(""+_rColor+" "+_gColor+" "+_bColor+" "+_aColor);
            });
        }

        public void SaveColor()
        {

        }
    }
}