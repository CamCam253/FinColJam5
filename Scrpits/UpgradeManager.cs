using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Text upgradeText1;
    [SerializeField] Text upgradeText2;
    [SerializeField] Text upgradeText3;
    [SerializeField] List<Upgrade> upgradeList = new List<Upgrade>();
    [SerializeField] List<Upgrade> shownUpgrades = new List<Upgrade>();
    // Start is called before the first frame update
    void Start()
    {

        gameObject.SetActive(false);
        //newUpgrades();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void newUpgrades()
    {
        gameObject.SetActive(true);
        List<int> unum = randNum();
        shownUpgrades.Add(upgradeList[0]);
        shownUpgrades.Add(upgradeList[1]);
        shownUpgrades.Add(upgradeList[2]);
        upgradeText1.text = upgradeList[unum[0]].upgradeName;
        upgradeText2.text = upgradeList[unum[1]].upgradeName;
        upgradeText3.text = upgradeList[unum[2]].upgradeName;
    }

    List<int> randNum()
    {
        bool done = false;
        int rnum;
        List<int> rand = new List<int>();
        while (!done)
        {
            rnum = Random.Range(0, upgradeList.Count);
            if (rand.Contains(rnum))
            {
                rnum = Random.Range(0, upgradeList.Count);
            }
            else
            {
                rand.Add(rnum);
            }
            if (rand.Count == 3)
            {
                done = true;
                break;
            }
        }
        return rand;
    }
    public void upgrade1()
    {
        pickUpgrade(0);
    }
    public void upgrade2()
    {
        pickUpgrade(1);
    }
    public void upgrade3()
    {
        pickUpgrade(2);
    }
    void pickUpgrade(int upgrade)
    {
        switch (shownUpgrades[upgrade].stat)
        {
            case Stats.firerate:
                if (PlayerManager.firingSpeed >= 0.05)
                {
                    PlayerManager.firingSpeed -= 0.05f;
                }
                break;
            case Stats.health:
                PlayerManager.Health += 1;
                break;
            case Stats.speed:
                PlayerManager.moveSpeed += 0.05f;
                break;
            case Stats.stamina:
                break;
            case Stats.upgrade:
                break;
            default:
                break;
        }
    }
}
