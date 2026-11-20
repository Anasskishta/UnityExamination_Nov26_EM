using Unity.VisualScripting;
using UnityEngine;

public class LevelEntrance : MonoBehaviour
{
    [SerializeField] private string nextlevelName;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            GameManager.instance.ChangeLevelTo(nextlevelName);
    }
}