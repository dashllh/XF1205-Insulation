using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
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
            using (var wordProcessor = new RichEditDocumentServer())
            {
                wordProcessor.LoadDocument(@"E:\\test.docx");

                DevExpress.XtraRichEdit.API.Native.Document document = wordProcessor.Document;

                // 检验日期
                document.InsertText(document.CreatePosition(422), txtTestDate.Text);
                // 检验人员
                document.InsertText(document.CreatePosition(308), txtOperator.Text);
                // 设置实验室湿度
                document.InsertText(document.CreatePosition(141), txtLabHumidity.Text);
                // 设置实验室温度
                document.InsertText(document.CreatePosition(100), txtLabTemp.Text);
                // 设置报告编号
                document.InsertText(document.CreatePosition(62), txtRptNo.Text);
                
                // 设置表格数据
                Table table = document.Tables[0];
                table.BeginUpdate();

                // 样品名称
                document.InsertSingleLineText(table[0, 1].Range.Start, txtProductName.Text);
                // 样品编号
                document.InsertSingleLineText(table[0, 3].Range.Start, txtSampleId.Text);
                // 样品标识号
                document.InsertSingleLineText(table[1, 3].Range.Start, txtTestId.Text);
                // 检验依据
                document.InsertSingleLineText(table[2, 3].Range.Start, txtTestAccord.Text);
                // 样品养护时间
                document.InsertSingleLineText(table[3, 3].Range.Start, txtProductPrepareTime.Text);
                // 设备检定时间
                document.InsertSingleLineText(table[4, 1].Range.Start, txtApparatusCheckDate.Text);
                // 设备编号
                document.InsertSingleLineText(table[4, 3].Range.Start, txtApparatusId.Text);
                // 测试值1-5
                document.InsertSingleLineText(table[8, 1].Range.Start, txtPos1Value.Text);
                document.InsertSingleLineText(table[8, 2].Range.Start, txtPos2Value.Text);
                document.InsertSingleLineText(table[8, 3].Range.Start, txtPos3Value.Text);
                document.InsertSingleLineText(table[8, 4].Range.Start, txtPos4Value.Text);
                document.InsertSingleLineText(table[8, 5].Range.Start, txtPos5Value.Text);
                // 测试值最小值
                document.InsertSingleLineText(table[8, 6].Range.Start, txtMinValue.Text);
                // 试验结论
                if(rdoPass.Checked) // 符合要求
                {       
                    document.InsertText(table[8, 7].Range.Start, "■ 符合要求 \r□ 不符合要求");                    
                } 
                else if (rdoRefuse.Checked) // 不符合要求
                {
                    document.InsertText(table[8, 7].Range.Start, "□ 符合要求 \r■ " + txtRefuseValue.Text + ",不符合要求");
                }
                // 备注
                document.InsertSingleLineText(table[9, 1].Range.Start, txtMemo.Text);

                table.EndUpdate();

                wordProcessor.SaveDocument(@"E:\\mytest.docx", DocumentFormat.OpenXml);
            }
            MessageBox.Show("保存报表成功!");
        }
        
        private void btnClearInput_Click(object sender, EventArgs e)
        {
            /* 重置试验相关信息 */

            // 
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
    }
}
