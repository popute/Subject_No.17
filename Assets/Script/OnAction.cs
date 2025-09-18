using UnityEngine;

public class OnAction : MonoBehaviour
{
    public static OnAction Instance { get; private set; }

    
    public int vegetablesH;
    public int vegetablesM;
    public int vegetablesT;
    public int vegetablesU;
    //
    public int animalH;
    public int animalM;
    public int animalT;
    public int animalU;
    //
    public int snackH;
    public int snackM;
    public int snackT;
    public int snackU;
    //
    public int subjectCleanH;
    public int subjectCleanM;
    public int subjectCleanT;
    public int subjectCleanU;
    //
    public int roomCleanH;
    public int roomCleanM;
    public int roomCleanT;
    public int roomCleanU;
    //
    public int presentH;
    public int presentM;
    public int presentT;
    public int presentU;
    //
    public int talkH;
    public int talkM;
    public int talkT;
    public int talkU;
    //
    public int administrativeH;
    public int administrativeM;
    public int administrativeT;
    public int administrativeU;
    //
    public int bloodH;
    public int bloodM;
    public int bloodT;
    public int bloodU;
    //
    public int excrementH;
    public int excrementM;
    public int excrementT;
    public int excrementU;
    //
    public int spitH;
    public int spitM;
    public int spitT;
    public int spitU;



    public void Vegetables()//食事
    {
        SubjectStatu.Instance.AddScore('H', vegetablesH);
        SubjectStatu.Instance.AddScore('M', vegetablesM);
        SubjectStatu.Instance.AddScore('T', vegetablesT);
        SubjectStatu.Instance.AddScore('U', vegetablesU);
    }
    public void Animal()//食事
    {
        SubjectStatu.Instance.AddScore('H', animalH);
        SubjectStatu.Instance.AddScore('M', animalM);
        SubjectStatu.Instance.AddScore('T', animalT);
        SubjectStatu.Instance.AddScore('U', animalU);
    }
    public void Snack()//食事
    {
        SubjectStatu.Instance.AddScore('H', snackH);
        SubjectStatu.Instance.AddScore('M', snackM);
        SubjectStatu.Instance.AddScore('T', snackT);
        SubjectStatu.Instance.AddScore('U', snackU);
    }
    public void SubjectClean()//清掃
    {
        SubjectStatu.Instance.AddScore('H', subjectCleanH);
        SubjectStatu.Instance.AddScore('M', subjectCleanM);
        SubjectStatu.Instance.AddScore('T', subjectCleanT);
        SubjectStatu.Instance.AddScore('U', subjectCleanU);
    }
    public void RoomClean()//清掃
    {
        SubjectStatu.Instance.AddScore('H', roomCleanH);
        SubjectStatu.Instance.AddScore('M', roomCleanM);
        SubjectStatu.Instance.AddScore('T', roomCleanT);
        SubjectStatu.Instance.AddScore('U', roomCleanU);
    }
    public void Present()//コミュニケーション
    {
        SubjectStatu.Instance.AddScore('H', presentH);
        SubjectStatu.Instance.AddScore('M', presentM);
        SubjectStatu.Instance.AddScore('T', presentT);
        SubjectStatu.Instance.AddScore('U', presentU);
    }
    public void Talk()//コミュニケーション
    {
        SubjectStatu.Instance.AddScore('H', talkH);
        SubjectStatu.Instance.AddScore('M', talkM);
        SubjectStatu.Instance.AddScore('T', talkT);
        SubjectStatu.Instance.AddScore('U', talkU);
    }
    public void Administrative()//コミュニケーション
    {
        SubjectStatu.Instance.AddScore('H', administrativeH);
        SubjectStatu.Instance.AddScore('M', administrativeM);
        SubjectStatu.Instance.AddScore('T', administrativeT);
        SubjectStatu.Instance.AddScore('U', administrativeU);
    }
    public void Blood()//検体採取
    {
        SubjectStatu.Instance.AddScore('H', bloodH);
        SubjectStatu.Instance.AddScore('M', bloodM);
        SubjectStatu.Instance.AddScore('T', bloodT);
        SubjectStatu.Instance.AddScore('U', bloodU);
    }
    public void Excrement()//検体採取
    {
        SubjectStatu.Instance.AddScore('H', excrementH);
        SubjectStatu.Instance.AddScore('M', excrementM);
        SubjectStatu.Instance.AddScore('T', excrementT);
        SubjectStatu.Instance.AddScore('U', excrementU);
    }
    public void Spit()//検体採取
    {
        SubjectStatu.Instance.AddScore('H', spitH);
        SubjectStatu.Instance.AddScore('M', spitM);
        SubjectStatu.Instance.AddScore('T', spitT);
        SubjectStatu.Instance.AddScore('U', spitU);
    }
    
}
