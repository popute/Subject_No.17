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
        SubjectStatus.Instance.AddScore('H', vegetablesH);
        SubjectStatus.Instance.AddScore('M', vegetablesM);
        SubjectStatus.Instance.AddScore('T', vegetablesT);
        SubjectStatus.Instance.AddScore('U', vegetablesU);
    }
    public void Animal()//食事
    {
        SubjectStatus.Instance.AddScore('H', animalH);
        SubjectStatus.Instance.AddScore('M', animalM);
        SubjectStatus.Instance.AddScore('T', animalT);
        SubjectStatus.Instance.AddScore('U', animalU);
    }
    public void Snack()//食事
    {
        SubjectStatus.Instance.AddScore('H', snackH);
        SubjectStatus.Instance.AddScore('M', snackM);
        SubjectStatus.Instance.AddScore('T', snackT);
        SubjectStatus.Instance.AddScore('U', snackU);
    }
    public void SubjectClean()//清掃
    {
        SubjectStatus.Instance.AddScore('H', subjectCleanH);
        SubjectStatus.Instance.AddScore('M', subjectCleanM);
        SubjectStatus.Instance.AddScore('T', subjectCleanT);
        SubjectStatus.Instance.AddScore('U', subjectCleanU);
    }
    public void RoomClean()//清掃
    {
        SubjectStatus.Instance.AddScore('H', roomCleanH);
        SubjectStatus.Instance.AddScore('M', roomCleanM);
        SubjectStatus.Instance.AddScore('T', roomCleanT);
        SubjectStatus.Instance.AddScore('U', roomCleanU);
    }
    public void Present()//コミュニケーション
    {
        SubjectStatus.Instance.AddScore('H', presentH);
        SubjectStatus.Instance.AddScore('M', presentM);
        SubjectStatus.Instance.AddScore('T', presentT);
        SubjectStatus.Instance.AddScore('U', presentU);
    }
    public void Talk()//コミュニケーション
    {
        SubjectStatus.Instance.AddScore('H', talkH);
        SubjectStatus.Instance.AddScore('M', talkM);
        SubjectStatus.Instance.AddScore('T', talkT);
        SubjectStatus.Instance.AddScore('U', talkU);
    }
    public void Administrative()//コミュニケーション
    {
        SubjectStatus.Instance.AddScore('H', administrativeH);
        SubjectStatus.Instance.AddScore('M', administrativeM);
        SubjectStatus.Instance.AddScore('T', administrativeT);
        SubjectStatus.Instance.AddScore('U', administrativeU);
    }
    public void Blood()//検体採取
    {
        SubjectStatus.Instance.AddScore('H', bloodH);
        SubjectStatus.Instance.AddScore('M', bloodM);
        SubjectStatus.Instance.AddScore('T', bloodT);
        SubjectStatus.Instance.AddScore('U', bloodU);
    }
    public void Excrement()//検体採取
    {
        SubjectStatus.Instance.AddScore('H', excrementH);
        SubjectStatus.Instance.AddScore('M', excrementM);
        SubjectStatus.Instance.AddScore('T', excrementT);
        SubjectStatus.Instance.AddScore('U', excrementU);
    }
    public void Spit()//検体採取
    {
        SubjectStatus.Instance.AddScore('H', spitH);
        SubjectStatus.Instance.AddScore('M', spitM);
        SubjectStatus.Instance.AddScore('T', spitT);
        SubjectStatus.Instance.AddScore('U', spitU);
    }
    
}
