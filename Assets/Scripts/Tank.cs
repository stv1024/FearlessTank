using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

/// <summary>
/// 坦克
/// </summary>
public class Tank : MonoBehaviour
{
    /// <summary>
    /// 炮台
    /// </summary>
    public Turret Turret;

    [SerializeField] private MouseLook _mouseLook; //照搬示例的脚本，有点复杂不便解释

    private void Awake()
    {
        _mouseLook.Init(Turret.transform, Turret.MouseLookTra); //初始化MouseLook功能(只水平旋转的部分即炮台, 上下旋转的部分)
        Cursor.lockState = CursorLockMode.Locked; //锁定鼠标
        Cursor.visible = false; //隐藏鼠标
    }

    private void Update()
    {
        _mouseLook.LookRotation(Turret.transform, Turret.MouseLookTra);//使用MouseLook功能，实时改变炮台和俯仰物体的旋转
    }
}