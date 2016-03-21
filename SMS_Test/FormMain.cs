using SMS_Test.RemoteWebService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Test
{
    /// <summary>
    /// 模块：发送短信
    /// 作者：Anything
    /// 日期：2016-03-21
    /// 维护记录：
    /// 说明：Winform测试短信服务Demo，后续将应用于调度任务定时读取数据库短信表新增数据，传给WebService接口，实现实时批量发送短信功能。
    /// </summary>
    public partial class FormMain : Form
    {
        #region 变量

        private string _account = "***";//账号，此处已被隐藏，请询问山东电信客服获取
        private string _pwd = "***";//密码，此处应填写md5加密后的密码
        private string br = Environment.NewLine;//换行符 

        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 发送按钮
        /// </summary>
        private void btnSend_Click(object sender, EventArgs e)
        {
            mtMessage ms = new mtMessage();

            /* 是否发送到多人 */
            if (txtNumber.Text.Contains(','))
            {
                ms.phoneNumber = txtNumber.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            }
            else
            {
                ms.phoneNumber = new string[] { txtNumber.Text };
            }

            /* 是否定时发送 */
            if (checkBoxTiming.Checked)
            {
                ms.sendTime = dtp.Value;
            }

            ms.content = txtContent.Text;

            /* 是否追加时间 */
            if (checkBoxAddTimeSpan.Checked)
            {
                ms.content += DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff");
            }

            /* 执行发送 */
            SmsOperatorClient soc = new SmsOperatorClient();
            mtMessageRes res = soc.sendSms(_account, _pwd, "", ms);//todo:后续需从数据库读取数据，循环此方法实现批量发送。

            /* 写记录 */
            WriteSendLog(res);
        }

        /// <summary>
        /// 接收报告
        /// </summary>
        private void btnGetReport_Click(object sender, EventArgs e)
        {
            /* 执行接收 */
            SmsOperatorClient soc = new SmsOperatorClient();
            reportMessageRes res = soc.getReport(_account, _pwd);

            /* 写记录 */
            WriteReportLog(res);
        }

        /// <summary>
        /// 查询余额
        /// </summary>
        private void btnGetBalance_Click(object sender, EventArgs e)
        {
            /* 查询余额 */
            SmsOperatorClient soc = new SmsOperatorClient();
            balanceRes res = soc.getBalance(_account, _pwd);

            /* 写记录 */
            WriteBalanceLog(res);
        }

        /// <summary>
        /// 登记发送记录
        /// </summary>
        /// <param name="res">传入参数</param>
        private void WriteSendLog(mtMessageRes res)
        {
            string smsId = res.smsId;
            string subStat = res.subStat;
            string subStatDes = res.subStatDes;
            List<string> ms = new List<string>();
            if (res.resDetail == null)
            {
                ms.Add("\t--  res.SubStatDes == null");
            }
            else
            {
                foreach (mtMessageResDetail m in res.resDetail)
                {
                    ms.Add(string.Format("【phoneNumber】:{0}|【stat】:{1}|【statDes】:{2}|【ToString()】:{3}", m.phoneNumber, m.stat, m.statDes, m.ToString()));
                }
            }

            txtResult.Text += "【发送】--------------【" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff") + "】---------------" + br + "【smsId】:" + smsId + br + "【subStat】:" + subStat + br + "【subStatDes】:" + subStatDes + br;
            foreach (string str in ms)
            {
                txtResult.AppendText(str + br);
            }

            /* 文本框光标滚动到底端 */
            txtResult.ScrollToCaret();
        }

        /// <summary>
        /// 登记接收报告
        /// </summary>
        /// <param name="res">传入参数</param>
        private void WriteReportLog(reportMessageRes res)
        {
            string subStat = res.subStat;
            string subStatDes = res.subStatDes;
            List<string> rs = new List<string>();

            if (res.resDetail == null)
            {
                rs.Add("\t--  res.resDetail == null");
            }
            else
            {
                foreach (reportMessageResDetail r in res.resDetail)
                {
                    rs.Add(string.Format("【smsId】:{0}|【phoneNumber】:{1}|【stat】:{2}|【statDes】:{3}|【ToString()】:{4}", r.smsId, r.phoneNumber, r.stat, r.statDes, r.ToString()));
                }
            }

            txtResult.Text += "【接收报告】--------------【" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff") + "】---------------" + br + "【subStat】:" + subStat + br + "【subStatDes】:" + subStatDes + br;
            foreach (string str in rs)
            {
                txtResult.AppendText(str + br);
            }

            /* 文本框光标滚动到底端 */
            txtResult.ScrollToCaret();
        }

        /// <summary>
        /// 登记余额查询信息
        /// </summary>
        /// <param name="res">传入参数</param>
        private void WriteBalanceLog(balanceRes res)
        {
            string revStat = res.revStat;
            string revStatDes = res.revStatDes;
            string demo = res.demo;
            txtResult.AppendText("【余额】--------------【" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff") + "】---------------" + br + "【revStat】:" + revStat + br + "【revStatDes】:" + revStatDes + br + "【demo】:" + demo + br);

            /* 文本框光标滚动到底端 */
            txtResult.ScrollToCaret();
        }
    }
}