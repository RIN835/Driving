using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameObject missionAccomplishedCanvas; // ลาก MissionAccomplishedCanvas มาใส่ใน Inspector

    private void OnTriggerEnter(Collider other)
    {
        // ตรวจสอบว่าวัตถุที่ชนคือรถของผู้เล่นหรือไม่ (สมมติว่ารถมี Tag เป็น "Player")
        if (other.CompareTag("Player"))
        {
            Debug.Log("Mission Accomplished!");
            // เปิดใช้งาน Canvas หน้าจอ Mission Accomplished!
            if (missionAccomplishedCanvas != null)
            {
                missionAccomplishedCanvas.SetActive(true);
            }

            // หยุดรถของผู้เล่น (ถ้าต้องการ) หรือล็อคอินพุต
            Rigidbody playerRigidbody = other.GetComponent<Rigidbody>();
            if (playerRigidbody != null)
            {
                // *** แก้ไขตรงนี้: ใช้ linearVelocity และ angularVelocity ***
                playerRigidbody.linearVelocity = Vector3.zero;
                playerRigidbody.angularVelocity = Vector3.zero;
            }
            // หรือปิด Script ควบคุมรถ
            // other.GetComponent<ชื่อScriptควบคุมรถ>().enabled = false;
        }
    }
}