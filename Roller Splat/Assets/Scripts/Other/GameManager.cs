using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField] private Image soGoodObject;
    public List<GameObject> groundList = new List<GameObject>();



    public void SetGroundList(GameObject _gameObject)
    {
        groundList.Remove(_gameObject);
        SetLevelController();
    }



    public void SetLevelController()
    {
        if (groundList.Count == 0)
        {
            Time.timeScale = 0;
            soGoodObject.gameObject.SetActive(true);
        }
    }
}
