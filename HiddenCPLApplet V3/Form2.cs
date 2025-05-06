#define DEBUG
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using HiddenCPLApplet.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;


namespace HiddenCPLApplet_V3
{
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                Guna2TextBox2.Text = Conversions.ToString(smethod_0());
                Guna2TextBox1.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\HiddenCPLApplet", "License", null));
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Debug.WriteLine(ex.Message);
                ProjectData.ClearProjectError();
            }
        }

        public static object smethod_0()
        {
            object result;
            try
            {
                result = Operators.ConcatenateObject(Operators.ConcatenateObject(smethod_1(), "_"), smethod_2());
            }
            catch (Exception projectError)
            {
                ProjectData.SetProjectError(projectError);
                result = "Error";
                ProjectData.ClearProjectError();
            }
            return result;
        }

        public static object smethod_1()
        {
            object result;
            try
            {
                result = Environment.UserName;
            }
            catch (Exception projectError)
            {
                ProjectData.SetProjectError(projectError);
                result = "Error";
                ProjectData.ClearProjectError();
            }
            return result;
        }

        private static string smethod_2()
        {
            string result;
            try
            {
                string text = smethod_3("Win32_Processor", "ProcessorId");
                text = text + "-" + smethod_3("Win32_BIOS", "SerialNumber");
                text = text + "-" + smethod_3("Win32_BaseBoard", "SerialNumber");
                text = text + "-" + smethod_3("Win32_VideoController", "Name");
                text = text + "-" + smethod_3("Win32_Processor", "Manufacturer");
                text = text + "-" + smethod_3("Win32_BIOS", "SMBIOSBIOSVersion");
                text = text + "-" + Conversions.ToString(new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory)).TotalSize);
                text = text + "-" + Environment.MachineName;
                result = smethod_4(text);
            }
            catch (Exception projectError)
            {
                ProjectData.SetProjectError(projectError);
                result = "Error";
                ProjectData.ClearProjectError();
            }
            return result;
        }

        private static string smethod_3(string wmiClass, string wmiProperty)
        {
            string result;
            try
            {
                string text = "";
                ManagementObjectCollection instances = new ManagementClass(wmiClass).GetInstances();
                foreach (ManagementObject item in instances)
                {
                    if (Operators.CompareString(text, "", TextCompare: false) == 0)
                    {
                        try
                        {
                            text = item[wmiProperty].ToString();
                        }
                        catch (Exception projectError)
                        {
                            ProjectData.SetProjectError(projectError);
                            ProjectData.ClearProjectError();
                            continue;
                        }
                        break;
                    }
                }
                result = text;
            }
            catch (Exception projectError2)
            {
                ProjectData.SetProjectError(projectError2);
                result = "Error";
                ProjectData.ClearProjectError();
            }
            return result;
        }

        public static string smethod_4(string input)
        {
            checked
            {
                string result;
                try
                {
                    byte[] array = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(input));
                    StringBuilder stringBuilder = new StringBuilder();
                    int num = array.Length - 1;
                    for (int i = 10; i <= num; i++)
                    {
                        stringBuilder.Append(array[i].ToString("x3"));
                    }
                    result = stringBuilder.ToString().ToUpper();
                }
                catch (Exception projectError)
                {
                    ProjectData.SetProjectError(projectError);
                    result = "Error";
                    ProjectData.ClearProjectError();
                }
                return result;
            }
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\HiddenCPLApplet", "License", Guna2TextBox1.Text);
            Hide();
            MyProject.Forms.Form1.Show();
        }

        public static string smethod_5(string Input, string Part0 = "BoHzG2ak89Wd7Epq")
        {
            StringBuilder stringBuilder = new StringBuilder();
            string text = smethod_6("b8y8uzT1EDpMWSc+Irt9Yv8c052DxoWZ", Part0);
            checked
            {
                int num = Input.Length - 1;
                int num2 = default(int);
                for (int i = 0; i <= num; i += 2)
                {
                    string value = Conversions.ToString(Strings.Chr((int)(Conversions.ToLong("&H" + Input.Substring(i, 2)) ^ Strings.Asc(text[num2]))));
                    stringBuilder.Append(value);
                    num2 = ((num2 != text.Length - 1) ? (num2 + 1) : 0);
                }
                return stringBuilder.ToString();
            }
        }

        public static string smethod_6(string HIDDEN1, string HIDDEN8)
        {
            RC2CryptoServiceProvider rC2CryptoServiceProvider = new RC2CryptoServiceProvider();
            MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
            string text = "XMethod";
            byte[] key = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(text + HIDDEN8));
            rC2CryptoServiceProvider.Key = key;
            rC2CryptoServiceProvider.Mode = CipherMode.ECB;
            ICryptoTransform cryptoTransform = rC2CryptoServiceProvider.CreateDecryptor();
            byte[] array = Convert.FromBase64String(HIDDEN1);
            return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
        }

        public static void smethod_7()
        {
            try
            {
                MessageBox.Show("Contact Us :" + Environment.NewLine + Environment.NewLine + "Telegram : @XCoderTools", "Error >> Wrong Bin!");
                Process.Start("https://t.me/XCoderTools");
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Debug.WriteLine(ex.Message);
                ProjectData.ClearProjectError();
            }
        }

        private void Guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void Guna2TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                Guna2Button1.PerformClick();
            }
        }

        private void Guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                Guna2Button1.PerformClick();
            }
        }

        public static string smethod_8()
        {
            return "$this.Icon";
        }

        public static string smethod_9()
        {
            return "";
        }

        public static string smethod_10()
        {
            return "Label1";
        }

        public static string smethod_11()
        {
            return "Form2";
        }

        public static string smethod_12()
        {
            return "Guna2TextBox1";
        }

        public static string smethod_13()
        {
            return "";
        }

        public static string smethod_14()
        {
            return "Segoe UI";
        }

        public static string smethod_15()
        {
            return "Guna2Button1.Image";
        }

        public static string smethod_16()
        {
            return "PictureBox1.Image";
        }

        public static string smethod_17()
        {
            return "PictureBox1";
        }

        public static string smethod_18()
        {
            return "Guna2Button1";
        }

        public static string smethod_19()
        {
            return "Start";
        }

        public static string smethod_20()
        {
            return "Label16";
        }

        public static string smethod_21()
        {
            return "ID :";
        }

        public static string smethod_22()
        {
            return "";
        }

        public static string smethod_23()
        {
            return "Guna2ControlBox1";
        }

        public static string smethod_24()
        {
            return "Segoe UI";
        }

        public static string smethod_25()
        {
            return "Guna2TextBox2";
        }

        public static string smethod_26()
        {
            return "";
        }

        public static string smethod_27()
        {
            return "";
        }

        public static string smethod_28()
        {
            return "Bin :";
        }

        public static string smethod_29()
        {
            return "";
        }

        public static string smethod_30()
        {
            return "Segoe UI";
        }

        public static string smethod_31()
        {
            return "Tahoma";
        }

        public static string smethod_32()
        {
            return "Label6";
        }

        public static string smethod_33()
        {
            return "Hidden CPLApplet V3 | License";
        }

        public static string smethod_34()
        {
            return "CPLApplet Builder V3 | License";
        }

        public static string smethod_35()
        {
            return "Guna2Panel1";
        }

        public static string smethod_36()
        {
            return "HKEY_CURRENT_USER\\SOFTWARE\\HiddenCPLApplet";
        }

        public static string smethod_37()
        {
            return "License";
        }

        public static string smethod_38()
        {
            return "_";
        }

        public static string smethod_39()
        {
            return "Error";
        }

        public static string smethod_40()
        {
            return "Error";
        }

        public static string smethod_41()
        {
            return "Win32_Processor";
        }

        public static string smethod_42()
        {
            return "ProcessorId";
        }

        public static string smethod_43()
        {
            return "-";
        }

        public static string smethod_44()
        {
            return "Win32_BIOS";
        }

        public static string smethod_45()
        {
            return "SerialNumber";
        }

        public static string smethod_46()
        {
            return "-";
        }

        public static string smethod_47()
        {
            return "Win32_BaseBoard";
        }

        public static string smethod_48()
        {
            return "SerialNumber";
        }

        public static string smethod_49()
        {
            return "-";
        }

        public static string smethod_50()
        {
            return "Win32_VideoController";
        }

        public static string smethod_51()
        {
            return "Name";
        }

        public static string smethod_52()
        {
            return "-";
        }

        public static string smethod_53()
        {
            return "Win32_Processor";
        }

        public static string smethod_54()
        {
            return "Manufacturer";
        }

        public static string smethod_55()
        {
            return "-";
        }

        public static string smethod_56()
        {
            return "Win32_BIOS";
        }

        public static string smethod_57()
        {
            return "SMBIOSBIOSVersion";
        }

        public static string smethod_58()
        {
            return "-";
        }

        public static string smethod_59()
        {
            return "-";
        }

        public static string smethod_60()
        {
            return "Error";
        }

        public static string smethod_61()
        {
            return "";
        }

        public static string smethod_62()
        {
            return "";
        }

        public static string smethod_63()
        {
            return "Error";
        }

        public static string smethod_64()
        {
            return "x3";
        }

        public static string smethod_65()
        {
            return "Error";
        }

        public static string smethod_66()
        {
            return "BoHzG2ak89Wd7Epq";
        }

        public static string smethod_67()
        {
            return "HKEY_CURRENT_USER\\SOFTWARE\\HiddenCPLApplet";
        }

        public static string smethod_68()
        {
            return "License";
        }

        public static string smethod_69()
        {
            return "b8y8uzT1EDpMWSc+Irt9Yv8c052DxoWZ";
        }

        public static string smethod_70()
        {
            return "&H";
        }

        public static string smethod_71()
        {
            return "";
        }

        public static string smethod_72()
        {
            return "XMethod";
        }

        public static string smethod_73()
        {
            return "Contact Us :";
        }

        public static string smethod_74()
        {
            return "Telegram : @XCoderTools";
        }

        public static string smethod_75()
        {
            return "Error >> Wrong Bin!";
        }

        public static string smethod_76()
        {
            return "https://t.me/XCoderTools";
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void Guna2Button3_Click(object sender, EventArgs e)
        {
            MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\HiddenCPLApplet", "License", Guna2TextBox1.Text);
            Hide();
            MyProject.Forms.Form1.Show();
        }
    }
}
