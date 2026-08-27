using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField]
    private float GameTime;

    [SerializeField]
    private TMP_Text timerText;

    public bool isPlaying;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    void Start()
    {
        isPlaying = true;
    }

    void Update()
    {
        //while(GameTime > 0)
        if(GameTime > 0)
        {
            GameTime -= Time.deltaTime;
            int min = (int)GameTime / 60;
            int seg = (int)GameTime % 60;
            timerText.text = min.ToString("00") + ":" + seg.ToString("00");
        }
        if(GameTime <= 0)
        {
            isPlaying = false;
        }
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene(0);
    }
}
