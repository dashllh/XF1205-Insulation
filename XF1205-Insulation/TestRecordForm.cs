using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraSpreadsheet.Model;
using System.Text.Json;
using XF1205_Insulation.Model;

namespace XF1205_Insulation
{
    public partial class TestRecordForm : Form
    {
        public TestRecordForm()
        {
            InitializeComponent();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (txtSampleId.Text == string.Empty)
            {
                MessageBox.Show("样品编号不能为空。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSampleId.Focus();
                return;
            }

            if (txtTestId.Text == string.Empty)
            {
                MessageBox.Show("样品标识号不能为空。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTestId.Focus();
                return;
            }
            /* 创建本地存储目录 */
            string prodpath = $"D:\\XF 1205-2014 Insulation\\{txtSampleId.Text}";
            string smppath = $"{prodpath}\\{txtTestId.Text}";
            string datapath = $"{smppath}\\data";
            string rptpath = $"{smppath}\\report";

            try
            {
                /* 创建本次试验结果文件的存储目录 */
                //试验样品根目录
                Directory.CreateDirectory(prodpath);
                //本次试验根目录
                Directory.CreateDirectory(smppath);
                //本次试验原始数据目录
                Directory.CreateDirectory(datapath);
                //本次试验报表目录
                Directory.CreateDirectory(rptpath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }

            using (var wordProcessor = new RichEditDocumentServer())
            {
                // 加载报表模板
                wordProcessor.LoadDocument(@"D:\\XF 1205-2014 Insulation\\template.docx");

                DevExpress.XtraRichEdit.API.Native.Document document = wordProcessor.Document;

                // 检验日期
                document.Replace(document.FindAll("[testdate]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], txtTestDate.Text);
                // 检验人员
                document.Replace(document.FindAll("[operator]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], txtOperator.Text);
                // 设置实验室湿度
                document.Replace(document.FindAll("[humidity]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], txtLabHumidity.Text);
                // 设置实验室温度
                document.Replace(document.FindAll("[labtemp]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], txtLabTemp.Text);
                // 设置报告编号
                document.Replace(document.FindAll("[rptno]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], txtRptNo.Text);
                // 样品名称
                document.Replace(document.FindAll("[productname]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], txtProductName.Text);
                // 样品编号
                document.Replace(document.FindAll("[sampleid]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], txtSampleId.Text);
                // 样品标识号
                document.Replace(document.FindAll("[testid]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], txtTestId.Text);
                // 检验依据
                document.Replace(document.FindAll("[testaccord]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], txtTestAccord.Text);
                // 样品养护时间
                document.Replace(document.FindAll("[productpreparetime]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], txtProductPrepareTime.Text);
                // 设备检定时间
                document.Replace(document.FindAll("[apparatuscheckdate]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], txtApparatusCheckDate.Text);
                // 设备编号
                document.Replace(document.FindAll("[apparatusid]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], txtApparatusId.Text);
                // 测试值1-5
                document.Replace(document.FindAll("[data1]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], txtPos1Value.Text);
                document.Replace(document.FindAll("[data2]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], txtPos2Value.Text);
                document.Replace(document.FindAll("[data3]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], txtPos3Value.Text);
                document.Replace(document.FindAll("[data4]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], txtPos4Value.Text);
                document.Replace(document.FindAll("[data5]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], txtPos5Value.Text);
                // 测试值最小值
                document.Replace(document.FindAll("[mindata]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], txtMinValue.Text);
                // 试验结论
                if (rdoPass.Checked) // 符合要求
                {
                    document.Replace(document.FindAll("[result]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], "■ 符合要求 \r□ 不符合要求");
                }
                else if (rdoRefuse.Checked) // 不符合要求
                {
                    document.Replace(document.FindAll("[result]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], "□ 符合要求 \r■ " + txtRefuseValue.Text + ",不符合要求");
                }
                // 备注
                document.Replace(document.FindAll("[memo]", DevExpress.XtraRichEdit.API.Native.SearchOptions.WholeWord)[0], txtMemo.Text);

                wordProcessor.SaveDocument($"{rptpath}\\report.docx", DocumentFormat.OpenXml);
            }
            MessageBox.Show("生成报告成功!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            /* 重置试验相关信息 */

            // 样品编号
            txtSampleId.Text = string.Empty;
            // 样品标识号
            txtTestId.Text = string.Empty;
            // 报告编号
            txtRptNo.Text = string.Empty;
            // 样品名称
            txtProductName.Text = string.Empty;
            // 养护时间
            txtProductPrepareTime.Text = string.Empty;
            // 试验结论补充说明
            txtRefuseValue.Text = string.Empty;
            // 备注
            txtMemo.Text = string.Empty;
            // 试验日期
            txtTestDate.Text = string.Empty;
            // 试验人员
            txtOperator.Text = string.Empty;
            // 点位1-5记录值
            txtPos1Value.Text = string.Empty;
            txtPos2Value.Text = string.Empty;
            txtPos3Value.Text = string.Empty;
            txtPos4Value.Text = string.Empty;
            txtPos5Value.Text = string.Empty;
            // 记录值最小值
            txtMinValue.Text = string.Empty;
        }

        private void TestRecordForm_Load(object sender, EventArgs e)
        {
            DefaultValue? defaultValue = null;
            /* 读取应用程序配置文件 */
            try
            {
                using StreamReader sr = new("config.json");
                var json = sr.ReadToEnd();
                defaultValue = JsonSerializer.Deserialize<DefaultValue>(json);
            }
            catch (Exception)
            {
                //throw;
            }
            /* 设置初始默认值 */
            if (defaultValue != null)
            {
                // 实验室温度
                txtLabTemp.Text = defaultValue.LabTemp;
                // 实验室湿度
                txtLabHumidity.Text = defaultValue.LabHumidity;
                // 检验标准
                txtTestAccord.Text = defaultValue.TestAccord;
                // 设备编号
                txtApparatusId.Text = defaultValue.ApparatusId;
                // 设备名称
                txtApparatusName.Text = defaultValue.ApparatusName;
                // 设备检定日期
                txtApparatusCheckDate.Text = defaultValue.ApparatusCheckDate;
                // 样品名称
                txtProductName.Text = defaultValue.ProductName;
                // 养护日期
                txtProductPrepareTime.Text = defaultValue.SamplePrepareTime;
                // 试验人员
                txtOperator.Text = defaultValue.Operator;
            }
            else
            {
                // 实验室温度
                txtLabTemp.Text = "25";
                // 实验室湿度
                txtLabHumidity.Text = "80";
                // 检验标准
                txtTestAccord.Text = "XF 1025-2014";
                // 设备编号
                txtApparatusId.Text = "0001";
                // 设备名称
                txtApparatusName.Text = "灭火毯绝缘性试验装置";
                // 设备检定日期
                txtApparatusCheckDate.Text = string.Empty;
            }
            // 试验日期
            txtTestDate.Text = DateTime.Now.ToString("yyyy年MM月dd日");
        }

        private void txtSampleId_Leave(object sender, EventArgs e)
        {
            // 同步设置报告编号
            txtRptNo.Text = txtSampleId.Text;
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CaculateMinData()
        {
            // 计算并填写测试数据的最小值
            double val1 = 0;
            double val2 = 0;
            double val3 = 0;
            double val4 = 0;
            double val5 = 0;
            double minval = 0;
            Double.TryParse(txtPos1Value.Text, out val1);
            Double.TryParse(txtPos2Value.Text, out val2);
            Double.TryParse(txtPos3Value.Text, out val3);
            Double.TryParse(txtPos4Value.Text, out val4);
            Double.TryParse(txtPos5Value.Text, out val5);
            minval = Math.Min(val1, Math.Min(val2, Math.Min(val3, Math.Min(val4, val5))));
            txtMinValue.Text = minval.ToString();
        }

        private void txtPos1Value_Leave(object sender, EventArgs e)
        {
            CaculateMinData();
        }

        private void txtPos2Value_Leave(object sender, EventArgs e)
        {
            CaculateMinData();
        }

        private void txtPos3Value_Leave(object sender, EventArgs e)
        {
            CaculateMinData();
        }

        private void txtPos4Value_Leave(object sender, EventArgs e)
        {
            CaculateMinData();
        }
        private void txtPos5Value_Leave(object sender, EventArgs e)
        {
            CaculateMinData();
        }
    }
}
