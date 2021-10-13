using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AppExamServer
{
    class Program
    {
        static void Main(string[] args)
        {
            int recv;
            byte[] data = new byte[1024];            
            byte[] gui = new byte[1024];

            string filename = "";
            string filename2 = "";
            string filename3 = "";
            string filename4 = "";
            string filename5 = "";
            string filename6 = "";
            string chuoiRec = "";
            string messSend = "";
            FileStream fs;
            bool accecptWrite = true;

            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("169.254.237.167"), 8989);
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            newsock.Bind(ipep);
            newsock.Listen(10);

            Console.WriteLine("\n Server Listening ... ");
            Socket client = newsock.Accept();

            do
            {
                recv = client.Receive(data);
                chuoiRec = Encoding.ASCII.GetString(data, 0, recv);
                Console.WriteLine(chuoiRec);

                string[] chuoiSplit = chuoiRec.Split('|');

                filename = "H:\\Study at school\\Lập trình mạng\\NguyenLeDongHung_18DH110943\\MaNguon\\AppExamServer\\dsRegister.txt";
                filename2 = "H:\\Study at school\\Lập trình mạng\\NguyenLeDongHung_18DH110943\\MaNguon\\AppExamServer\\dsExamPrepare.txt";
                filename3 = "H:\\Study at school\\Lập trình mạng\\NguyenLeDongHung_18DH110943\\MaNguon\\AppExamServer\\dsQuestion.txt";
                filename4 = "H:\\Study at school\\Lập trình mạng\\NguyenLeDongHung_18DH110943\\MaNguon\\AppExamServer\\dsExamQues.txt";
                filename5 = "H:\\Study at school\\Lập trình mạng\\NguyenLeDongHung_18DH110943\\MaNguon\\AppExamServer\\dsExamQuestion.txt";
                filename6 = "H:\\Study at school\\Lập trình mạng\\NguyenLeDongHung_18DH110943\\MaNguon\\AppExamServer\\dsThi.txt";

                switch (chuoiSplit[0])
                {
                    case "RS":
                        /////////////////////////////////////////////Start This Case//////////////////////////////////////
                        Console.WriteLine("*****************************************************************************");
                        Console.WriteLine("Server is processing at Register Form - Function Save");
                        Console.WriteLine("*****************************************************************************");
                        if (File.Exists(filename))
                        {
                            string[] dsAcc1 = File.ReadAllLines(filename);

                            string[] dsUsername = new string[dsAcc1.Length];
                            for (int i = 0; i < dsAcc1.Length; i++)
                            {
                                string[] temp = dsAcc1[i].Split('|');
                                dsUsername[i] = temp[1];
                            }

                            foreach (var item in dsUsername)
                            {
                                if (chuoiSplit[1] == item)
                                {
                                    accecptWrite = false;
                                    break;
                                }
                            }

                            fs = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.Write);
                        }
                        else
                        {
                            fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.Write);
                        }

                        if (accecptWrite == true)
                        {
                            StreamWriter sw1 = new StreamWriter(fs, Encoding.UTF8);
                            sw1.WriteLine(chuoiRec);
                            sw1.Flush();
                            Console.WriteLine("Ghi vao file danhsach.txt thanh cong");
                            messSend = "Ghi Account " + chuoiSplit[1] + " vao file dsRegister.txt thanh cong";                            
                        }
                        else
                        {
                            messSend = "Username " + chuoiSplit[1] + "da ton tai." + " Khong the tao tai khoan";
                        }                        
                        gui = Encoding.ASCII.GetBytes(messSend);
                        client.Send(gui, gui.Length, SocketFlags.None);
                        fs.Close();
                        break;
                    /////////////////////////////////////////////End This Case//////////////////////////////////////
                    case "RD":
                        /////////////////////////////////////////////Start This Case//////////////////////////////////////
                        Console.WriteLine("*****************************************************************************");
                        Console.WriteLine("Server is processing at Register Form - Function Delete");
                        Console.WriteLine("*****************************************************************************");
                        string[] dsAcc = File.ReadAllLines(filename);
                        string itemRemove = "";
                        foreach (var item in dsAcc)
                        {
                            string[] temp = item.Split('|');
                            if (temp[1] == chuoiSplit[1])
                            {
                                itemRemove = item;
                                break;
                            }
                        }

                        var lines = File.ReadAllLines(filename).Where(l => l.Trim() != itemRemove).ToArray();
                        File.WriteAllLines(filename, lines);

                        messSend = "Xoa Account " + chuoiSplit[1] + " thanh cong";

                        gui = Encoding.ASCII.GetBytes(messSend);
                        client.Send(gui, gui.Length, SocketFlags.None);
                        break;
                    /////////////////////////////////////////////End This Case//////////////////////////////////////
                    case "RU":
                        /////////////////////////////////////////////Start This Case//////////////////////////////////////
                        Console.WriteLine("*****************************************************************************");
                        Console.WriteLine("Server is processing at Register Form - Function Update");
                        Console.WriteLine("*****************************************************************************");
                        string[] dsAcc2 = File.ReadAllLines(filename);
                        string itemRemove2 = "";
                        foreach (var item in dsAcc2)
                        {
                            string[] temp = item.Split('|');
                            if (temp[1] == chuoiSplit[1])
                            {
                                itemRemove = item;
                                break;
                            }
                        }

                        var lines2 = File.ReadAllLines(filename).Where(l => l.Trim() != itemRemove2).ToArray();
                        File.WriteAllLines(filename, lines2);

                        if (File.Exists(filename))
                        {
                            fs = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.Write);
                        }
                        else
                        {
                            fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.Write);
                        }

                        StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                        sw.WriteLine(chuoiRec);
                        sw.Flush();
                        Console.WriteLine("Ghi vao file danhsach.txt thanh cong");
                        messSend = "Cap nhat Account " + chuoiSplit[1] + " vao file dsRegister.txt thanh cong";
                        gui = Encoding.ASCII.GetBytes(messSend);
                        client.Send(gui, gui.Length, SocketFlags.None);
                        fs.Close();
                        break;
                    /////////////////////////////////////////////End This Case//////////////////////////////////////
                    case "LL":
                        /////////////////////////////////////////////Start This Case//////////////////////////////////////
                        Console.WriteLine("*****************************************************************************");
                        Console.WriteLine("Server is processing at Login Form - Function Login");
                        Console.WriteLine("*****************************************************************************");
                        if (File.Exists(filename))
                        {
                            string[] dsAcc1 = File.ReadAllLines(filename);

                            
                            for (int i = 0; i < dsAcc1.Length; i++)
                            {
                                string[] temp = dsAcc1[i].Split('|');
                                if (temp[1]==chuoiSplit[1])
                                {
                                    messSend = temp[2];
                                    Console.WriteLine(messSend);
                                }
                            }                            

                            //fs = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.Write);
                        }
                        else
                        {
                            //fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.Write);
                            messSend = "";
                        }

                        if (messSend != "")
                        {
                            Console.WriteLine("Da tim thay password cua Username " + chuoiSplit[1]);
                        }
                        gui = Encoding.ASCII.GetBytes(messSend);
                        client.Send(gui, gui.Length, SocketFlags.None);
                        break;
                    /////////////////////////////////////////////End This Case//////////////////////////////////////
                    case "EPA":
                        /////////////////////////////////////////////Start This Case/////////////////////////////////////
                        Console.WriteLine("*****************************************************************************");
                        Console.WriteLine("Server is processing at Exam Prepare Form - Function Add");
                        Console.WriteLine("*****************************************************************************");
                        if (File.Exists(filename2))
                        {
                            string[] dsExam = File.ReadAllLines(filename2);

                            string[] dscodeExam = new string[dsExam.Length];
                            for (int i = 0; i < dsExam.Length; i++)
                            {
                                string[] temp = dsExam[i].Split('|');
                                dscodeExam[i] = temp[1];
                            }

                            foreach (var item in dscodeExam)
                            {
                                if (chuoiSplit[1] == item)
                                {
                                    accecptWrite = false;
                                    break;
                                }
                            }

                            fs = new FileStream(filename2, FileMode.Append, FileAccess.Write, FileShare.Write);
                        }
                        else
                        {
                            fs = new FileStream(filename2, FileMode.Create, FileAccess.Write, FileShare.Write);
                        }

                        if (accecptWrite == true)
                        {
                            StreamWriter sw1 = new StreamWriter(fs, Encoding.UTF8);
                            sw1.WriteLine(chuoiRec);
                            sw1.Flush();
                            Console.WriteLine("Ghi vao file dsExamPrepare.txt thanh cong");
                            messSend = "Ghi Exam Prepare " + chuoiSplit[1] + " vao file dsExamPrepare.txt thanh cong";
                            fs.Close();
                        }
                        else
                        {
                            messSend = "Exam Prepare " + chuoiSplit[1] + "da ton tai." + " Khong the tao";
                        }
                        gui = Encoding.ASCII.GetBytes(messSend);
                        client.Send(gui, gui.Length, SocketFlags.None);
                        break;
                    /////////////////////////////////////////////End This Case//////////////////////////////////////
                    case "EPD":
                        /////////////////////////////////////////////Start This Case/////////////////////////////////////
                        Console.WriteLine("*****************************************************************************");
                        Console.WriteLine("Server is processing at Exam Prepare Form - Function Delete");
                        Console.WriteLine("*****************************************************************************");
                        string[] dsExam1 = File.ReadAllLines(filename2);
                        string itemRemove3 = "";
                        foreach (var item in dsExam1)
                        {
                            string[] temp = item.Split('|');
                            if (temp[1] == chuoiSplit[1])
                            {
                                itemRemove3 = item;
                                break;
                            }
                        }

                        var lines3 = File.ReadAllLines(filename2).Where(l => l.Trim() != itemRemove3).ToArray();
                        Console.WriteLine(lines3+" "+itemRemove3);
                        File.WriteAllLines(filename2, lines3);

                        messSend = "Xoa Exam " + chuoiSplit[1] + " thanh cong";
                        gui = Encoding.ASCII.GetBytes(messSend);
                        client.Send(gui, gui.Length, SocketFlags.None);
                        break;
                    /////////////////////////////////////////////End This Case//////////////////////////////////////
                    case "EPL":
                        /////////////////////////////////////////////Start This Case/////////////////////////////////////
                        Console.WriteLine("*****************************************************************************");
                        Console.WriteLine("Server is processing at Exam Prepare Form - Function Loading");
                        Console.WriteLine("*****************************************************************************");
                        messSend = "";

                        string[] dsExam2 = File.ReadAllLines(filename2);

                        foreach (var item in dsExam2)
                        {
                            messSend += item + "~";
                        }
                       
                        gui = Encoding.ASCII.GetBytes(messSend);
                        client.Send(gui, gui.Length, SocketFlags.None);
                        break;
                    /////////////////////////////////////////////End This Case//////////////////////////////////////
                    case "QS":
                        /////////////////////////////////////////////Start This Case/////////////////////////////////////
                        Console.WriteLine("*****************************************************************************");
                        Console.WriteLine("Server is processing at Question Form - Function Save");
                        Console.WriteLine("*****************************************************************************");
                        if (File.Exists(filename3))
                        {
                            string[] dsQues = File.ReadAllLines(filename3);

                            string[] dscodeQues = new string[dsQues.Length];
                            for (int i = 0; i < dsQues.Length; i++)
                            {
                                string[] temp = dsQues[i].Split('|');
                                dscodeQues[i] = temp[1];
                            }

                            foreach (var item in dscodeQues)
                            {
                                if (chuoiSplit[1] == item)
                                {
                                    accecptWrite = false;
                                    break;
                                }
                            }

                            fs = new FileStream(filename3, FileMode.Append, FileAccess.Write, FileShare.Write);
                        }
                        else
                        {
                            fs = new FileStream(filename3, FileMode.Create, FileAccess.Write, FileShare.Write);
                        }

                        if (accecptWrite == true)
                        {
                            StreamWriter sw1 = new StreamWriter(fs, Encoding.UTF8);
                            sw1.WriteLine(chuoiRec);
                            sw1.Flush();
                            Console.WriteLine("Ghi vao file dsQuestion.txt thanh cong");
                            messSend = "Ghi Question " + chuoiSplit[1] + " vao file dsExamPrepare.dsQuestion.txt thanh cong";
                            fs.Close();
                        }
                        else
                        { 
                            messSend = "Question " + chuoiSplit[1] + " da ton tai." + " Khong the tao";
                        }
                        gui = Encoding.ASCII.GetBytes(messSend);
                        client.Send(gui, gui.Length, SocketFlags.None);
                        break;
                    /////////////////////////////////////////////End This Case//////////////////////////////////////
                    case "QL":
                        /////////////////////////////////////////////Start This Case/////////////////////////////////////
                        Console.WriteLine("*****************************************************************************");
                        Console.WriteLine("Server is processing at Question Form - Function Loading");
                        Console.WriteLine("*****************************************************************************");
                        messSend = "";

                        string[] dsExam3 = File.ReadAllLines(filename3);

                        foreach (var item in dsExam3)
                        {
                            string[] dsQues = item.Split('|');
                            if (dsQues[2]==chuoiSplit[1])
                            {
                                messSend += item + "~";
                            }                            
                            
                        }
                        if (messSend=="")
                        {
                            messSend = "Null";
                        }
                        Console.WriteLine("Mess Send: "+ messSend);

                        gui = Encoding.ASCII.GetBytes(messSend);                        
                        client.Send(gui, gui.Length, SocketFlags.None);                        
                        break;
                    /////////////////////////////////////////////End This Case//////////////////////////////////////
                    case "QD":
                        /////////////////////////////////////////////Start This Case/////////////////////////////////////
                        Console.WriteLine("*****************************************************************************");
                        Console.WriteLine("Server is processing at Exam Prepare Form - Function Delete");
                        Console.WriteLine("*****************************************************************************");
                        string[] dsExam4 = File.ReadAllLines(filename3);
                        string itemRemove4 = "";
                        foreach (var item in dsExam4)
                        {
                            string[] temp = item.Split('|');
                            if (temp[1] == chuoiSplit[1])
                            {
                                itemRemove4 = item;
                                break;
                            }
                        }

                        var lines4 = File.ReadAllLines(filename3).Where(l => l.Trim() != itemRemove4).ToArray();
                        Console.WriteLine(lines4 + " " + itemRemove4);
                        File.WriteAllLines(filename3, lines4);

                        messSend = "Xoa Question " + chuoiSplit[1] + " thanh cong";
                        gui = Encoding.ASCII.GetBytes(messSend);
                        client.Send(gui, gui.Length, SocketFlags.None);
                        break;
                    /////////////////////////////////////////////End This Case//////////////////////////////////////
                    case "EQsL":
                        /////////////////////////////////////////////Start This Case/////////////////////////////////////
                        Console.WriteLine("*****************************************************************************");
                        Console.WriteLine("Server is processing at Exam Ques Form - Function Loading");
                        Console.WriteLine("*****************************************************************************");
                        messSend = "";

                        string[] dsExam5 = File.ReadAllLines(filename2);
                        
                        for (int i = 0; i < dsExam5.Length; i++)
                        {
                            string[] arrEQ = dsExam5[i].Split('|');
                            messSend += arrEQ[1]+"~";
                        }
                        Console.WriteLine("Mess Send: " + messSend);

                        gui = Encoding.ASCII.GetBytes(messSend);
                        client.Send(gui, gui.Length, SocketFlags.None);
                        break;
                    /////////////////////////////////////////////End This Case//////////////////////////////////////
                    case "EQsA":
                        /////////////////////////////////////////////Start This Case/////////////////////////////////////
                        Console.WriteLine("*****************************************************************************");
                        Console.WriteLine("Server is processing at Exam Ques Form - Function Add");
                        Console.WriteLine("*****************************************************************************");
                        if (File.Exists(filename4))
                        {
                            string[] dsExam8 = File.ReadAllLines(filename4);

                            string[] dscodeExamQ = new string[dsExam8.Length];
                            for (int i = 0; i < dsExam8.Length; i++)
                            {
                                string[] temp = dsExam8[i].Split('|');
                                dscodeExamQ[i] = temp[1];
                            }

                            foreach (var item in dscodeExamQ)
                            {
                                if (chuoiSplit[1] == item)
                                {
                                    accecptWrite = false;
                                    break;
                                }
                            }

                            fs = new FileStream(filename4, FileMode.Append, FileAccess.Write, FileShare.Write);
                        }
                        else
                        {
                            fs = new FileStream(filename4, FileMode.Create, FileAccess.Write, FileShare.Write);
                        }

                        if (accecptWrite == true)
                        {
                            StreamWriter sw1 = new StreamWriter(fs, Encoding.UTF8);
                            sw1.WriteLine(chuoiRec);
                            sw1.Flush();
                            Console.WriteLine("Ghi vao file dsExamPrepare.txt thanh cong");
                            messSend = "Ghi Exam Prepare " + chuoiSplit[1] + " vao file dsExamPrepare.txt thanh cong";
                            fs.Close();
                        }
                        else
                        {
                            messSend = "Null";
                        }
                        gui = Encoding.ASCII.GetBytes(messSend);
                        client.Send(gui, gui.Length, SocketFlags.None);
                        break;
                    /////////////////////////////////////////////End This Case//////////////////////////////////////
                    case "EQsL2":
                        /////////////////////////////////////////////Start This Case/////////////////////////////////////
                        Console.WriteLine("*****************************************************************************");
                        Console.WriteLine("Server is processing at Exam Ques Form - Function Load List View");
                        Console.WriteLine("*****************************************************************************");
                        messSend = "";

                        string[] dsExam7 = File.ReadAllLines(filename4);

                        foreach (var item in dsExam7)
                        {
                            messSend += item + "~";
                        }

                        gui = Encoding.ASCII.GetBytes(messSend);
                        client.Send(gui, gui.Length, SocketFlags.None);
                        break;
                    /////////////////////////////////////////////End This Case//////////////////////////////////////
                    case "EQsD":
                        /////////////////////////////////////////////Start This Case/////////////////////////////////////
                        Console.WriteLine("*****************************************************************************");
                        Console.WriteLine("Server is processing at Exam Ques Form - Function Delete");
                        Console.WriteLine("*****************************************************************************");
                        string[] dsExam9 = File.ReadAllLines(filename4);
                        string itemRemove5 = "";
                        foreach (var item in dsExam9)
                        {
                            string[] temp = item.Split('|');
                            if (temp[1] == chuoiSplit[1])
                            {
                                itemRemove5 = item;
                                break;
                            }
                        }

                        var lines5 = File.ReadAllLines(filename4).Where(l => l.Trim() != itemRemove5).ToArray();
                        Console.WriteLine(lines5 + " " + itemRemove5);
                        File.WriteAllLines(filename4, lines5);

                        messSend = "Xoa Exam " + chuoiSplit[1] + " thanh cong";
                        gui = Encoding.ASCII.GetBytes(messSend);
                        client.Send(gui, gui.Length, SocketFlags.None);
                        break;
                    /////////////////////////////////////////////End This Case//////////////////////////////////////
                    case "EQL":
                        /////////////////////////////////////////////Start This Case/////////////////////////////////////
                        Console.WriteLine("*****************************************************************************");
                        Console.WriteLine("Server is processing at Exam Question Form - Function Loading");
                        Console.WriteLine("*****************************************************************************");
                        messSend = "";
                        if (File.Exists(filename3))
                        {
                            string[] dsExam6 = File.ReadAllLines(filename3);

                            foreach (var item in dsExam6)
                            {
                                string[] dsQuestion = item.Split('|');

                                if (dsQuestion[2]==chuoiSplit[1])
                                {
                                    messSend += dsQuestion[1] + "|" + dsQuestion[3] + "~";
                                }                                
                            }                           
                        }
                        else
                        {
                            messSend = "";
                        }
                        if (messSend == "")
                        {
                            messSend = "Null";
                        }
                        Console.WriteLine("Mess Send: "+ messSend);
                        gui = Encoding.ASCII.GetBytes(messSend);
                        client.Send(gui, gui.Length, SocketFlags.None);
                        break;
                    /////////////////////////////////////////////End This Case//////////////////////////////////////
                    case "EQA":
                        /////////////////////////////////////////////Start This Case/////////////////////////////////////
                        Console.WriteLine("*****************************************************************************");
                        Console.WriteLine("Server is processing at Exam Question Form - Function Add");
                        Console.WriteLine("*****************************************************************************");
                        if (File.Exists(filename5))
                        {                      
                            fs = new FileStream(filename5, FileMode.Append, FileAccess.Write, FileShare.Write);
                        }
                        else
                        {
                            fs = new FileStream(filename5, FileMode.Create, FileAccess.Write, FileShare.Write);
                        }

                        StreamWriter sw2 = new StreamWriter(fs, Encoding.UTF8);
                        sw2.WriteLine(chuoiRec);
                        sw2.Flush();
                        Console.WriteLine("Ghi vao file dsExamPrepare.txt thanh cong");
                        messSend = "Ghi Exam Prepare " + chuoiSplit[2] + " vao file dsExamPrepare.txt thanh cong";
                        fs.Close();
                        
                        gui = Encoding.ASCII.GetBytes(messSend);
                        client.Send(gui, gui.Length, SocketFlags.None);
                        break;
                    /////////////////////////////////////////////End This Case//////////////////////////////////////
                    case "EQD":
                        /////////////////////////////////////////////Start This Case/////////////////////////////////////
                        Console.WriteLine("*****************************************************************************");
                        Console.WriteLine("Server is processing at Exam Question Form - Function Delete");
                        Console.WriteLine("*****************************************************************************");
                        string[] dsExam10 = File.ReadAllLines(filename5);
                        string itemRemove6 = "";
                        foreach (var item in dsExam10)
                        {
                            string[] temp = item.Split('|');
                            if (temp[1] == chuoiSplit[1] && temp[2] == chuoiSplit[2])
                            {
                                itemRemove6 = item;
                                break;
                            }
                        }

                        var lines6 = File.ReadAllLines(filename5).Where(l => l.Trim() != itemRemove6).ToArray();
                        Console.WriteLine(lines6 + " " + itemRemove6);
                        File.WriteAllLines(filename5, lines6);

                        messSend = "Xoa Exam " + chuoiSplit[2] + " thanh cong";
                        gui = Encoding.ASCII.GetBytes(messSend);
                        client.Send(gui, gui.Length, SocketFlags.None);
                        break;
                    /////////////////////////////////////////////End This Case//////////////////////////////////////
                    case "PT":
                        /////////////////////////////////////////////Start This Case/////////////////////////////////////
                        Console.WriteLine("*****************************************************************************");
                        Console.WriteLine("Server is processing at Prepare Thi Form - Function Check");
                        Console.WriteLine("*****************************************************************************");
                        string[] dsExam11 = File.ReadAllLines(filename4);
                        messSend = "Null";
                        foreach (var item in dsExam11)
                        {
                            string[] temp = item.Split('|');
                            if (temp[1] == chuoiSplit[1])
                            {
                                messSend = "OK|" + temp[4] + "|" + temp[5] + "|" + temp[6] + "|" + temp[2];
                            }
                        }

                        gui = Encoding.ASCII.GetBytes(messSend);
                        client.Send(gui, gui.Length, SocketFlags.None);
                        break;
                    /////////////////////////////////////////////End This Case//////////////////////////////////////
                    case "TL":
                        /////////////////////////////////////////////Start This Case/////////////////////////////////////
                        Console.WriteLine("*****************************************************************************");
                        Console.WriteLine("Server is processing at Thi Form - Function Loading Question And Answer");
                        Console.WriteLine("*****************************************************************************");
                        string[] dsExam12 = File.ReadAllLines(filename5);
                        messSend = "";
                        foreach (var item in dsExam12)
                        {
                            string[] temp = item.Split('|');
                            if (temp[1] == chuoiSplit[1])
                            {
                                messSend += temp[3]+"~";
                            }
                        }

                        if (messSend == "")
                        {
                            messSend = "Null";
                        }

                        gui = Encoding.ASCII.GetBytes(messSend);
                        client.Send(gui, gui.Length, SocketFlags.None);
                        break;
                    /////////////////////////////////////////////End This Case//////////////////////////////////////
                    case "TS":
                        /////////////////////////////////////////////Start This Case//////////////////////////////////////
                        Console.WriteLine("*****************************************************************************");
                        Console.WriteLine("Server is processing at Thi Form - Function Save");
                        Console.WriteLine("*****************************************************************************");
                        if (File.Exists(filename6))
                        {                          
                            fs = new FileStream(filename6, FileMode.Append, FileAccess.Write, FileShare.Write);
                        }
                        else
                        {
                            fs = new FileStream(filename6, FileMode.Create, FileAccess.Write, FileShare.Write);
                        }
                        StreamWriter sw3 = new StreamWriter(fs, Encoding.UTF8);
                        sw3.WriteLine(chuoiRec);
                        sw3.Flush();
                        Console.WriteLine("Ghi vao file danhsach.txt thanh cong");
                        messSend = "Ghi Account " + chuoiSplit[1] + " vao file dsRegister.txt thanh cong";
                        fs.Close();

                        //gui = Encoding.ASCII.GetBytes(messSend);
                        //client.Send(gui, gui.Length, SocketFlags.None);
                        break;
                    /////////////////////////////////////////////End This Case//////////////////////////////////////
                    case "RSL":
                        /////////////////////////////////////////////Start This Case/////////////////////////////////////
                        Console.WriteLine("*****************************************************************************");
                        Console.WriteLine("Server is processing at Result Form - Function Load List View");
                        Console.WriteLine("*****************************************************************************");
                        messSend = "";

                        string[] dsExam14 = File.ReadAllLines(filename6);

                        foreach (var item in dsExam14)
                        {
                            messSend += item + "~";
                        }

                        if (messSend=="")
                        {
                            messSend = "Null";
                        }

                        gui = Encoding.ASCII.GetBytes(messSend);
                        client.Send(gui, gui.Length, SocketFlags.None);
                        break;
                    /////////////////////////////////////////////End This Case//////////////////////////////////////
                    case "RSS":
                        /////////////////////////////////////////////Start This Case/////////////////////////////////////
                        Console.WriteLine("*****************************************************************************");
                        Console.WriteLine("Server is processing at Result Form - Function Load List View");
                        Console.WriteLine("*****************************************************************************");
                        messSend = "";

                        string keySearch = chuoiSplit[1];
                        string[] dsExam15 = File.ReadAllLines(filename6);

                        foreach (var item in dsExam15)
                        {
                            string[] temp = item.Split('|');
                            foreach (var item2 in temp)
                            {
                                if (item2==keySearch)
                                {
                                    messSend += item + "~";
                                    break;
                                }
                            }
                        }

                        if (messSend == "")
                        {
                            messSend = "Null";
                        }

                        gui = Encoding.ASCII.GetBytes(messSend);
                        client.Send(gui, gui.Length, SocketFlags.None);
                        break;
                    /////////////////////////////////////////////End This Case//////////////////////////////////////
                    default:
                        break;
                }
                
            } while (chuoiRec!="Exit Register");
            Console.ReadKey();
        }
    }
}
