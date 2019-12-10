using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowName : MonoBehaviour
{
    public static string PlayerName;
    public InputField PlayerNameInput;
    public Text showPlayername;
    public Text rounds;
    public Text ballSpeed;
    public Text cubeSpeed; 


    void Start()
    {

        DontDestroyOnLoad(this.gameObject);
        ballSpeed.text = "" + PlayerPrefs.GetFloat("SizeValue");
        cubeSpeed.text = "" + PlayerPrefs.GetFloat("SliderValue");



    }
    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text;
        showPlayername.text = PlayerName;
    }
    public void ShowNameFun()
    {
        showPlayername.text = PlayerName;
    }
}
