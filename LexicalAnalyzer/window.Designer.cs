namespace LexicalAnalyzer
{
    partial class window
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.keyWordControl = new System.Windows.Forms.TabControl();
            this.IdentifyPage = new System.Windows.Forms.TabPage();
            this.identifierText = new System.Windows.Forms.RichTextBox();
            this.saveidentifierbutton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.identifierImportButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ConstantPage = new System.Windows.Forms.TabPage();
            this.saveConstantButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ResultView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.WorkButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.constantText = new System.Windows.Forms.RichTextBox();
            this.InBox = new System.Windows.Forms.RichTextBox();
            this.KeyWordPage = new System.Windows.Forms.TabPage();
            this.OperatorPage = new System.Windows.Forms.TabPage();
            this.DelimiterPage = new System.Windows.Forms.TabPage();
            this.keyWordText = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.operatorText = new System.Windows.Forms.RichTextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.delimiterText = new System.Windows.Forms.RichTextBox();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.KeyWordcheck = new System.Windows.Forms.CheckBox();
            this.Identifiercheck = new System.Windows.Forms.CheckBox();
            this.Constantcheck = new System.Windows.Forms.CheckBox();
            this.Operatorcheck = new System.Windows.Forms.CheckBox();
            this.Delimitercheck = new System.Windows.Forms.CheckBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.keyWordControl.SuspendLayout();
            this.IdentifyPage.SuspendLayout();
            this.ConstantPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.KeyWordPage.SuspendLayout();
            this.OperatorPage.SuspendLayout();
            this.DelimiterPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 523);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.UseWaitCursor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CheckButton);
            this.tabPage1.Controls.Add(this.Delimitercheck);
            this.tabPage1.Controls.Add(this.Operatorcheck);
            this.tabPage1.Controls.Add(this.Constantcheck);
            this.tabPage1.Controls.Add(this.Identifiercheck);
            this.tabPage1.Controls.Add(this.KeyWordcheck);
            this.tabPage1.Controls.Add(this.keyWordControl);
            this.tabPage1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(692, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "构造DFA";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.UseWaitCursor = true;
            // 
            // keyWordControl
            // 
            this.keyWordControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.keyWordControl.Controls.Add(this.KeyWordPage);
            this.keyWordControl.Controls.Add(this.IdentifyPage);
            this.keyWordControl.Controls.Add(this.ConstantPage);
            this.keyWordControl.Controls.Add(this.OperatorPage);
            this.keyWordControl.Controls.Add(this.DelimiterPage);
            this.keyWordControl.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.keyWordControl.Location = new System.Drawing.Point(17, 6);
            this.keyWordControl.Multiline = true;
            this.keyWordControl.Name = "keyWordControl";
            this.keyWordControl.SelectedIndex = 0;
            this.keyWordControl.Size = new System.Drawing.Size(376, 480);
            this.keyWordControl.TabIndex = 0;
            this.keyWordControl.UseWaitCursor = true;
            // 
            // IdentifyPage
            // 
            this.IdentifyPage.Controls.Add(this.identifierText);
            this.IdentifyPage.Controls.Add(this.saveidentifierbutton);
            this.IdentifyPage.Controls.Add(this.button6);
            this.IdentifyPage.Controls.Add(this.button5);
            this.IdentifyPage.Controls.Add(this.identifierImportButton);
            this.IdentifyPage.Controls.Add(this.button4);
            this.IdentifyPage.Controls.Add(this.label3);
            this.IdentifyPage.Location = new System.Drawing.Point(22, 4);
            this.IdentifyPage.Name = "IdentifyPage";
            this.IdentifyPage.Size = new System.Drawing.Size(350, 472);
            this.IdentifyPage.TabIndex = 0;
            this.IdentifyPage.Text = "标识符文法";
            this.IdentifyPage.UseVisualStyleBackColor = true;
            this.IdentifyPage.UseWaitCursor = true;
            // 
            // identifierText
            // 
            this.identifierText.Location = new System.Drawing.Point(12, 39);
            this.identifierText.Name = "identifierText";
            this.identifierText.Size = new System.Drawing.Size(280, 353);
            this.identifierText.TabIndex = 27;
            this.identifierText.Text = "";
            this.identifierText.UseWaitCursor = true;
            // 
            // saveidentifierbutton
            // 
            this.saveidentifierbutton.Location = new System.Drawing.Point(12, 398);
            this.saveidentifierbutton.Name = "saveidentifierbutton";
            this.saveidentifierbutton.Size = new System.Drawing.Size(124, 33);
            this.saveidentifierbutton.TabIndex = 26;
            this.saveidentifierbutton.Text = "保存文法...";
            this.saveidentifierbutton.UseVisualStyleBackColor = true;
            this.saveidentifierbutton.UseWaitCursor = true;
            this.saveidentifierbutton.Click += new System.EventHandler(this.saveidentifierbutton_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(144, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(54, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "ε";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.UseWaitCursor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(93, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "→";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.UseWaitCursor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // identifierImportButton
            // 
            this.identifierImportButton.Location = new System.Drawing.Point(153, 398);
            this.identifierImportButton.Name = "identifierImportButton";
            this.identifierImportButton.Size = new System.Drawing.Size(124, 33);
            this.identifierImportButton.TabIndex = 6;
            this.identifierImportButton.Text = "标识符文法导入";
            this.identifierImportButton.UseVisualStyleBackColor = true;
            this.identifierImportButton.UseWaitCursor = true;
            this.identifierImportButton.Click += new System.EventHandler(this.identifierImportButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(210, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "打开文件...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.UseWaitCursor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "辅助输入工具";
            this.label3.UseWaitCursor = true;
            // 
            // ConstantPage
            // 
            this.ConstantPage.Controls.Add(this.constantText);
            this.ConstantPage.Controls.Add(this.saveConstantButton);
            this.ConstantPage.Controls.Add(this.button7);
            this.ConstantPage.Controls.Add(this.button8);
            this.ConstantPage.Controls.Add(this.button9);
            this.ConstantPage.Controls.Add(this.button10);
            this.ConstantPage.Controls.Add(this.label10);
            this.ConstantPage.Location = new System.Drawing.Point(22, 4);
            this.ConstantPage.Name = "ConstantPage";
            this.ConstantPage.Size = new System.Drawing.Size(350, 472);
            this.ConstantPage.TabIndex = 1;
            this.ConstantPage.Text = "常量文法";
            this.ConstantPage.UseVisualStyleBackColor = true;
            this.ConstantPage.UseWaitCursor = true;
            // 
            // saveConstantButton
            // 
            this.saveConstantButton.Location = new System.Drawing.Point(21, 399);
            this.saveConstantButton.Name = "saveConstantButton";
            this.saveConstantButton.Size = new System.Drawing.Size(124, 33);
            this.saveConstantButton.TabIndex = 38;
            this.saveConstantButton.Text = "保存文法...";
            this.saveConstantButton.UseVisualStyleBackColor = true;
            this.saveConstantButton.UseWaitCursor = true;
            this.saveConstantButton.Click += new System.EventHandler(this.saveConstantButton_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(151, 11);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 23);
            this.button7.TabIndex = 31;
            this.button7.Text = "ε";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.UseWaitCursor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(100, 11);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 23);
            this.button8.TabIndex = 30;
            this.button8.Text = "→";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.UseWaitCursor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(162, 399);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(124, 33);
            this.button9.TabIndex = 28;
            this.button9.Text = "常量文法导入";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.UseWaitCursor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(209, 11);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(90, 23);
            this.button10.TabIndex = 27;
            this.button10.Text = "打开文件...";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.UseWaitCursor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 26;
            this.label10.Text = "辅助输入工具";
            this.label10.UseWaitCursor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.InBox);
            this.tabPage2.Controls.Add(this.ResultView);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.WorkButton);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(692, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "词法分析";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.UseWaitCursor = true;
            // 
            // ResultView
            // 
            this.ResultView.Location = new System.Drawing.Point(300, 37);
            this.ResultView.Name = "ResultView";
            this.ResultView.Size = new System.Drawing.Size(386, 438);
            this.ResultView.TabIndex = 5;
            this.ResultView.UseCompatibleStateImageBehavior = false;
            this.ResultView.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "分析结果";
            this.label2.UseWaitCursor = true;
            // 
            // WorkButton
            // 
            this.WorkButton.Location = new System.Drawing.Point(135, 442);
            this.WorkButton.Name = "WorkButton";
            this.WorkButton.Size = new System.Drawing.Size(148, 33);
            this.WorkButton.TabIndex = 3;
            this.WorkButton.Text = "开始分析";
            this.WorkButton.UseVisualStyleBackColor = true;
            this.WorkButton.UseWaitCursor = true;
            this.WorkButton.Click += new System.EventHandler(this.WorkButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "导入文件...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "待分析内容";
            this.label1.UseWaitCursor = true;
            // 
            // constantText
            // 
            this.constantText.Location = new System.Drawing.Point(19, 40);
            this.constantText.Name = "constantText";
            this.constantText.Size = new System.Drawing.Size(280, 353);
            this.constantText.TabIndex = 39;
            this.constantText.Text = "";
            this.constantText.TextChanged += new System.EventHandler(this.constantText_TextChanged);
            // 
            // InBox
            // 
            this.InBox.Location = new System.Drawing.Point(7, 37);
            this.InBox.Name = "InBox";
            this.InBox.Size = new System.Drawing.Size(276, 399);
            this.InBox.TabIndex = 6;
            this.InBox.Text = "";
            // 
            // KeyWordPage
            // 
            this.KeyWordPage.Controls.Add(this.keyWordText);
            this.KeyWordPage.Controls.Add(this.button2);
            this.KeyWordPage.Controls.Add(this.button3);
            this.KeyWordPage.Controls.Add(this.button11);
            this.KeyWordPage.Controls.Add(this.button12);
            this.KeyWordPage.Controls.Add(this.button13);
            this.KeyWordPage.Controls.Add(this.label14);
            this.KeyWordPage.Location = new System.Drawing.Point(22, 4);
            this.KeyWordPage.Name = "KeyWordPage";
            this.KeyWordPage.Size = new System.Drawing.Size(350, 472);
            this.KeyWordPage.TabIndex = 2;
            this.KeyWordPage.Text = "关键字文法";
            this.KeyWordPage.UseVisualStyleBackColor = true;
            // 
            // OperatorPage
            // 
            this.OperatorPage.Controls.Add(this.operatorText);
            this.OperatorPage.Controls.Add(this.button14);
            this.OperatorPage.Controls.Add(this.button15);
            this.OperatorPage.Controls.Add(this.button16);
            this.OperatorPage.Controls.Add(this.button17);
            this.OperatorPage.Controls.Add(this.button18);
            this.OperatorPage.Controls.Add(this.label18);
            this.OperatorPage.Location = new System.Drawing.Point(22, 4);
            this.OperatorPage.Name = "OperatorPage";
            this.OperatorPage.Size = new System.Drawing.Size(350, 472);
            this.OperatorPage.TabIndex = 3;
            this.OperatorPage.Text = "运算符文法";
            this.OperatorPage.UseVisualStyleBackColor = true;
            // 
            // DelimiterPage
            // 
            this.DelimiterPage.Controls.Add(this.delimiterText);
            this.DelimiterPage.Controls.Add(this.button19);
            this.DelimiterPage.Controls.Add(this.button20);
            this.DelimiterPage.Controls.Add(this.button21);
            this.DelimiterPage.Controls.Add(this.button22);
            this.DelimiterPage.Controls.Add(this.button23);
            this.DelimiterPage.Controls.Add(this.label22);
            this.DelimiterPage.Location = new System.Drawing.Point(22, 4);
            this.DelimiterPage.Name = "DelimiterPage";
            this.DelimiterPage.Size = new System.Drawing.Size(350, 472);
            this.DelimiterPage.TabIndex = 4;
            this.DelimiterPage.Text = "界符文法";
            this.DelimiterPage.UseVisualStyleBackColor = true;
            this.DelimiterPage.Click += new System.EventHandler(this.DelimiterPage_Click);
            // 
            // keyWordText
            // 
            this.keyWordText.Location = new System.Drawing.Point(19, 53);
            this.keyWordText.Name = "keyWordText";
            this.keyWordText.Size = new System.Drawing.Size(280, 353);
            this.keyWordText.TabIndex = 40;
            this.keyWordText.Text = "";
            this.keyWordText.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 33);
            this.button2.TabIndex = 39;
            this.button2.Text = "保存文法...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(151, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "ε";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.UseWaitCursor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(100, 24);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(45, 23);
            this.button11.TabIndex = 31;
            this.button11.Text = "→";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.UseWaitCursor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(160, 412);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(124, 33);
            this.button12.TabIndex = 30;
            this.button12.Text = "关键字文法导入";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.UseWaitCursor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(217, 24);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(82, 23);
            this.button13.TabIndex = 29;
            this.button13.Text = "打开文件...";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.UseWaitCursor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 28;
            this.label14.Text = "辅助输入工具";
            this.label14.UseWaitCursor = true;
            // 
            // operatorText
            // 
            this.operatorText.Location = new System.Drawing.Point(19, 53);
            this.operatorText.Name = "operatorText";
            this.operatorText.Size = new System.Drawing.Size(280, 353);
            this.operatorText.TabIndex = 40;
            this.operatorText.Text = "";
            this.operatorText.UseWaitCursor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(19, 412);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(124, 33);
            this.button14.TabIndex = 39;
            this.button14.Text = "保存文法...";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.UseWaitCursor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(151, 24);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(54, 23);
            this.button15.TabIndex = 32;
            this.button15.Text = "ε";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.UseWaitCursor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(100, 24);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(45, 23);
            this.button16.TabIndex = 31;
            this.button16.Text = "→";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.UseWaitCursor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(175, 412);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(124, 33);
            this.button17.TabIndex = 30;
            this.button17.Text = "运算符文法导入";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.UseWaitCursor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(217, 24);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(82, 23);
            this.button18.TabIndex = 29;
            this.button18.Text = "打开文件...";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.UseWaitCursor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 12);
            this.label18.TabIndex = 28;
            this.label18.Text = "辅助输入工具";
            this.label18.UseWaitCursor = true;
            // 
            // delimiterText
            // 
            this.delimiterText.Location = new System.Drawing.Point(24, 47);
            this.delimiterText.Name = "delimiterText";
            this.delimiterText.Size = new System.Drawing.Size(280, 353);
            this.delimiterText.TabIndex = 40;
            this.delimiterText.Text = "";
            this.delimiterText.UseWaitCursor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(24, 406);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(124, 33);
            this.button19.TabIndex = 39;
            this.button19.Text = "保存文法...";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.UseWaitCursor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(156, 18);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(54, 23);
            this.button20.TabIndex = 32;
            this.button20.Text = "ε";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.UseWaitCursor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(105, 18);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(45, 23);
            this.button21.TabIndex = 31;
            this.button21.Text = "→";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.UseWaitCursor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(180, 406);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(124, 33);
            this.button22.TabIndex = 30;
            this.button22.Text = "界符法导入";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.UseWaitCursor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(222, 18);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(82, 23);
            this.button23.TabIndex = 29;
            this.button23.Text = "打开文件...";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.UseWaitCursor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(22, 23);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 12);
            this.label22.TabIndex = 28;
            this.label22.Text = "辅助输入工具";
            this.label22.UseWaitCursor = true;
            // 
            // KeyWordcheck
            // 
            this.KeyWordcheck.AutoSize = true;
            this.KeyWordcheck.Location = new System.Drawing.Point(477, 83);
            this.KeyWordcheck.Name = "KeyWordcheck";
            this.KeyWordcheck.Size = new System.Drawing.Size(107, 20);
            this.KeyWordcheck.TabIndex = 30;
            this.KeyWordcheck.Text = "关键字文法";
            this.KeyWordcheck.UseVisualStyleBackColor = true;
            // 
            // Identifiercheck
            // 
            this.Identifiercheck.AutoSize = true;
            this.Identifiercheck.Location = new System.Drawing.Point(477, 128);
            this.Identifiercheck.Name = "Identifiercheck";
            this.Identifiercheck.Size = new System.Drawing.Size(107, 20);
            this.Identifiercheck.TabIndex = 31;
            this.Identifiercheck.Text = "标识符文法";
            this.Identifiercheck.UseVisualStyleBackColor = true;
            // 
            // Constantcheck
            // 
            this.Constantcheck.AutoSize = true;
            this.Constantcheck.Location = new System.Drawing.Point(477, 181);
            this.Constantcheck.Name = "Constantcheck";
            this.Constantcheck.Size = new System.Drawing.Size(91, 20);
            this.Constantcheck.TabIndex = 32;
            this.Constantcheck.Text = "常量文法";
            this.Constantcheck.UseVisualStyleBackColor = true;
            // 
            // Operatorcheck
            // 
            this.Operatorcheck.AutoSize = true;
            this.Operatorcheck.Location = new System.Drawing.Point(477, 235);
            this.Operatorcheck.Name = "Operatorcheck";
            this.Operatorcheck.Size = new System.Drawing.Size(107, 20);
            this.Operatorcheck.TabIndex = 33;
            this.Operatorcheck.Text = "运算符文法";
            this.Operatorcheck.UseVisualStyleBackColor = true;
            // 
            // Delimitercheck
            // 
            this.Delimitercheck.AutoSize = true;
            this.Delimitercheck.Location = new System.Drawing.Point(477, 289);
            this.Delimitercheck.Name = "Delimitercheck";
            this.Delimitercheck.Size = new System.Drawing.Size(91, 20);
            this.Delimitercheck.TabIndex = 34;
            this.Delimitercheck.Text = "界符文法";
            this.Delimitercheck.UseVisualStyleBackColor = true;
            this.Delimitercheck.CheckedChanged += new System.EventHandler(this.Delimitercheck_CheckedChanged);
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(466, 356);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(118, 47);
            this.CheckButton.TabIndex = 35;
            this.CheckButton.Text = "移除已导入的所选文法DFA";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 536);
            this.Controls.Add(this.tabControl1);
            this.Name = "window";
            this.Text = "LexicalAnalyzer";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.window_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.keyWordControl.ResumeLayout(false);
            this.IdentifyPage.ResumeLayout(false);
            this.IdentifyPage.PerformLayout();
            this.ConstantPage.ResumeLayout(false);
            this.ConstantPage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.KeyWordPage.ResumeLayout(false);
            this.KeyWordPage.PerformLayout();
            this.OperatorPage.ResumeLayout(false);
            this.OperatorPage.PerformLayout();
            this.DelimiterPage.ResumeLayout(false);
            this.DelimiterPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl keyWordControl;
        private System.Windows.Forms.TabPage IdentifyPage;
        private System.Windows.Forms.TabPage ConstantPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView ResultView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button WorkButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button identifierImportButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button saveidentifierbutton;
        private System.Windows.Forms.Button saveConstantButton;
        private System.Windows.Forms.RichTextBox identifierText;
        private System.Windows.Forms.RichTextBox constantText;
        private System.Windows.Forms.RichTextBox InBox;
        private System.Windows.Forms.TabPage KeyWordPage;
        private System.Windows.Forms.RichTextBox keyWordText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage OperatorPage;
        private System.Windows.Forms.RichTextBox operatorText;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage DelimiterPage;
        private System.Windows.Forms.RichTextBox delimiterText;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox Delimitercheck;
        private System.Windows.Forms.CheckBox Operatorcheck;
        private System.Windows.Forms.CheckBox Constantcheck;
        private System.Windows.Forms.CheckBox Identifiercheck;
        private System.Windows.Forms.CheckBox KeyWordcheck;
        private System.Windows.Forms.Button CheckButton;

    }
}

