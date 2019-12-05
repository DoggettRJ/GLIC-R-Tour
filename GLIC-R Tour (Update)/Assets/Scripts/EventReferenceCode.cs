using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class EventReferenceCode : MonoBehaviour
{

}

public class Player : MonoBehaviour
{
    public delegate void PlayerTookDamageEvent(int hp);
    public event PlayerTookDamageEvent OnPlayerTookDamage;

    public int HP { get; set; }

    public void Start()
    {
        HP = 10;
    }

    public void TakeDamage()
    {
        HP -= 1;
        if (OnPlayerTookDamage != null)
            OnPlayerTookDamage(HP);
    }
}

public class PlayerHPBar : MonoBehaviour
{
    private Text _text;

    public void Awake()
    {
        _text = GetComponent<Text>();
        Player player = FindObjectOfType<Player>();
        player.OnPlayerTookDamage += HandlePlayerTookDamage;
    }

    public void HandlePlayerTookDamage(int hp)
    {
        _text.text = hp.ToString();
    }
}


public class PlayerDamager : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(DealDamageEvery5Seconds());
    }

    private IEnumerator DealDamageEvery5Seconds()
    {
        while (true)
        {
            FindObjectOfType<Player>().TakeDamage();
            yield return new WaitForSeconds(5f);
        }
    }
}

