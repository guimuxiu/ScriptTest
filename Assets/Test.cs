using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // int型の配列arrayの初期化
        int[]array =new int[5];

        //配列の各要素に値を代入する
        array[0] = 120;
        array[1] = 80;
        array[2] = 100;
        array[3] = 130;
        array[4] = 90;

        // 配列の要素をすべて表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        // 配列の要素をすべて逆順に表示する
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        lastboss.Magic();
       
        lastboss.Magic();

        lastboss.Magic();

        lastboss.Magic();

        lastboss.Magic();

        lastboss.Magic();

        lastboss.Magic();

        lastboss.Magic();

        lastboss.Magic();

        lastboss.Magic();

        lastboss.Magic();

    }



}
public class Boss
{
    // 魔力を53で初期化する
    int mp = 53;


    //魔法用の関数
    public void Magic()
    {
         if (this.mp >= 5)
        {
            //mpを5減らす
            mp = mp - 5;
            
            //mpが5以上の場合、魔法攻撃をする
            Debug.Log("魔法攻撃をした。残りMPは"+ this.mp);
        }
        else
        {
            //mpが5未満の場合、魔法が使えない
            Debug.Log("MPが足りないため、魔法が使えない！");

        }
    }
}

