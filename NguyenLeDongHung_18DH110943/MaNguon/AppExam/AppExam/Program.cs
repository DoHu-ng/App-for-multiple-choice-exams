using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExam
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        ///Dành cho gửi nhận gói tin trên đường mạng
        static public byte[] dataSend = new byte[1024 * 50000];
        static public byte[] dataRec = new byte[1024 * 50000];
        static public string input = "";
        static public string output = "";        
        static public IPEndPoint ipep;
        static public Socket server;

        //Lưu và xác định danh tính người dùng
        static public bool isTeacher = false;
        static public string userLogin = "";
        static public string CodeExam = "";
        static public string CodeExamQ = "";
        static public string NameExamQ = "";
        static public string studentName = "";
        static public string idCode = "";
        static public int hour = 0;
        static public int minute = 0;
        static public int second = 0;

        [STAThread]      
        static void Main()
        {
            ipep = new IPEndPoint(IPAddress.Parse("169.254.237.167"), 8989);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Connect(ipep);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
