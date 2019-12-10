using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeSlider : MonoBehaviour
{ 
    public Text sizeText;
    public Slider sizeSlider;
  
    public static float sizeValue = 1;

    void Start()
    {
        sizeValue = PlayerPrefs.GetFloat("SizeValue");
    }

    void Update()
    {
        sizeText.text = sizeSlider.value.ToString();
        sizeValue = sizeSlider.value;
        PlayerPrefs.SetFloat("SizeValue", sizeValue);
 
        
    }
    void ChangeSlider()
    {

    }
}
