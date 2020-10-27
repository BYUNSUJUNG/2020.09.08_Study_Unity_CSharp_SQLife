using UnityEngine;
using System.IO;

public class DemoSqlite : MonoBehaviour
{
    public string m_DatabaseFileName = "NumData.db";
    public string m_TableName = "NumDataTable";
    private SqliteDatabaseAccess m_SqliteDatabaseAccess;

    void Start()
    {
        string filePath = Path.Combine(Application.streamingAssetsPath, m_DatabaseFileName);
        Debug.Log(filePath);
        m_SqliteDatabaseAccess = new SqliteDatabaseAccess("data source = " + filePath);

        m_SqliteDatabaseAccess.CreateTable("NumDataTable01",
            new string[] { "wearing", "wearingNum" },
            new string[] { "text", "int" });

        //m_SqliteDatabaseAccess.InsertInto("TestTable1", new string[] { "'Coderzedro'", "'47'" });
        //m_SqliteDatabaseAccess.InsertInto("TestTable1", new string[] { "'JD'", "'17'" });
        //m_SqliteDatabaseAccess.InsertInto("TestTable1", new string[] { "'Tiger'", "'47'" });

        m_SqliteDatabaseAccess.CloseSqlConnection();
    }
}