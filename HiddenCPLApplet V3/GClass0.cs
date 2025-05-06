#define DEBUG
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace HiddenCPLApplet
{
	public class GClass0
	{
		[CompilerGenerated]
		private sealed class VB_0024StateMachine_1_FadeInMain : IAsyncStateMachine
		{
			public int _0024State;

			public AsyncVoidMethodBuilder _0024Builder;

			internal Form _0024VB_0024Local_o;

			internal int _0024VB_0024Local_interval;

			internal Form _0024S0;

			internal Exception _0024VB_0024ResumableLocal_ex_00241;

			internal TaskAwaiter _0024A0;

			[CompilerGenerated]
			internal void MoveNext()
			{
				int num = _0024State;
				try
				{
					if ((uint)num <= 1u)
					{
					}
					try
					{
						if (num != 0)
						{
							if (num != 1)
							{
								goto IL_0040;
							}
							num = -1;
							_0024State = -1;
							return;
						}
						num = -1;
						_0024State = -1;
						TaskAwaiter awaiter = _0024A0;
						_0024A0 = default(TaskAwaiter);
						goto IL_0072;
						IL_0040:
						if (_0024VB_0024Local_o.Opacity < 1.0)
						{
							awaiter = Task.Delay(_0024VB_0024Local_interval).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								_0024State = 0;
								_0024A0 = awaiter;
								ref AsyncVoidMethodBuilder reference = ref _0024Builder;
								VB_0024StateMachine_1_FadeInMain stateMachine = this;
								reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
								return;
							}
							goto IL_0072;
						}
						_0024VB_0024Local_o.Opacity = 1.0;
						Form1.bool_0 = true;
						goto end_IL_000b;
						IL_0072:
						awaiter.GetResult();
						awaiter = default(TaskAwaiter);
						(_0024S0 = _0024VB_0024Local_o).Opacity = _0024S0.Opacity + 0.05;
						goto IL_0040;
						end_IL_000b:;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						_0024VB_0024ResumableLocal_ex_00241 = ex2;
						Debug.WriteLine(_0024VB_0024ResumableLocal_ex_00241.Message);
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception exception = ex3;
					_0024State = -2;
					_0024Builder.SetException(exception);
					ProjectData.ClearProjectError();
					return;
				}
				num = -2;
				_0024State = -2;
				_0024Builder.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerNonUserCode]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[CompilerGenerated]
		private sealed class VB_0024StateMachine_2_FadeIn : IAsyncStateMachine
		{
			public int _0024State;

			public AsyncVoidMethodBuilder _0024Builder;

			internal Form _0024VB_0024Local_o;

			internal int _0024VB_0024Local_interval;

			internal Form _0024S0;

			internal Exception _0024VB_0024ResumableLocal_ex_00241;

			internal TaskAwaiter _0024A0;

			[CompilerGenerated]
			internal void MoveNext()
			{
				int num = _0024State;
				try
				{
					if ((uint)num <= 1u)
					{
					}
					try
					{
						if (num != 0)
						{
							if (num != 1)
							{
								goto IL_0040;
							}
							num = -1;
							_0024State = -1;
							return;
						}
						num = -1;
						_0024State = -1;
						TaskAwaiter awaiter = _0024A0;
						_0024A0 = default(TaskAwaiter);
						goto IL_0072;
						IL_0040:
						if (_0024VB_0024Local_o.Opacity < 1.0)
						{
							awaiter = Task.Delay(_0024VB_0024Local_interval).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								_0024State = 0;
								_0024A0 = awaiter;
								ref AsyncVoidMethodBuilder reference = ref _0024Builder;
								VB_0024StateMachine_2_FadeIn stateMachine = this;
								reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
								return;
							}
							goto IL_0072;
						}
						_0024VB_0024Local_o.Opacity = 1.0;
						goto end_IL_000b;
						IL_0072:
						awaiter.GetResult();
						awaiter = default(TaskAwaiter);
						(_0024S0 = _0024VB_0024Local_o).Opacity = _0024S0.Opacity + 0.05;
						goto IL_0040;
						end_IL_000b:;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						_0024VB_0024ResumableLocal_ex_00241 = ex2;
						Debug.WriteLine(_0024VB_0024ResumableLocal_ex_00241.Message);
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception exception = ex3;
					_0024State = -2;
					_0024Builder.SetException(exception);
					ProjectData.ClearProjectError();
					return;
				}
				num = -2;
				_0024State = -2;
				_0024Builder.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerNonUserCode]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[AsyncStateMachine(typeof(VB_0024StateMachine_1_FadeInMain))]
		[DebuggerStepThrough]
		public static void smethod_0(Form o, int interval = 80)
		{
			VB_0024StateMachine_1_FadeInMain stateMachine = new VB_0024StateMachine_1_FadeInMain();
			stateMachine._0024VB_0024Local_o = o;
			stateMachine._0024VB_0024Local_interval = interval;
			stateMachine._0024State = -1;
			stateMachine._0024Builder = AsyncVoidMethodBuilder.Create();
			stateMachine._0024Builder.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(VB_0024StateMachine_2_FadeIn))]
		[DebuggerStepThrough]
		public static void smethod_1(Form o, int interval = 80)
		{
			VB_0024StateMachine_2_FadeIn stateMachine = new VB_0024StateMachine_2_FadeIn();
			stateMachine._0024VB_0024Local_o = o;
			stateMachine._0024VB_0024Local_interval = interval;
			stateMachine._0024State = -1;
			stateMachine._0024Builder = AsyncVoidMethodBuilder.Create();
			stateMachine._0024Builder.Start(ref stateMachine);
		}

		public static object smethod_2(string Code)
		{
			checked
			{
				object result = default(object);
				try
				{
					string[] array = Code.Split('"');
					int num = array.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						string text = array[i];
						if (!string.IsNullOrWhiteSpace(text) && !Code.Contains("\"" + text + "\"c") && !Code.Contains("<DllExport(\"" + text + "\"") && !Code.Contains("<DllImport(\"" + text + "\"") && (Code.Contains("= \"" + text + "\"") | Code.Contains("+ \"" + text + "\"") | Code.Contains("& \"" + text + "\"") | Code.Contains("(\"" + text + "\"") | Code.Contains(", \"" + text + "\"")))
						{
							Code = Code.Replace("\"" + text + "\"", Conversions.ToString(smethod_3(text)));
						}
					}
					result = Code;
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
		}

		public static object smethod_3(string x)
		{
			string text = "";
			int length = x.Length;
			int num = 1;
			while (true)
			{
				int num2 = num;
				int num3 = length;
				if (num2 > num3)
				{
					break;
				}
				text = ((num == x.Length) ? (text + "Chr(\"" + Convert.ToString(Strings.Asc(Strings.Mid(x, num, 1))) + "\")") : (text + "Chr(\"" + Convert.ToString(Strings.Asc(Strings.Mid(x, num, 1))) + "\") + "));
				num = checked(num + 1);
			}
			return text;
		}

		public static string smethod_4(long byteCount)
		{
			string[] array = new string[7] { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
			if (byteCount != 0L)
			{
				long num = Math.Abs(byteCount);
				int num2 = Convert.ToInt32(Math.Floor(Math.Log(num, 1024.0)));
				double num3 = Math.Round((double)num / Math.Pow(1024.0, num2), 1);
				return (double)Math.Sign(byteCount) * num3 + array[num2];
			}
			return "0" + array[0];
		}

		public static string smethod_5()
		{
			return "\"";
		}

		public static string smethod_6()
		{
			return "\"c";
		}

		public static string smethod_7()
		{
			return "<DllExport(\"";
		}

		public static string smethod_8()
		{
			return "\"";
		}

		public static string smethod_9()
		{
			return "<DllImport(\"";
		}

		public static string smethod_10()
		{
			return "\"";
		}

		public static string smethod_11()
		{
			return "= \"";
		}

		public static string smethod_12()
		{
			return "\"";
		}

		public static string smethod_13()
		{
			return "+ \"";
		}

		public static string smethod_14()
		{
			return "\"";
		}

		public static string smethod_15()
		{
			return "& \"";
		}

		public static string smethod_16()
		{
			return "\"";
		}

		public static string smethod_17()
		{
			return "(\"";
		}

		public static string smethod_18()
		{
			return "\"";
		}

		public static string smethod_19()
		{
			return ", \"";
		}

		public static string smethod_20()
		{
			return "\"";
		}

		public static string smethod_21()
		{
			return "\"";
		}

		public static string smethod_22()
		{
			return "\"";
		}

		public static string smethod_23()
		{
			return "";
		}

		public static string smethod_24()
		{
			return "Chr(\"";
		}

		public static string smethod_25()
		{
			return "\")";
		}

		public static string smethod_26()
		{
			return "Chr(\"";
		}

		public static string smethod_27()
		{
			return "\") + ";
		}

		public static string smethod_28()
		{
			return "B";
		}

		public static string smethod_29()
		{
			return "KB";
		}

		public static string smethod_30()
		{
			return "MB";
		}

		public static string smethod_31()
		{
			return "GB";
		}

		public static string smethod_32()
		{
			return "TB";
		}

		public static string smethod_33()
		{
			return "PB";
		}

		public static string smethod_34()
		{
			return "EB";
		}

		public static string smethod_35()
		{
			return "0";
		}
	}
}
