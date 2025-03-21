using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace AqLAVISA_Sample
{
	class AqLAVISAClass
	{
		const string strAqLAVISA = "AqVISA64.dll";
		const int iCmdResultQueryWait = 100; //100ms

		//AqLAVISA Get Command Result
			public const int PROC_OK_WOUT_RETURN = 0;
			public const int PROC_OK_WITH_RETURN = 1;
			public const int PROC_FAIL = 2;
			public const int PROC_PENDING = 3;

		[DllImport(strAqLAVISA, EntryPoint = "viSelectAppType", CallingConvention = CallingConvention.StdCall)]
		private static extern bool _viSelectAppType(int iAppType);
		public bool viSelectAppType(int iAppType)
		{
			return _viSelectAppType(iAppType);
		}

		[DllImport(strAqLAVISA, EntryPoint = "viOpenRM", CallingConvention = CallingConvention.StdCall)]
		private static extern bool _viOpenRM();
		public bool viOpenRM()
		{
			return _viOpenRM();
		}

		[DllImport(strAqLAVISA, EntryPoint = "viWrite", CallingConvention = CallingConvention.StdCall)]
		private static extern bool _viWrite(byte[] szCmd);
		public int viWrite(string strCmd, int iWaitTimeout_ms)
		{			
			bool fWriteOK = _viWrite(System.Text.Encoding.UTF8.GetBytes(strCmd));
			if (fWriteOK == false)
				return PROC_FAIL;
			int iCmdResult = PROC_PENDING;
			int iWaitLoopCnt = iWaitTimeout_ms / iCmdResultQueryWait;
			while (iCmdResult == PROC_PENDING)
			{
				iCmdResult = _viGetCommandResult();
				if (iWaitLoopCnt == 0)
					break;
				iWaitLoopCnt--;
				System.Threading.Thread.Sleep(iCmdResultQueryWait);
			}
			return iCmdResult;
		}

		[DllImport(strAqLAVISA, EntryPoint = "viRead", CallingConvention = CallingConvention.StdCall)]
		private static extern int _viRead(byte[] szRet, int iBufLen);
		public string viRead()
		{			
			int iBufLen = 128;
			byte[] bBuffer = new byte[iBufLen];
			int iReadSize = _viRead(bBuffer, iBufLen);
			if (iReadSize == 0)
				return null;
			string strRet = System.Text.Encoding.UTF8.GetString(bBuffer);
			strRet = strRet.Substring(0, iReadSize);
			return strRet;
		}

		[DllImport(strAqLAVISA, EntryPoint = "viCloseRM", CallingConvention = CallingConvention.StdCall)]
		private static extern bool _viCloseRM();
		public bool viCloseRM()
		{
			return _viCloseRM();
		}

		[DllImport(strAqLAVISA, EntryPoint = "viErrCode", CallingConvention = CallingConvention.StdCall)]
		private static extern int _viErrCode();
		public int viErrCode()
		{
			return _viErrCode();
		}

		[DllImport(strAqLAVISA, EntryPoint = "viGetCommandResult", CallingConvention = CallingConvention.StdCall)]
		private static extern int _viGetCommandResult();
		public int viGetCommandResult()
		{
			return _viGetCommandResult();
		}
	}
}
