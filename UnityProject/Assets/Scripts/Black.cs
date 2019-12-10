using UnityEngine;
using UnityEngine.UI;

public class Black : MonoBehaviour
{
    #region 練習區域 - 在此區域內練習

    public int HP = 10;
    public Text textHP;
    public AudioSource aud;
    public AudioClip soundhurt;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HP = HP - 1;
        textHP.text = HP.ToString();
        aud.PlayOneShot(soundhurt);
    }

    private void Update()
    {
        if (HP <= 0)
        {
            Destroy(gameObject,0);
        }
    }

    #endregion
}
