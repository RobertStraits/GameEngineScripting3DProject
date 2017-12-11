using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DamControls : MonoBehaviour, IActivatable
{
    [SerializeField]
    private string nameText = "Dam Controls";

    [SerializeField]
    InventoryObject key;

    private bool isLocked, isOpen;
    private List<InventoryObject> playerInventory;

    public string NameText
    {
        get
        {
            string toReturn = nameText;

            if (isOpen)
                toReturn = ""; // So it doesn't look like you can open the door anymore.
            else if (isLocked && !HasKey)
                toReturn += " (UNPOWERED)";
            else if (isLocked && HasKey)
                toReturn += string.Format(" (use {0})", key.NameText);

            return toReturn;
        }
    }
    private bool HasKey
    {
        get
        {
            return playerInventory.Contains(key);
        }
    }
    public void DoActivate()
    {
        if (!isOpen)
        {
            if (!isLocked || HasKey)
            {
                SceneManager.LoadScene("WinScene");
                isOpen = true;
            }
        }
    }
    // Use this for initialization
    void Start ()
    {
        playerInventory = FindObjectOfType<InventoryMenu>().PlayerInventory;
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
