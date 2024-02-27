using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f_KeyNumberCombertion
{
    // �����L�[�ƑΉ��������l��ԋp���܂��B
    public int KeyNumberToInteger()
    {
        // �Ăяo���ꂽ�Ƃ��Ɍ��݃L�[��������Ă��邩���`�F�b�N
        if (Input.anyKey)
        {
            return AllKeyNumberCheck();
        }
        return -1;
    }

    // ���ׂĂ̐����L�[���������Atrue�Ȃ��̂ɑΉ�����������ԋp���܂��B
    private int AllKeyNumberCheck()
    {
        // �����L�[��0�Ɋ��蓖�Ă�ꂽ�����l
        const int ALPHAZEROINTEGER = 48;

        for (int i = 0; i < 10; i++)
        {
            // �����l����KeyCode�^�ɕύX���A�l���m�F����B
            // true�Ȃ�Ή��������l��ԋp����B
            if (Input.GetKey((KeyCode)(ALPHAZEROINTEGER + i)))
            {
                return i;
            }
        }
        return -1;
    }
}
