using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject cons;
    [SerializeField] GameObject gWin;
    [SerializeField] GameObject game;
    [SerializeField] GameObject sManager;
    [SerializeField] Text consText;
    public bool gameStarted = false;
    // Start is called before the first frame update
    void Start()
    {
        cons = GameObject.Find("Console");
        consText = GameObject.Find("ConsoleText").GetComponent<Text>();
        gWin = GameObject.Find("Game Window");
        consText.text = "";
        cons.SetActive(false);
        gWin.SetActive(false);
        sManager.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStarted)
        {
            game.SetActive(true);
        }
    }
    private float rNum()
    {
        float num;
        num = Random.Range(0.01f, 1f);
        return num;
    }
    public void StartGame()
    {
        StartCoroutine(sGame());
    }
    IEnumerator sGame()
    {
        cons.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        consText.text += "Initializing Quantum Algorithm\n";
        yield return new WaitForSeconds(rNum());
        consText.text += "| ##";
        yield return new WaitForSeconds(rNum());
        consText.text += "###";
        yield return new WaitForSeconds(rNum());
        consText.text += "#";
        yield return new WaitForSeconds(rNum());
        consText.text += "#### |\n";
        yield return new WaitForSeconds(rNum());

        consText.text += "Launching Mission Critical System...\n";
        yield return new WaitForSeconds(rNum());
        consText.text += "| ##";
        yield return new WaitForSeconds(rNum());
        consText.text += "###";
        yield return new WaitForSeconds(rNum());
        consText.text += "#";
        yield return new WaitForSeconds(rNum());
        consText.text += "###";
        yield return new WaitForSeconds(rNum());
        consText.text += "# |\n";

        consText.text += "Establishing Secure Connection...\n";
        yield return new WaitForSeconds(rNum());
        consText.text += "| #";
        yield return new WaitForSeconds(rNum());
        consText.text += "###";
        yield return new WaitForSeconds(rNum());
        consText.text += "###";
        yield return new WaitForSeconds(rNum());
        consText.text += "#";
        yield return new WaitForSeconds(rNum());
        consText.text += "## |\n";

        consText.text += "Activating Neural Network...\n";
        yield return new WaitForSeconds(rNum());
        consText.text += "| ####";
        yield return new WaitForSeconds(rNum());
        consText.text += "##";
        yield return new WaitForSeconds(rNum());
        consText.text += "#";
        yield return new WaitForSeconds(rNum());
        consText.text += "##";
        yield return new WaitForSeconds(rNum());
        consText.text += "# |\n";

        consText.text += "Executing Code Inception Sequence...\n";
        yield return new WaitForSeconds(rNum());
        consText.text += "| #";
        yield return new WaitForSeconds(rNum());
        consText.text += "###";
        yield return new WaitForSeconds(rNum());
        consText.text += "##";
        yield return new WaitForSeconds(rNum());
        consText.text += "###";
        yield return new WaitForSeconds(rNum());
        consText.text += "# |\n";

        consText.text += "Decrypting Classified Data...\n";
        yield return new WaitForSeconds(rNum());
        consText.text += "| ###";
        yield return new WaitForSeconds(rNum());
        consText.text += "####";
        yield return new WaitForSeconds(rNum());
        consText.text += "#";
        yield return new WaitForSeconds(rNum());
        consText.text += "#";
        yield return new WaitForSeconds(rNum());
        consText.text += "# |\n";
        yield return new WaitForSeconds(rNum());
        consText.text += "--------------------------------\n";
        consText.text += "CODE NAME: insert game name\n";
        consText.text += "--------------------------------\n";
        consText.text += "Mission Control: Standby";
        yield return new WaitForSeconds(1f);
        consText.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum";
        gWin.SetActive(true);
        gameStarted = true;
        sManager.SetActive(false);
        yield return new WaitForSeconds(2f);
        sManager.SetActive(true);

    }
}
