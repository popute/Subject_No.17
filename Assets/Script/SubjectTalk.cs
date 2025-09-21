using UnityEngine;
using UnityEngine.UI;

public class SubjectTalk : MonoBehaviour
{
    public Text reaction;

    public void Vegetables()//食事
    {
        reaction.text = "少し物足りなそうに食べている。";
    }
    public void Animal()//食事
    {
        reaction.text = "嫌そうだが、満腹にはなったようだ";
    }
    public void Snack()//食事
    {
        reaction.text = "うれしそうに食べている、、、やりすぎに注意だな";
    }
    public void SubjectClean()//清掃
    {
        reaction.text = "体がきれいになって満足そうだ";
    }
    public void RoomClean()//清掃
    {
        reaction.text = "部屋がきれいになって満足そうだ";
    }
    public void Present()//コミュニケーション
    {
        reaction.text = "すごくうれしそうにこちらを見ている";
    }
    public void Talk()//コミュニケーション
    {
        reaction.text = "なんだか楽しそうだ";
    }
    public void Administrative()//コミュニケーション
    {
        reaction.text = "寂しそうな顔をしている";
    }
    public void Blood()//検体採取
    {
        reaction.text = "なんだかすごく疲れている";
    }
    public void Excrement()//検体採取
    {
        reaction.text = "すごく恥ずかしそうにしている";
    }
    public void Spit()//検体採取
    {
        reaction.text = "不思議そうな顔をしている";
    }
}
