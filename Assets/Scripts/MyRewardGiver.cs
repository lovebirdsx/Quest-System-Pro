using UnityEngine;
using Devdog.QuestSystemPro;
using Devdog.QuestSystemPro.UI;

public class MyRewardGiver : INamedRewardGiver 
{
    [SerializeField]
    string _name;

    public string name => _name;

    public RewardRowUI rewardUIPrefab => QuestManager.instance.settingsDatabase.defaultRewardRowUI;

    public ConditionInfo CanGiveRewards(Quest quest)
    {
        return ConditionInfo.success;
    }

    public void GiveRewards(Quest quest)
    {
        Debug.Log($"Give [my rewards] for quest: {quest.name}");
    }
}
