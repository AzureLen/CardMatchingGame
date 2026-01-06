using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardArea : MonoBehaviour
{
    [SerializeField] private GameObject cardArea;
    [SerializeField] private GameObject card;
    [SerializeField] private List<GameObject> cardList;
    [SerializeField] private List<Sprite> spriteList;
    [SerializeField] private int numberOfCardPairs;

    private void Awake() {
        int cardCount = numberOfCardPairs * 2;
        for (int i = 0; i < cardCount; i++)
        {
            GameObject cardObject = Instantiate(card);
            //Image cardImage = spriteList[i].;
            //cardObject.GetComponent<Card>().SetCardImage(spriteList[i].Image.sprite);
            cardList.Add(cardObject);
            cardObject.transform.SetParent(gameObject.transform, false);
        }
    }
}
