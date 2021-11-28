using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace on_off_proj
{
    class DBManager
    {
        private List<chatListClass> chatLists = new List<chatListClass>();
        private int check = 0;
        private string myConnection = connection.connect();
        private string userId = "";
        
        private static DBManager instance_ = new DBManager();

        public static DBManager GetInstance()
        {
            return instance_;
        }

        public void setUserId(string uId)
        {
            this.userId = uId;
        }

        // 해당 테이블에 값 존재하는지 확인 또는 정수 반환하는 함수 사용할 떄
        public int exists(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(myConnection))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                check = Convert.ToInt32(cmd.ExecuteScalar());

                return check;
            }
        }

        public DataTable select(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(myConnection))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);

                return dt;
            }
        }

        public void insert(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(myConnection))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

            }
        }
        public void imageInsert(string query, byte[] data)
        {
            using (MySqlConnection conn = new MySqlConnection(myConnection))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Image", data);
                cmd.ExecuteNonQuery();

            }
        }
    


    public DataTable readChatLog(int roomId)
        {
            string query = "SELECT * FROM Chat_History WHERE (roomId = "+roomId+");";
            using (MySqlConnection conn = new MySqlConnection(myConnection))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);

                return dt;           
            }
        }


        public void readChatList(string uID)
        {
            using (MySqlConnection conn = new MySqlConnection(myConnection))
            {
                conn.Open();

                string query = "SELECT * FROM Chat_list WHERE (userId like '%" + uID + "%');";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    chatLists.Add(new chatListClass(rdr["userId"].ToString(), Convert.ToInt32(rdr["roomId"].ToString())));
                }

                rdr.Close();


                query = "SELECT * FROM CheckReceive WHERE (userId = '" + uID + "');";
                cmd = new MySqlCommand(query, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    int countContents = 0;
                    int roomId = Convert.ToInt32(rdr["roomId"].ToString());
                    chatLists.Find(x => x.getRID() == roomId).setTimeStamp(rdr["timeStamp"].ToString());
                    check = Convert.ToInt32(rdr["checkRead"].ToString());
                    if (check == 0)
                    {
                        string query2 = "SELECT timeStamp, contents FROM Chat_History WHERE (roomId = " + roomId + " AND timeStamp > str_to_date('" + rdr["timeStamp"].ToString() + "', '%Y-%m-%d %h:%i:%s')) ORDER BY timeStamp;";
                        MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                        MySqlDataReader rdr2 = cmd2.ExecuteReader();
                        while (rdr2.Read())
                        {
                            countContents++;
                            chatLists.Find(x => x.getRID() == roomId).setContents(rdr["contents"].ToString());
                        }
                        chatLists.Find(x => x.getRID() == roomId).setCount(countContents);
                        rdr2.Close();
                    }
                }
                rdr.Close();
            }
        }


        public List<chatListClass> getChatList()
        {
            return chatLists;
        }
       
        public string getUserId()
        {
            return userId;
        }
    }

}
