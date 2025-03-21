using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AqLAVISA_Sample
{
	public partial class Form1 : Form
	{
		AqLAVISAClass cAqLAVISA;
		const int APP_TYPE_TL = 0; //DLL default
		const int APP_TYPE_BF_LA3K = 1;
		const int APP_TYPE_TB = 2;
		const int APP_TYPE_MS = 3;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cAqLAVISA = new AqLAVISAClass();
			raAppBF_LA3K.Checked = true; //Default using BF/LA3K
		}

		private void bnConnect_Click(object sender, EventArgs e)
		{
			int iAppType = APP_TYPE_TL;
			if (raAppTL.Checked == true)
				iAppType = APP_TYPE_TL;
			else if (raAppBF_LA3K.Checked == true)
				iAppType = APP_TYPE_BF_LA3K;
			else if (raAppTB.Checked == true)
				iAppType = APP_TYPE_TB;
			else if (raAppMSO.Checked == true)
				iAppType = APP_TYPE_MS;
			if (cAqLAVISA.viSelectAppType(iAppType))
			{
				ltResult.Items.Add("viSelectAppType..." + iAppType + " (OK)");
			}
			else
			{
				ltResult.Items.Add("viSelectAppType..." + iAppType + " (Failed)");
				ShowErrorCode();
				return;
			}

			if (cAqLAVISA.viOpenRM())
			{
				ltResult.Items.Add("viOpenRM..." + " (OK)");
			}
			else
			{
				ltResult.Items.Add("viOpenRM..." + " (Failed)");
				ShowErrorCode();
			}
		}

		private void bnDisconnect_Click(object sender, EventArgs e)
		{
			if (cAqLAVISA.viCloseRM())
			{
				ltResult.Items.Add("viCloseRM..." + " (OK)");
			}
			else
			{
				ltResult.Items.Add("viCloseRM..." + " (Failed)");
				ShowErrorCode();
			}
		}

		private void ShowErrorCode()
		{
			int iErrorCode = cAqLAVISA.viErrCode();
			ltResult.Items.Add("viErrCode..." + iErrorCode);
		}

		private void bnSend_Click(object sender, EventArgs e)
		{
			string strCmd = edCmd.Text;
			int iCmdWaitTimeout_ms = 2000; //2s timeout
			bool fGetReadData = false;
			switch (cAqLAVISA.viWrite(strCmd, iCmdWaitTimeout_ms))
			{				
				case AqLAVISAClass.PROC_OK_WOUT_RETURN:
					ltResult.Items.Add("viWrite..." + " (OK, No Return)");
					break;
				case AqLAVISAClass.PROC_OK_WITH_RETURN:
					ltResult.Items.Add("viWrite..." + " (OK, With Return)");
					fGetReadData = true;
					break;
				case AqLAVISAClass.PROC_FAIL:
					ltResult.Items.Add("viWrite..." + " (Fail)");
					ShowErrorCode();
					break;
				case AqLAVISAClass.PROC_PENDING:
					ltResult.Items.Add("viWrite..." + " (Pending, Timed out)");
					break;
			}

			if (fGetReadData)
			{
				string strRet = cAqLAVISA.viRead();
				ltResult.Items.Add("viRead..." + strRet);
			}
		}

		private void ltCmdSample_DoubleClick(object sender, EventArgs e)
		{
			string strCurrent = ltCmdSample.SelectedItem.ToString();
			edCmd.Text = strCurrent;
		}



	}
}
