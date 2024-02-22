using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���O��ۑ�����N���X�ł�
// �g���q�̍폜�Ȃǂ��s�����Ƃ��ł��܂��B

public class Name
{
    // ���O��ۑ�
    public string value = "";

    // �g���q�폜
    public string DeleteExtension()
    {
        int dotIndex = 0;
        string NoneExtensionName = value;
        bool isEqual = false;

        for (int i = 0; i < NoneExtensionName.Length; i++)
        {
            isEqual = EqualString(i, NoneExtensionName, ".");
            // .��������l��ۑ�
            dotIndex = (isEqual) ? i : dotIndex;
            // true�Ȃ瑖��������
            i = (isEqual) ? NoneExtensionName.Length : i;
        }

        NoneExtensionName = NoneExtensionName.Substring(0, dotIndex);

        return NoneExtensionName;
    }

    private bool EqualString(int startIndex, string targetString, string searchString)
    {
        // �����͈�
        int searchLength = startIndex + searchString.Length;

        // �����͈͂������Ώۂ̕�����̒����ȉ��A����
        // 
        if (
            searchLength <= targetString.Length &&
            targetString.Substring(startIndex, searchString.Length) == searchString
            )
        {
            return true;
        }
        return false;
    }
}
