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

        // int�^�̔z��array�̏�����
        int[]array =new int[5];

        //�z��̊e�v�f�ɒl��������
        array[0] = 120;
        array[1] = 80;
        array[2] = 100;
        array[3] = 130;
        array[4] = 90;

        // �z��̗v�f�����ׂĕ\������
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        // �z��̗v�f�����ׂċt���ɕ\������
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
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
    // ���͂�53�ŏ���������
    int mp = 53;


    //���@�p�̊֐�
    public void Magic()
    {
         if (this.mp >= 5)
        {
            //mp��5���炷
            mp = mp - 5;
            
            //mp��5�ȏ�̏ꍇ�A���@�U��������
            Debug.Log("���@�U���������B�c��MP��"+ this.mp);
        }
        else
        {
            //mp��5�����̏ꍇ�A���@���g���Ȃ�
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��I");

        }
    }
}

