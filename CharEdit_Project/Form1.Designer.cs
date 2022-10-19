namespace CharEdit_Project
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.rbtnfixString = new System.Windows.Forms.RadioButton();
            this.lblLength1 = new System.Windows.Forms.Label();
            this.txt_String = new System.Windows.Forms.TextBox();
            this.lblLength2 = new System.Windows.Forms.Label();
            this.rbtnDate = new System.Windows.Forms.RadioButton();
            this.lblChar = new System.Windows.Forms.Label();
            this.txt_DateString = new System.Windows.Forms.TextBox();
            this.txt_Start = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.rbtnPadLeft = new System.Windows.Forms.RadioButton();
            this.btnRuleAdd = new System.Windows.Forms.Button();
            this.txt_Length2 = new System.Windows.Forms.TextBox();
            this.txt_Char = new System.Windows.Forms.TextBox();
            this.cbCharPad = new System.Windows.Forms.ComboBox();
            this.rbtnRange = new System.Windows.Forms.RadioButton();
            this.txt_Length1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtParamValue = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblParam = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listParam = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_Input);
            this.panel2.Controls.Add(this.lblStart);
            this.panel2.Controls.Add(this.rbtnfixString);
            this.panel2.Controls.Add(this.lblLength1);
            this.panel2.Controls.Add(this.txt_String);
            this.panel2.Controls.Add(this.lblLength2);
            this.panel2.Controls.Add(this.rbtnDate);
            this.panel2.Controls.Add(this.lblChar);
            this.panel2.Controls.Add(this.txt_DateString);
            this.panel2.Controls.Add(this.txt_Start);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.rbtnPadLeft);
            this.panel2.Controls.Add(this.btnRuleAdd);
            this.panel2.Controls.Add(this.txt_Length2);
            this.panel2.Controls.Add(this.txt_Char);
            this.panel2.Controls.Add(this.cbCharPad);
            this.panel2.Controls.Add(this.rbtnRange);
            this.panel2.Controls.Add(this.txt_Length1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 234);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(169, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 167;
            this.label2.Text = "固定值字串:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(146, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 165;
            this.label1.Text = "請輸入字串內容:";
            // 
            // txt_Input
            // 
            this.txt_Input.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Input.Location = new System.Drawing.Point(266, 93);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(212, 27);
            this.txt_Input.TabIndex = 166;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStart.Location = new System.Drawing.Point(538, 79);
            this.lblStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(73, 20);
            this.lblStart.TabIndex = 148;
            this.lblStart.Text = "起始位置";
            // 
            // rbtnfixString
            // 
            this.rbtnfixString.AutoSize = true;
            this.rbtnfixString.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtnfixString.Location = new System.Drawing.Point(47, 27);
            this.rbtnfixString.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnfixString.Name = "rbtnfixString";
            this.rbtnfixString.Size = new System.Drawing.Size(75, 24);
            this.rbtnfixString.TabIndex = 163;
            this.rbtnfixString.Text = "固定值";
            this.rbtnfixString.UseVisualStyleBackColor = true;
            // 
            // lblLength1
            // 
            this.lblLength1.AutoSize = true;
            this.lblLength1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLength1.Location = new System.Drawing.Point(683, 119);
            this.lblLength1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLength1.Name = "lblLength1";
            this.lblLength1.Size = new System.Drawing.Size(73, 20);
            this.lblLength1.TabIndex = 149;
            this.lblLength1.Text = "補滿長度";
            // 
            // txt_String
            // 
            this.txt_String.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_String.Location = new System.Drawing.Point(266, 25);
            this.txt_String.Margin = new System.Windows.Forms.Padding(4);
            this.txt_String.Name = "txt_String";
            this.txt_String.Size = new System.Drawing.Size(212, 29);
            this.txt_String.TabIndex = 164;
            // 
            // lblLength2
            // 
            this.lblLength2.AutoSize = true;
            this.lblLength2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLength2.Location = new System.Drawing.Point(683, 79);
            this.lblLength2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLength2.Name = "lblLength2";
            this.lblLength2.Size = new System.Drawing.Size(73, 20);
            this.lblLength2.TabIndex = 150;
            this.lblLength2.Text = "擷取長度";
            // 
            // rbtnDate
            // 
            this.rbtnDate.AutoSize = true;
            this.rbtnDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtnDate.Location = new System.Drawing.Point(44, 165);
            this.rbtnDate.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnDate.Name = "rbtnDate";
            this.rbtnDate.Size = new System.Drawing.Size(91, 24);
            this.rbtnDate.TabIndex = 144;
            this.rbtnDate.Text = "日期格式";
            this.rbtnDate.UseVisualStyleBackColor = true;
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblChar.Location = new System.Drawing.Point(539, 117);
            this.lblChar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(73, 20);
            this.lblChar.TabIndex = 151;
            this.lblChar.Text = "填充字元";
            // 
            // txt_DateString
            // 
            this.txt_DateString.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_DateString.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_DateString.Location = new System.Drawing.Point(266, 164);
            this.txt_DateString.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DateString.Name = "txt_DateString";
            this.txt_DateString.Size = new System.Drawing.Size(212, 29);
            this.txt_DateString.TabIndex = 159;
            this.toolTip1.SetToolTip(this.txt_DateString, "yyyy-MM-dd");
            this.txt_DateString.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DateString_KeyPress);
            // 
            // txt_Start
            // 
            this.txt_Start.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Start.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_Start.Location = new System.Drawing.Point(619, 76);
            this.txt_Start.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Start.Name = "txt_Start";
            this.txt_Start.Size = new System.Drawing.Size(59, 29);
            this.txt_Start.TabIndex = 154;
            this.txt_Start.Text = "1";
            this.txt_Start.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Start_KeyPress);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDate.Location = new System.Drawing.Point(185, 167);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(77, 20);
            this.lblDate.TabIndex = 152;
            this.lblDate.Text = "日期字串:";
            // 
            // rbtnPadLeft
            // 
            this.rbtnPadLeft.AutoSize = true;
            this.rbtnPadLeft.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtnPadLeft.Location = new System.Drawing.Point(44, 114);
            this.rbtnPadLeft.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnPadLeft.Name = "rbtnPadLeft";
            this.rbtnPadLeft.Size = new System.Drawing.Size(91, 24);
            this.rbtnPadLeft.TabIndex = 146;
            this.rbtnPadLeft.Text = "字元填補";
            this.rbtnPadLeft.UseVisualStyleBackColor = true;
            // 
            // btnRuleAdd
            // 
            this.btnRuleAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRuleAdd.Location = new System.Drawing.Point(652, 187);
            this.btnRuleAdd.Name = "btnRuleAdd";
            this.btnRuleAdd.Size = new System.Drawing.Size(132, 30);
            this.btnRuleAdd.TabIndex = 4;
            this.btnRuleAdd.Text = "新增規則";
            this.btnRuleAdd.UseVisualStyleBackColor = true;
            this.btnRuleAdd.Click += new System.EventHandler(this.btnRuleAdd_Click);
            // 
            // txt_Length2
            // 
            this.txt_Length2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Length2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_Length2.Location = new System.Drawing.Point(763, 114);
            this.txt_Length2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Length2.Name = "txt_Length2";
            this.txt_Length2.Size = new System.Drawing.Size(54, 29);
            this.txt_Length2.TabIndex = 155;
            this.txt_Length2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Length2_KeyPress);
            // 
            // txt_Char
            // 
            this.txt_Char.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Char.Location = new System.Drawing.Point(619, 114);
            this.txt_Char.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Char.Name = "txt_Char";
            this.txt_Char.Size = new System.Drawing.Size(59, 29);
            this.txt_Char.TabIndex = 157;
            this.txt_Char.Text = "*";
            // 
            // cbCharPad
            // 
            this.cbCharPad.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbCharPad.FormattingEnabled = true;
            this.cbCharPad.Items.AddRange(new object[] {
            "左",
            "右"});
            this.cbCharPad.Location = new System.Drawing.Point(491, 113);
            this.cbCharPad.Name = "cbCharPad";
            this.cbCharPad.Size = new System.Drawing.Size(48, 28);
            this.cbCharPad.TabIndex = 162;
            // 
            // rbtnRange
            // 
            this.rbtnRange.AutoSize = true;
            this.rbtnRange.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtnRange.Location = new System.Drawing.Point(44, 76);
            this.rbtnRange.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnRange.Name = "rbtnRange";
            this.rbtnRange.Size = new System.Drawing.Size(91, 24);
            this.rbtnRange.TabIndex = 147;
            this.rbtnRange.Text = "字串擷取";
            this.rbtnRange.UseVisualStyleBackColor = true;
            // 
            // txt_Length1
            // 
            this.txt_Length1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Length1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_Length1.Location = new System.Drawing.Point(763, 76);
            this.txt_Length1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Length1.Name = "txt_Length1";
            this.txt_Length1.Size = new System.Drawing.Size(54, 29);
            this.txt_Length1.TabIndex = 156;
            this.txt_Length1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Length1_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtNote);
            this.panel3.Controls.Add(this.txtParamValue);
            this.panel3.Controls.Add(this.lblNote);
            this.panel3.Controls.Add(this.lblParam);
            this.panel3.Controls.Add(this.btnOK);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnDown);
            this.panel3.Controls.Add(this.btnUp);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.listParam);
            this.panel3.Location = new System.Drawing.Point(0, 238);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(826, 346);
            this.panel3.TabIndex = 4;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNote.Location = new System.Drawing.Point(94, 218);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(720, 29);
            this.txtNote.TabIndex = 154;
            this.txtNote.Visible = false;
            // 
            // txtParamValue
            // 
            this.txtParamValue.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtParamValue.Location = new System.Drawing.Point(94, 253);
            this.txtParamValue.Multiline = true;
            this.txtParamValue.Name = "txtParamValue";
            this.txtParamValue.ReadOnly = true;
            this.txtParamValue.Size = new System.Drawing.Size(720, 69);
            this.txtParamValue.TabIndex = 155;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNote.Location = new System.Drawing.Point(13, 221);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(41, 20);
            this.lblNote.TabIndex = 152;
            this.lblNote.Text = "備註";
            this.lblNote.Visible = false;
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblParam.Location = new System.Drawing.Point(13, 256);
            this.lblParam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(73, 20);
            this.lblParam.TabIndex = 153;
            this.lblParam.Text = "變數結果";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOK.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOK.Location = new System.Drawing.Point(746, 174);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(68, 32);
            this.btnOK.TabIndex = 147;
            this.btnOK.Text = "儲存";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(472, 176);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 30);
            this.btnClear.TabIndex = 148;
            this.btnClear.Text = "清空所有項目";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(345, 176);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 30);
            this.btnDelete.TabIndex = 149;
            this.btnDelete.Text = "刪除指定項目";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDown.Location = new System.Drawing.Point(218, 176);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(121, 30);
            this.btnDown.TabIndex = 150;
            this.btnDown.Text = "向下移動";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUp.Location = new System.Drawing.Point(91, 176);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(121, 30);
            this.btnUp.TabIndex = 151;
            this.btnUp.Text = "向上移動";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.ButtonClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(4, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 146;
            this.label3.Text = "變數內容 : ";
            // 
            // listParam
            // 
            this.listParam.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listParam.FormattingEnabled = true;
            this.listParam.HorizontalScrollbar = true;
            this.listParam.ItemHeight = 20;
            this.listParam.Location = new System.Drawing.Point(91, 10);
            this.listParam.Name = "listParam";
            this.listParam.ScrollAlwaysVisible = true;
            this.listParam.Size = new System.Drawing.Size(723, 144);
            this.listParam.TabIndex = 145;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "設定格式";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 585);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "字串編輯器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtnfixString;
        private System.Windows.Forms.TextBox txt_String;
        private System.Windows.Forms.RadioButton rbtnDate;
        private System.Windows.Forms.RadioButton rbtnPadLeft;
        private System.Windows.Forms.ComboBox cbCharPad;
        private System.Windows.Forms.RadioButton rbtnRange;
        private System.Windows.Forms.TextBox txt_DateString;
        private System.Windows.Forms.TextBox txt_Char;
        private System.Windows.Forms.TextBox txt_Length1;
        private System.Windows.Forms.TextBox txt_Length2;
        private System.Windows.Forms.TextBox txt_Start;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblChar;
        private System.Windows.Forms.Label lblLength2;
        private System.Windows.Forms.Label lblLength1;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Button btnRuleAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listParam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtParamValue;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblParam;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
    }
}

