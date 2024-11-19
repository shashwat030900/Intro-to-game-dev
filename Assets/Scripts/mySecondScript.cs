using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class mySecondScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
        public Button button;
    public string newScene;
    private void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }
    private void OnButtonClick()
    {
        Debug.Log("Button Clicked");
        SceneManager.LoadScene(newScene, LoadSceneMode.Single);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
