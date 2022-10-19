using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

namespace CharEdit_Project
{
    public partial class Form1 : Form
    {

        string[] sSetName = { "col_string_@", "col_catch_@", "col_fill_@", "col_date_@", "$", "[", "]", "L_", "R_" };
        string[] sReName = { "固定值:", "字串擷取:起始位置 =>", "字元填補:填補位置 =>", "日期格式:", " 擷取長度 =>", " 填充字元 =>", " 補滿長度 =>", "左側", "右側" };

        //string[] sSetFormat = { "$", "[", "]", "L_", "R_" };
        //string[] sReFormat = { " 擷取長度 =>", " 填充字元 =>", " 補滿長度 =>", "左側", "右側" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region 確認版本並更新主程式
            //獲得當前版本
            string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text += version + " Build 2022-10-19";

            #endregion

            cbCharPad.SelectedIndex = 0;
        }

        #region 將panel2裡控制項初始化
        /// <summary>
        /// 將panel2裡控制項初始化
        /// </summary>
        private void ControlInitial()
        {
            foreach (RadioButton RB in panel2.Controls.OfType<RadioButton>())
            {
                if (RB.Checked)
                {
                    RB.Checked = false;
                    break;
                }
            }
            txt_String.Text = "";
            txt_Input.Text = "";
            txt_Start.Text = "1";
            txt_Length1.Text = "";
            txt_Char.Text = "*";
            txt_Length2.Text = "";
            txt_DateString.Text = "";

        }
        #endregion

