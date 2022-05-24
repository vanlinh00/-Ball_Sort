using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    public Text textCoin;
    int addCoinInt = 0;
    public static UiController Instance;
    public GameObject btStartGame;
    public GameObject allCavas;

    [SerializeField]
    GameObject _complete;
    void Start()
    {
        Instance = this;

        DontDestroyOnLoad(this.gameObject);
        DontDestroyOnLoad(allCavas);
    }
    void Update()
    {

    }
    public void ButtonCheck()
    {
        GameController.Instance.CheckRanDom();
    }
    public void startGame()
    {


        btStartGame.SetActive(false);
        _complete.SetActive(false);
        SceneManager.LoadScene(1);
    }

    public void nextLevel()
    {
        GameController.Instance._setUpGame.SetActive(false);

        _complete.SetActive(true);

    }

    public void addCoin()
    {
        addCoinInt += 200;
        textCoin.text = addCoinInt.ToString();
    }

}
