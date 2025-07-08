using UnityEngine;
using UnityEngine.SceneManagement; // ต้องใช้สำหรับโหลด Scene ใหม่

public class GameManager : MonoBehaviour
{
    // ฟังก์ชันสำหรับปุ่ม Restart Game
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // โหลด Scene ปัจจุบันใหม่
        Time.timeScale = 1f; // ตรวจสอบให้แน่ใจว่าเกมกลับมาเดินตามปกติ (ถ้ามีการหยุดเกม)
    }

    // ฟังก์ชันสำหรับปุ่ม Quit Game
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // สำหรับหยุดเล่นใน Unity Editor
#else
        Application.Quit(); // สำหรับเมื่อ Build เกมออกไปแล้ว
#endif
    }
}