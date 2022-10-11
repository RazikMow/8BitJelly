using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinsCahnger : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textScore;
    public int coins;

    public GameObject cylinder1;
    public GameObject tree2;
    public GameObject textOnTheScreen3;

    [SerializeField] private Button fistButton;
    [SerializeField] private Button secondButton;
    [SerializeField] private Button thirstButton;
    
    private void Start()
    {
        coins = 0;
        textScore.text = coins.ToString();
        
        cylinder1.SetActive(false);
        tree2.SetActive(false);
        textOnTheScreen3.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Coin")
        {
            Destroy(other.gameObject);
            coins += 1;
            textScore.text = coins.ToString();
        }
    }

    private void Update()
    {

        if(coins >= 1)
        {
            fistButton.interactable = true;
            Debug.Log("Hejka");
        }
        else
        {
            fistButton.interactable = false;
        }

        if(coins >= 3)
        {
            secondButton.interactable = true;
            Debug.Log("Hjkea2");
        }
        else
        {
            secondButton.interactable = false;
        }

        if(coins >= 5)
        {
            thirstButton.interactable = true;
            Debug.Log("Hejka34");
        }
        else
        {
            thirstButton.interactable = false;
        }
    }

    public void FirstButton()
    {
        if(coins >= 1)
        {
            coins -= 1;
            UpdateUI();
            cylinder1.SetActive(true);
        }
    }

    public void SecondButton()
    {
        if(coins >= 3)
        {
            coins -= 3;
            UpdateUI();
            tree2.SetActive(true);
        }
    }

    public void ThirdButton()
    {
        if(coins >= 5)
        {
            coins -= 5;
            UpdateUI();
            textOnTheScreen3.SetActive(true);
        }
    }
    
    private void UpdateUI(){
        textScore.text = coins.ToString();
    }
}
