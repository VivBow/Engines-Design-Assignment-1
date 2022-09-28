using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EditorManager : MonoBehaviour
{
    PlayerActionsManager inputAction;

    public Camera mainCam;
    public Camera editorCam;

    public GameObject prefab1;
    public GameObject prefab2;

    GameObject item;

    public bool editorMode = false;
    bool instantiated = false;


    // Start is called before the first frame update
    void Awake()
    {
        inputAction = new PlayerActionsManager();

        inputAction.Editor.EnableEditor.performed += cntxt => SwitchCamera();

        //inputAction.AddItem1.performed += cntxt => AddItem(1);
        //inputAction.AddItem2.performed += cntxt => AddItem(2);
        //inputAction.DropItem.performed += cntxt => DropItem();

        mainCam.enabled = true;
        editorCam.enabled = false;
    }

    private void OnEnable()
    {

        inputAction.Editor.Enable();
    }

    private void OnDisable()
    {
        inputAction.Editor.Disable();
    }

    private void SwitchCamera()
    {
        mainCam.enabled = !mainCam.enabled;
        editorCam.enabled = !editorCam.enabled;
    }

    //private void AddItem(int itemId)
    //{
    //    if (editorMode && !instantiated)
    //    {
    //        switch(itemId)
    //        {
    //            case 1:
    //                item = Instantiate(prefab1);
    //                break;
    //            case 2:
    //                item = Instantiate(prefab2);
    //                break;
    //            default:
    //                break;

    //        }

    //        instantiated = true;
    //    }
    //}

    //private void DropItem()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        if (mainCam.enabled == false && editorCam.enabled == true)
        {
            editorMode = true;
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            editorMode = false;
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
