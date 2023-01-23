using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace TelepresenceCommonPacketTool
{
    class SettingPacket
    {
        public string GeneratedPath;
        public string SavePath;
        public string PacketDataName;
        public string LandPacketFrontName;
        public string MySpacePacketFrontName;
        public bool IncludePacketSizeCode;
        public bool PacketNaming;
        public bool InCludeRegion;
        public int OutPutPacketType;
    }

    public class PacketStruct
    {
        public string AbstractName;
        public string LandName;
        public string MySpaceName;
        public string LandPacketOriginalName;
        public string MySpacePacketOriginalName;

        public PacketStruct()
        {
        }

        public PacketStruct(string abstractName, string landName, string mySpaceName)
        {
            AbstractName = abstractName;
            LandName = landName;
            MySpaceName = mySpaceName;
        }
    }

    public partial class Form1 : Form
    {
        private SettingPacket SettingPacket;
        public List<string> PacketNameList = new List<string>();

        public List<PacketStruct> CommonAbstractPacket = new List<PacketStruct>();
        public List<PacketStruct> LandAbstractPacket = new List<PacketStruct>();
        public List<PacketStruct> MySpaceAbstractPacket = new List<PacketStruct>();
        public List<PacketStruct> UtilPacket = new List<PacketStruct>();

        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            InitalizePacketGenerater((b1) =>
            {
                if (b1)
                {
                    progressText.Text = "설정 기본값 설정 완료.";
                    progressBar.Value = 5;
                    PacketNameExtract((b2) =>
                    {
                        if (b2)
                        {
                            progressText.Text = "패킷명 이름 추출 완료.";
                            progressBar.Value = 10;
                            PacketClassNameExtract((b3) =>
                            {
                                progressText.Text = "추상 클래스명 추출 완료";
                                progressBar.Value = 30;
                            });
                        }
                    });
                }
                else
                {
                    MessageBox.Show("잘못된 요청입니다. 다시 시도해 주세요.", "Warning");
                }
            });
        }

        private void GeneratedButton_Click(object sender, EventArgs e) => GeneratedPathText.Text = GetPath();
        private void SaveButton_Click(object sender, EventArgs e) => SavePathText.Text = GetPath();

        #region 설정값 Setting

        public void InitalizePacketGenerater(Action<bool> callBAck)
        {
            PacketNameList = new List<string>();

            this.SettingPacket = new SettingPacket();
            this.SettingPacket.GeneratedPath = GeneratedPathText.Text;
            this.SettingPacket.SavePath = SavePathText.Text;
            this.SettingPacket.PacketDataName = PacketDataName.Text;
            this.SettingPacket.LandPacketFrontName = LandPacketFront.Text;
            this.SettingPacket.MySpacePacketFrontName = MySpacePacketFront.Text;
            this.SettingPacket.IncludePacketSizeCode = includeSizeCode.Checked;
            this.SettingPacket.PacketNaming = Camel.Checked;
            this.SettingPacket.InCludeRegion = inCludeRegion.Checked;

            if (ClientToServer.Checked)
                this.SettingPacket.OutPutPacketType = 1;
            else if (ServerToClient.Checked)
                this.SettingPacket.OutPutPacketType = 2;
            else if (ALLALL.Checked)
                this.SettingPacket.OutPutPacketType = 3;

            if (string.IsNullOrEmpty(SettingPacket.GeneratedPath) || string.IsNullOrEmpty(SettingPacket.SavePath) ||
                string.IsNullOrEmpty(SettingPacket.PacketDataName) ||
                string.IsNullOrEmpty(SettingPacket.LandPacketFrontName) ||
                string.IsNullOrEmpty(SettingPacket.MySpacePacketFrontName) || SettingPacket.OutPutPacketType == 0)
            {
                callBAck?.Invoke(false);
            }
            else
            {
                callBAck?.Invoke(true);
            }
        }

        #endregion

        #region 폴더 경로 읽기

        public string GetPath()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (FolderBrowserDialog openFileDialog = new FolderBrowserDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.SelectedPath;
                    return filePath;
                }
            }

            return string.Empty;
        }

        #endregion

        #region PacketName 추출

        public void PacketNameExtract(Action<bool> callBack)
        {
            string FolderName;
            for (int i = 0; i < 2; i++)
            {
                FolderName = i == 0
                    ? SettingPacket.GeneratedPath + "\\telepresence\\generated"
                    : SettingPacket.GeneratedPath + "\\myspace\\generated";
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(FolderName);

                foreach (System.IO.FileInfo File in di.GetFiles())
                {
                    if (File.Extension.ToLower().CompareTo(".cs") == 0)
                    {
                        String FileNameOnly = File.Name.Substring(0, File.Name.Length - 3);
                        if (!FileNameOnly.Contains("Convertor") &&
                            (FileNameOnly.Contains("S2C") || FileNameOnly.Contains("C2S")))
                        {
                            PacketNameList.Add(FileNameOnly);
                        }
                    }
                }
            }

            if (PacketNameList is null || PacketNameList.Count == 0)
                callBack?.Invoke(false);
            else
                callBack?.Invoke(true);
        }

        #endregion

        #region 패킷 클래스 이름 추출

        public void PacketClassNameExtract(Action<bool> callBack)
        {
            int cnt = 0;
            List<string> newNameList = new List<string>();
            for (int i = 0; i < PacketNameList.Count; i++)
                newNameList.Add(PacketNameList[i]);

            while (newNameList.Count > 0)
            {
                string current = newNameList[0];

                PacketStruct packet = new PacketStruct();
                string packetname = PacketNameToclassName(current);
                packet.AbstractName = $"{packetname}";
                packet.LandName = $"{SettingPacket.LandPacketFrontName}{packetname}";
                packet.MySpaceName = $"{SettingPacket.MySpacePacketFrontName}{packetname}";

                if (current.Contains("ROOM"))
                {
                    packet.LandPacketOriginalName = current;
                    string replaceString = current.Replace("ROOM", "MYSPACE");
                    if (FindList(newNameList, replaceString))
                    {
                        packet.MySpacePacketOriginalName = current;
                        CommonAbstractPacket.Add(packet);
                        newNameList.Remove(current);
                        newNameList.Remove(replaceString);
                    }
                    else
                    {
                        LandAbstractPacket.Add(packet);
                        newNameList.Remove(current);
                    }
                }
                else if (current.Contains("MYSPACE"))
                {
                    packet.MySpacePacketOriginalName = current;
                    string replaceString = current.Replace("MYSPACE", "ROOM");
                    if (FindList(newNameList, replaceString))
                    {
                        packet.LandPacketOriginalName = current;
                        CommonAbstractPacket.Add(packet);
                        newNameList.Remove(current);
                        newNameList.Remove(replaceString);
                    }
                    else
                    {
                        MySpaceAbstractPacket.Add(packet);
                        newNameList.Remove(current);
                    }
                }
                else
                {
                    if (FindListCount(newNameList, current) > 1)
                    {
                        CommonAbstractPacket.Add(packet);
                        newNameList.Remove(current);
                    }
                    else
                    {
                        UtilPacket.Add(packet);
                        newNameList.Remove(current);
                    }
                }

                cnt++;
                progressText.Text = $"({cnt}/{PacketNameList.Count}) - {current}";
            }

            callBack?.Invoke(true);
        }

        #endregion

        #region 패킷 공통/개별 필드 추출

        public void PacketFieldExtract()
        {
            StreamReader Landsr,Myspacesr;
            for (int i = 0; i < CommonAbstractPacket.Count; i++)
            {
                sr = new StreamReader(SettingPacket.GeneratedPath + $"\\telepresence\\generated\\{CommonAbstractPacket[i].LandPacketOriginalName}");
                sr = new StreamReader(SettingPacket.GeneratedPath + $"\\telepresence\\generated\\{CommonAbstractPacket[i].LandPacketOriginalName}");
            }
        }
        
        #endregion

        #region 유틸메서드

        public bool FindList(List<string> list, string data)
        {
            if (list == null) return false;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Contains(data)) return true;
            }

            return false;
        }

        public int FindListCount(List<string> list, string data)
        {
            if (list == null) return 0;

            int cnt = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Contains(data)) cnt++;
            }

            return cnt;

            return 0;
        }

        public string PacketNameToclassName(string s)
        {
            string cut = string.Empty;
            if (s.Contains("MYSPACE")) cut = s.Substring(12);
            else if (s.Contains("ROOM")) cut = s.Substring(9);
            else if (s.Contains("ROOM_DEV")) cut = s.Substring(13);
            else cut = s.Substring(4);
            cut = cut.ToLower();

            string[] cutarr = cut.Split('_');
            string newcut = string.Empty;

            for (int i = 0; i < cutarr.Length; i++)
                newcut += cutarr[i];
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            if (SettingPacket.PacketNaming)
            {
                return ti.ToTitleCase(newcut);
            }
            else
            {
                char.ToUpper(newcut[0]);
                return newcut;
            }
        }

        #endregion
    }
}