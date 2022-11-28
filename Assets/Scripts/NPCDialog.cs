using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CircleCollider2D))]

public class NPCDialog : MonoBehaviour
{
    public string npcName;
    public string[] npcDialogLines;
    private DialogManager dialogManager;
    private bool isPlayerInDialogZone;

    void Start()
    {
        dialogManager = FindObjectOfType<DialogManager>();
    }

    void Update()
    {
        if (isPlayerInDialogZone && Input.GetMouseButtonDown(1))
        {
            //dialogManager.ShowDialog(DialogPlusNPCName());
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            isPlayerInDialogZone = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            isPlayerInDialogZone = false;
        }
    }

    /*
    public string DialogPlusNPCNam()
    {
        string[] finalDialog = new string[npcDialogLines.Length];
        int i = 0;
        foreach (string line in npcDialogLines)
        {
            if(npcName != null)
            {
                finalDialog[i] = $"{npcName}\n{npcDialogLines[i]}";
            }
            else
            {
                finalDialog[i] = npcDialogLines.ToString();
            }
            //return finalDialog;
        }
    }
    */

}
    


