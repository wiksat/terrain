using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    private Component[] buttons;
    GameObject sound;
    SoungManager Sounds;
    private Slider slider;
    private Dropdown dropdown;
    private List<string> list = new List<string>();
    SoungManager sounds;
    Toggle toggle;
    void Start()
    {
        buttons = GetComponentsInChildren(typeof(Button));
        //Debug.Log(buttons.Length);

        (buttons[0] as Button).onClick.AddListener(KlikButton0);
        (buttons[1] as Button).onClick.AddListener(KlikButton1);
        (buttons[2] as Button).onClick.AddListener(KlikButton2);
        (buttons[3] as Button).onClick.AddListener(KlikButton3);
        (buttons[4] as Button).onClick.AddListener(KlikButton4);
        Sounds = GameObject.Find("Sounds").GetComponent<SoungManager>();
        sounds = GameObject.Find("Sounds").GetComponent<SoungManager>();
        slider = GetComponentInChildren(typeof(Slider)) as Slider;
        slider.onValueChanged.AddListener(sounds.OnBgVolumeChanged);
        dropdown=GameObject.Find("Dropdown").GetComponent<Dropdown>();
       // dropdown = GetComponentInChildren(typeof(Dropdown)) as Dropdown;
        toggle=GameObject.Find("Toggle").GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(SetFullscreen);
        Resolution();
    }
    public void KlikButton0()
    {
        SceneManager.LoadScene("1", LoadSceneMode.Single);
    }
    public void KlikButton1()
    {
        SceneManager.LoadScene("2", LoadSceneMode.Single);
    }
    //bool AudioOn = true;
    public void KlikButton2()
    {
        Debug.Log("audio");

        Sounds.PlayBgMusic(true);
    }
    public void KlikButton3()
    {
        Debug.Log("noaudio");

        Sounds.PlayBgMusic(false);
    }
    public void KlikButton4()
    {
        Application.Quit();
    }
    public void Resolution()
    {
        Debug.Log("hello");
        for (int i = 0; i < Screen.resolutions.Length; i++)
        {
            list.Add(Screen.resolutions[i].width.ToString() + " x " + Screen.resolutions[i].height.ToString());
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(list);
        dropdown.onValueChanged.AddListener(SetResolution);
    }
    private void SetResolution(int index)
    {
        Debug.Log(index);
        Screen.SetResolution(Screen.resolutions[index].width, Screen.resolutions[index].height, false);
    }
    private void SetFullscreen(bool value)
{
   Debug.Log(value);
   Screen.fullScreen = value;
}
    bool Esc;
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) == true)
        {
            Esc = !Esc;
            // gameObject.GetComponent<Canvas>().enabled = false;
        }
        if (Esc == true)
        {
            gameObject.GetComponent<Canvas>().enabled = false;
        }
        else
        {
            gameObject.GetComponent<Canvas>().enabled = true;
            Cursor.SetCursor(null, new Vector2(32, 32), CursorMode.ForceSoftware);
        Cursor.visible = false;
        }
        // Debug.Log(Input.GetKeyUp(KeyCode.Escape));
        //Debug.Log(gameObject.GetComponent<Canvas>().enabled);
    }

}