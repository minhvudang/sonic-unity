using UnityEngine;
using System.Collections;

public class Player
{
    public static int record;// diem cao  nhat toi hine tai
	public static int coin;// diem hine tai
	public static int heath;
	public static float speedMove;
	public static float speedJump;
    public static float speedMeterBg;
    public static int gold;// so dong tien tren man hinh
    private float speedMoveMonster;// speedmove cua monster

    public static float speedMonster;
	public static void setDead(GameObject player)
	{
		MonoBehaviour.Destroy (player);
	}
    public float SpeedMonster// get set trong C#
    {
        get
        {
            return this.speedMoveMonster;
        }
        set
        {
            this.speedMoveMonster = value;// value la tu khoa dac biet trong C# la gia tri minh nhap vao
        }
    }
}
