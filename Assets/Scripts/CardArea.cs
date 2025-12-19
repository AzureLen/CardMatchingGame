using UnityEngine;

public class CardArea : MonoBehaviour
{
    [SerializeField] private GameObject cardArea;
    [SerializeField] private GameObject card;
    [SerializeField] private int numberOfCardPairs;

    private void Awake() {
        int cardCount = numberOfCardPairs * 2;
        for (int i = 0; i < cardCount; i++)
        {
            GameObject cardObject = Instantiate(card);

            cardObject.transform.SetParent(gameObject.transform, false);
        }
    }
}
