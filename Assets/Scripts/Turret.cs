using UnityEngine;

/// <summary>
/// 车载武器
/// </summary>
public class Turret : MonoBehaviour
{
    /// <summary>
    /// 俯仰物体，摄像机、枪都要跟随它旋转
    /// </summary>
    public Transform MouseLookTra;
    /// <summary>
    /// 左右枪
    /// </summary>
    public Gun LeftGun, RightGun;
    /// <summary>
    /// 刚才开火的是左枪吗，用于控制交替开火
    /// </summary>
    private bool _isLastFiredGunLeft;

    void Update()
    {
        //枪管方向与俯仰物体一直（注意这里不用子物体是因为旋转轴不一样）
        LeftGun.transform.localRotation = MouseLookTra.localRotation;
        RightGun.transform.localRotation = MouseLookTra.localRotation;

        if (Input.GetKey(KeyCode.Mouse0))//按住鼠标左键
        {
            if (Time.frameCount%5 == 0)//每5帧开火一次
            {
                if (_isLastFiredGunLeft)
                {//上一次是左枪开火，那现在就是右枪开火
                    RightGun.Fire();
                    _isLastFiredGunLeft = false;//标记一下，右枪刚刚开过火
                }
                else
                {
                    LeftGun.Fire();
                    _isLastFiredGunLeft = true;
                }
            }
        }
    }

}