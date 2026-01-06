using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    [SerializeField] private Button cardButton;
    [SerializeField] private Image cardImage;
    [SerializeField] private GameObject cardCover;

    private bool isCardActive = false;
    

    private void Awake() {
        cardButton.onClick.AddListener(() =>
        {
            OpenCard();
        });
    }

    public void OpenCard() {
        if (!isCardActive)
        {
            cardCover.SetActive(false);
            isCardActive = true;
        }
        else {
            cardCover.SetActive(true);
            isCardActive = false;
        }
    }

    public void CloseCard() {

    }

    public Image GetCardImage() { 
        return cardImage;
    }
    
    public void SetCardImage(Image image) {
        cardImage = image;
    }
}
