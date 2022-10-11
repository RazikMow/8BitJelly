using UnityEngine;

public class ShopSystem : MonoBehaviour
{
    [SerializeField] private GameObject _shop;

    public int shop;
    private void Start()
    {
        shop = 0;
        _shop.SetActive(false);
        Cursor.visible = false;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            shop += 1;
        }

        if(shop == 1)
        {
            _shop.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else if(shop ==  2)
        {
            Cursor.visible = false;
            _shop.SetActive(false);
        }

        if(shop == 2)
        {
            shop = 0;
        }
    }
}
