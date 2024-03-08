using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkillParameters", menuName = "ScriptableObjects/SkillParameterData")]
public class SkillParameterData : ScriptableObject
{
    [Header("技能値リスト")]
    [SerializeField] private List<SkillTRPGParameter> Parameters;

    public Dictionary<string, TRPGParameter> SkillTRPGParameters
    {
        get
        {
            Dictionary<string, TRPGParameter> skillTRPGParameters = new Dictionary<string, TRPGParameter>();
            foreach (var item in Parameters)
            {
                skillTRPGParameters.Add(item.SkillName, item.Parameter);
            }
            return skillTRPGParameters;
        }
    }
}