        private void btnRuleAdd_Click(object sender, EventArgs e)
        {
            string SelectItem = "";

            foreach(RadioButton RB in panel2.Controls.OfType<RadioButton>())
            {
                if (RB.Checked)
                {
                    SelectItem = RB.Text;
                    break;
                }
            }
            if(SelectItem == "")
            {
                MessageBox.Show("請選擇編輯項目!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            switch (SelectItem)
            {
                case "固定值":
                    if(txt_String.Text == "")
                    {
                        MessageBox.Show("請輸入固定值字串!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    listParam.Items.Add("固定值:" + txt_String.Text);
                    listParam.TopIndex = listParam.Items.Count - 1;
                    break;
                case "字串擷取":
                    if(txt_Input.Text == "")
                    {
                        MessageBox.Show("請輸入字串內容!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (txt_Start.Text == "")
                    {
                        MessageBox.Show("請輸入起始位置!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (txt_Length1.Text == "")
                    {
                        MessageBox.Show("請輸入擷取長度!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (txt_Input.TextLength < int.Parse(txt_Start.Text))
                    {
                        MessageBox.Show("起始長度已大於字串內容長度!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if(int.Parse(txt_Start.Text) == 0)
                    {
                        MessageBox.Show("起始長度不得為0!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string sCutString = txt_Input.Text.Substring(int.Parse(txt_Start.Text) - 1);
                    if(sCutString.Length < int.Parse(txt_Length1.Text))
                    {
                        //sCutString = txt_Input.Text.Substring(int.Parse(txt_Start.Text) - 1, sCutString.Length);
                        MessageBox.Show("起始位置 ~ 結束位置字串長度已小於擷取長度，請重新設定擷取長度!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        sCutString = txt_Input.Text.Substring(int.Parse(txt_Start.Text) - 1, int.Parse(txt_Length1.Text));
                    }
                    
                    listParam.Items.Add("字串擷取:起始位置 =>" + txt_Start.Text + " , 擷取長度 =>" + txt_Length1.Text + " 擷取結果:" + sCutString);
                    listParam.TopIndex = listParam.Items.Count - 1;
                    break;
                case "字元填補":
                    if (txt_Input.Text == "")
                    {
                        MessageBox.Show("請輸入字串內容!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (txt_Char.Text == "")
                    {
                        MessageBox.Show("請輸入填充字元!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (txt_Length2.Text == "")
                    {
                        MessageBox.Show("請輸入補滿長度!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string sPadString = "";
                    switch (cbCharPad.Text)
                    {
                        case "左":
                            try
                            {
                                sPadString = txt_Input.Text.PadLeft(int.Parse(txt_Length2.Text), char.Parse(txt_Char.Text));                                
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show("向左填補失敗:填充字元必須剛好一個字元" , this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            break;
                        case "右":
                            try
                            {
                                sPadString = txt_Input.Text.PadRight(int.Parse(txt_Length2.Text), char.Parse(txt_Char.Text));
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show("向右填補失敗:填充字元必須剛好一個字元" , this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }                           
                            break;                 
                    }
                    listParam.Items.Add("字元填補:填補位置 =>" + cbCharPad.Text + " , 填充字元 =>" + char.Parse(txt_Char.Text) + " , 補滿長度 =>" + txt_Length2.Text + " 填補結果:" + sPadString);
                    listParam.TopIndex = listParam.Items.Count - 1;
                    break;
                case "日期格式":
                    DateTime dtDate;
                    if (txt_DateString.Text == "")
                    {
                        MessageBox.Show("請輸入日期字串!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (!DateTime.TryParse(txt_DateString.Text, out dtDate))
                        {
                            MessageBox.Show("不是正確的日期格式型別!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // 再次確認格式是否為yyyy-MM-dd---
                        string[] sCheck = txt_DateString.Text.Split('-');
                        if(sCheck.Length < 3)
                        {
                            MessageBox.Show("請輸入yyyy-MM-dd格式!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        //---------------------------------

                        listParam.Items.Add("日期格式:" + txt_DateString.Text);
                        listParam.TopIndex = listParam.Items.Count - 1;
                    }
                    break;
            }

            ControlInitial();
        }

        //項目向上 向下 刪除 清空按鈕
        private void ButtonClick(object sender, EventArgs e)
        {
            if (listParam.Items.Count == 0)
            {
                return;
            }
            int iIndex = listParam.SelectedIndex;
            switch (((System.Windows.Forms.Button)sender).Name)
            {               
                case "btnUp":
                    if(iIndex == -1)
                    {
                        MessageBox.Show("請選擇要上移的項目!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if(iIndex == 0)
                    {
                        return;
                    }
                    string sItemNameUp = listParam.Items[iIndex].ToString(); //項目名稱
                    listParam.Items.RemoveAt(iIndex);
                    listParam.Items.Insert(iIndex - 1, sItemNameUp);
                    listParam.SelectedIndex = iIndex - 1;
                    break;
                case "btnDown":
                    if (iIndex == -1)
                    {
                        MessageBox.Show("請選擇要下移的項目!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (iIndex == listParam.Items.Count - 1)
                    {                        
                        return;
                    }
                    
                    string sItemNameDown = listParam.Items[iIndex].ToString(); //項目名稱
                    listParam.Items.RemoveAt(iIndex);
                    listParam.Items.Insert(iIndex + 1, sItemNameDown);
                    listParam.SelectedIndex = iIndex + 1;
                    break;
                case "btnDelete":
                    if(iIndex == -1)
                    {
                        MessageBox.Show("請選擇要刪除的指定項目!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if(iIndex != -1)
                    {
                        listParam.Items.RemoveAt(iIndex);
                    }                    
                    break;
                case "btnClear":
                    listParam.Items.Clear();
                    break;
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            txtParamValue.Text = "";
            if(listParam.Items.Count > 0)
            {
                for(int i = 0; i < listParam.Items.Count; i++)
                {
                    string sItemName = listParam.Items[i].ToString();
                    int iIndex = sItemName.LastIndexOf(':');
                    sItemName = sItemName.Substring(iIndex + 1);
                    txtParamValue.Text += sItemName.Trim();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
        }

        #region 只能輸入數字設定

        private void txt_Start_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Length1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Length2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_DateString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar) && e.KeyChar != 45)
            {
                e.Handled = true;
            }
        }

        #endregion
       
    }
}
