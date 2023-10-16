
namespace CS2SrvTools
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiIntegerUpDown1 = new Sunny.UI.UIIntegerUpDown();
            this.uiCheckBox1 = new Sunny.UI.UICheckBox();
            this.uiCheckBox2 = new Sunny.UI.UICheckBox();
            this.uiCheckBox3 = new Sunny.UI.UICheckBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiTextBox2 = new Sunny.UI.UITextBox();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.uiButton4 = new Sunny.UI.UIButton();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiTextBox3 = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiTextBox4 = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(33, 101);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(116, 23);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "端口:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiIntegerUpDown1
            // 
            this.uiIntegerUpDown1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiIntegerUpDown1.Location = new System.Drawing.Point(94, 98);
            this.uiIntegerUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiIntegerUpDown1.MinimumSize = new System.Drawing.Size(100, 0);
            this.uiIntegerUpDown1.Name = "uiIntegerUpDown1";
            this.uiIntegerUpDown1.ShowText = false;
            this.uiIntegerUpDown1.Size = new System.Drawing.Size(148, 29);
            this.uiIntegerUpDown1.TabIndex = 1;
            this.uiIntegerUpDown1.Text = "uiIntegerUpDown1";
            this.uiIntegerUpDown1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiIntegerUpDown1.Value = 11451;
            this.uiIntegerUpDown1.ValueChanged += new Sunny.UI.UIIntegerUpDown.OnValueChanged(this.uiIntegerUpDown1_ValueChanged);
            // 
            // uiCheckBox1
            // 
            this.uiCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCheckBox1.Location = new System.Drawing.Point(380, 206);
            this.uiCheckBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox1.Name = "uiCheckBox1";
            this.uiCheckBox1.Size = new System.Drawing.Size(274, 29);
            this.uiCheckBox1.TabIndex = 2;
            this.uiCheckBox1.Text = "启用WAN模式(内网不要选)";
            // 
            // uiCheckBox2
            // 
            this.uiCheckBox2.Checked = true;
            this.uiCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCheckBox2.Location = new System.Drawing.Point(35, 206);
            this.uiCheckBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox2.Name = "uiCheckBox2";
            this.uiCheckBox2.Size = new System.Drawing.Size(331, 29);
            this.uiCheckBox2.TabIndex = 3;
            this.uiCheckBox2.Text = "禁用 ValveAllowCheat(VAC :D)";
            // 
            // uiCheckBox3
            // 
            this.uiCheckBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCheckBox3.Location = new System.Drawing.Point(266, 98);
            this.uiCheckBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox3.Name = "uiCheckBox3";
            this.uiCheckBox3.Size = new System.Drawing.Size(123, 29);
            this.uiCheckBox3.TabIndex = 4;
            this.uiCheckBox3.Text = "启用密码";
            this.uiCheckBox3.CheckedChanged += new System.EventHandler(this.uiCheckBox3_CheckedChanged);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(395, 101);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(60, 23);
            this.uiLabel2.TabIndex = 5;
            this.uiLabel2.Text = "密码:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.DoubleValue = 7355608D;
            this.uiTextBox1.Enabled = false;
            this.uiTextBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.IntValue = 7355608;
            this.uiTextBox1.Location = new System.Drawing.Point(454, 98);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(202, 29);
            this.uiTextBox1.TabIndex = 6;
            this.uiTextBox1.Text = "7355608";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "";
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiButton1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.uiButton1.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.uiButton1.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.uiButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(554, 241);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiButton1.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.uiButton1.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.uiButton1.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.Style = Sunny.UI.UIStyle.Green;
            this.uiButton1.TabIndex = 7;
            this.uiButton1.Text = "Start";
            this.uiButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Enabled = false;
            this.uiButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiButton2.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.uiButton2.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiButton2.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiButton2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(448, 241);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiButton2.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.uiButton2.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiButton2.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiButton2.Size = new System.Drawing.Size(100, 35);
            this.uiButton2.Style = Sunny.UI.UIStyle.Red;
            this.uiButton2.TabIndex = 8;
            this.uiButton2.Text = "Stop";
            this.uiButton2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(37, 54);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(148, 23);
            this.uiLabel3.TabIndex = 10;
            this.uiLabel3.Text = "CS2.exe 位置:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox2
            // 
            this.uiTextBox2.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.uiTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox2.Location = new System.Drawing.Point(176, 52);
            this.uiTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox2.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox2.Name = "uiTextBox2";
            this.uiTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox2.ShowText = false;
            this.uiTextBox2.Size = new System.Drawing.Size(343, 29);
            this.uiTextBox2.TabIndex = 11;
            this.uiTextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox2.Watermark = "";
            this.uiTextBox2.TextChanged += new System.EventHandler(this.uiTextBox2_TextChanged);
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.Location = new System.Drawing.Point(573, 54);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(83, 27);
            this.uiButton3.TabIndex = 12;
            this.uiButton3.Text = "Auto Detect";
            this.uiButton3.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // uiButton4
            // 
            this.uiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton4.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton4.Location = new System.Drawing.Point(520, 54);
            this.uiButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton4.Name = "uiButton4";
            this.uiButton4.Size = new System.Drawing.Size(47, 27);
            this.uiButton4.TabIndex = 13;
            this.uiButton4.Text = "选择";
            this.uiButton4.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton4.Click += new System.EventHandler(this.uiButton4_Click);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(32, 136);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 23);
            this.uiLabel4.TabIndex = 14;
            this.uiLabel4.Text = "模式:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiComboBox1.Items.AddRange(new object[] {
            "竞技模式",
            "休闲模式",
            "死亡竞赛模式"});
            this.uiComboBox1.Location = new System.Drawing.Point(91, 134);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(150, 29);
            this.uiComboBox1.TabIndex = 15;
            this.uiComboBox1.Text = "自己选别看我";
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.Watermark = "";
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(32, 169);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(100, 23);
            this.uiLabel5.TabIndex = 16;
            this.uiLabel5.Text = "附加参数:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox3
            // 
            this.uiTextBox3.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.uiTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox3.Location = new System.Drawing.Point(140, 167);
            this.uiTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox3.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox3.Name = "uiTextBox3";
            this.uiTextBox3.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox3.ShowText = false;
            this.uiTextBox3.Size = new System.Drawing.Size(516, 29);
            this.uiTextBox3.TabIndex = 17;
            this.uiTextBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox3.Watermark = "";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.Location = new System.Drawing.Point(262, 136);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(100, 23);
            this.uiLabel6.TabIndex = 18;
            this.uiLabel6.Text = "地图:";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox4
            // 
            this.uiTextBox4.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.uiTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox4.Location = new System.Drawing.Point(319, 133);
            this.uiTextBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox4.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox4.Name = "uiTextBox4";
            this.uiTextBox4.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox4.ShowText = false;
            this.uiTextBox4.Size = new System.Drawing.Size(335, 29);
            this.uiTextBox4.TabIndex = 19;
            this.uiTextBox4.Text = "de_dust2";
            this.uiTextBox4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox4.Watermark = "";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(680, 292);
            this.Controls.Add(this.uiTextBox4);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiTextBox3);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiComboBox1);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiButton4);
            this.Controls.Add(this.uiButton3);
            this.Controls.Add(this.uiTextBox2);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiCheckBox3);
            this.Controls.Add(this.uiCheckBox2);
            this.Controls.Add(this.uiCheckBox1);
            this.Controls.Add(this.uiIntegerUpDown1);
            this.Controls.Add(this.uiLabel1);
            this.Name = "Form1";
            this.Text = "CS2 ServerTool";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 800, 450);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIIntegerUpDown uiIntegerUpDown1;
        private Sunny.UI.UICheckBox uiCheckBox1;
        private Sunny.UI.UICheckBox uiCheckBox2;
        private Sunny.UI.UICheckBox uiCheckBox3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UIButton uiButton4;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox uiTextBox3;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox uiTextBox4;
    }
}

