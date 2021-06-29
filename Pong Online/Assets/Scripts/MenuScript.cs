using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public GameObject Main;

    public GameObject Offline;

    public GameObject Settings;

    public GameObject TwoPlayerScreen;

    public GameObject Name;

    public static Color ChosenColor = Color.red;

    public static Color Player2Color = Color.blue;

    public static string ChosenName;

    public Text ColorSelectedOne;

    public Text ColorSelectedTwo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ChooseName()
    {
        ChosenName = Name.GetComponent<Text>().text;
    }

    public void StartButton()
    {
        Main.SetActive(false);
        Offline.SetActive(true);
        Settings.SetActive(false);
    }

    public void TwoPlayer()
    {
        Main.SetActive(false);
        Offline.SetActive(false);
        Settings.SetActive(false);
        TwoPlayerScreen.SetActive(true);
    }

    public void TwoPlayerStart()
    {
        SceneManager.LoadScene(1);
    }

    public void Online()
    {
        SceneManager.LoadScene(2);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Vsai()
    {
        SceneManager.LoadScene(4);
    }

    public void Back()
    {
        Offline.SetActive(false);
        Settings.SetActive(false);
        Main.SetActive(true);
    }

    public void Setting()
    {
        Main.SetActive(false);
        Offline.SetActive(false);
        Settings.SetActive(true);
    }

    public void BackFromSettings()
    {
        Settings.SetActive(false);
        Offline.SetActive(false);
        Main.SetActive(true);
    }

    //Color Choices

    public void Red()
    {
        ChosenColor = Color.red;
        Settings.SetActive(false);
        Offline.SetActive(false);
        Main.SetActive(true);
    }

    public void Green()
    {
        ChosenColor = Color.green;
        Settings.SetActive(false);
        Offline.SetActive(false);
        Main.SetActive(true);
    }

    public void Blue()
    {
        ChosenColor = Color.blue;
        Settings.SetActive(false);
        Offline.SetActive(false);
        Main.SetActive(true);
    }

    public void Purple()
    {
        Color purple = new Color32(178, 0, 255,255);
        ChosenColor = purple;
        Settings.SetActive(false);
        Offline.SetActive(false);
        Main.SetActive(true);
    }

    public void Orange()
    {
        ChosenColor = new Color32(255, 86, 0,255);
        Settings.SetActive(false);
        Offline.SetActive(false);
        Main.SetActive(true);
    }

    public void Pink()
    {
        ChosenColor = new Color32(255, 0, 204, 255);
        Settings.SetActive(false);
        Offline.SetActive(false);
        Main.SetActive(true);
    }

    public void Yellow()
    {
        ChosenColor = new Color32(254, 255, 0, 255);
        Settings.SetActive(false);
        Offline.SetActive(false);
        Main.SetActive(true);
    }

    public void LightPink()
    {
        ChosenColor = new Color32(255, 196, 243, 255);
        Settings.SetActive(false);
        Offline.SetActive(false);
        Main.SetActive(true);
    }

    public void Lime()
    {
        ChosenColor = new Color32(183, 255, 0, 255);
        Settings.SetActive(false);
        Offline.SetActive(false);
        Main.SetActive(true);
    }

    public void Cyan()
    {
        ChosenColor = new Color32(0, 253, 255, 255);
        Settings.SetActive(false);
        Offline.SetActive(false);
        Main.SetActive(true);
    }

    //2 Player Colors

    //PLayer 1 Colors

    public void RedFirst()
    {
        ChosenColor = Color.red;
        ColorSelectedOne.text = "RED Selected...";
    }

    public void GreenFirst()
    {
        ChosenColor = Color.green;
        ColorSelectedOne.text = "GREEN Selected...";
    }

    public void BlueFirst()
    {
        ChosenColor = Color.blue;
        ColorSelectedOne.text = "BLUE Selected...";
    }

    public void OrangeFirst()
    {
        ChosenColor = new Color32(255, 86, 0, 255);
        ColorSelectedOne.text = "ORANGE Selected...";
    }

    public void PinkFirst()
    {
        ChosenColor = new Color32(255, 0, 204, 255);
        ColorSelectedOne.text = "PINK Selected...";
    }

    public void CyanFirst()
    {
        ChosenColor = new Color32(0, 253, 255, 255);
        ColorSelectedOne.text = "CYAN Selected...";
    }

    //Player 2 Colors

    public void Red2()
    {
        Player2Color = Color.red;
        ColorSelectedTwo.text = "RED Selected...";
    }

    public void Green2()
    {
        Player2Color = Color.green;
        ColorSelectedTwo.text = "GREEN Selected...";
    }

    public void Blue2()
    {
        Player2Color = Color.blue;
        ColorSelectedTwo.text = "BLUE Selected...";
    }

    public void Orange2()
    {
        Player2Color = new Color32(255, 86, 0, 255);
        ColorSelectedTwo.text = "ORANGE Selected...";
    }

    public void Pink2()
    {
        Player2Color = new Color32(255, 0, 204, 255);
        ColorSelectedTwo.text = "PINK Selected...";
    }

    public void Cyan2()
    {
        Player2Color = new Color32(0, 253, 255, 255);
        ColorSelectedTwo.text = "CYAN Selected...";
    }
}
