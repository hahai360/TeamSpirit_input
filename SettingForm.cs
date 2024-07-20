using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TeamSprit_input
{
    public partial class SettingForm : Form
    {
        // 正規表現定義関連
        private const String timeFormatCheckRegexp = "^[0-9]{1,2}:[0-5][0-9]";                    // 99:59 or 9:59
        private const String timeNumberCheckRegexp = "^([0-9]{2}[0-5][0-9]|[0-9][0-5][0-9])$";    // 9959 or 959

        // 設定情報
        public Settings setValues = new Settings();
        
        public SettingForm(bool isStart, Settings setting)
        {
            InitializeComponent();

            userText.Text           = "";
            passText.Text           = "";
            startTimeText.Text      = "";
            endTimeText.Text        = "";
            restStartTime1Text.Text = "";
            restEndTime1Text.Text   = "";
            restStartTime2Text.Text = "";
            restEndTime2Text.Text   = "";

            InitDateComb();

            if (isStart)
            {
                backButton.Visible = false;
                return;
            }

            setValues = setting.Clone();

            userText.Text               = setValues.userName;
            passText.Text               = setValues.password;
            startTimeText.Text          = setValues.startTime;
            endTimeText.Text            = setValues.endTime;
            restStartTime1Text.Text     = setValues.startRest1;
            restEndTime1Text.Text       = setValues.endRest1;
            restStartTime2Text.Text     = setValues.startRest2;
            restEndTime2Text.Text       = setValues.endRest2;
            workPlaceComb.SelectedValue = setValues.workPlace;
            browserComb.SelectedValue   = (int) setValues.browserType;
        }

        private void InitDateComb()
        {
            // ブラウザ選択用コンボボックス設定
            {
                browserComb.DataSource    = Settings.BrowserData();     // データテーブル表示する設定
                browserComb.ValueMember   = "Code";                     // コード
                browserComb.DisplayMember = "Name";                     // 表示名
                browserComb.SelectedIndex = 0;                          // 初期値設定
            }
            // 勤務場所選択用コンボボックス設定
            {
                // 勤務データ
                DataTable dt = new DataTable();
                dt.Columns.Add("Code", typeof(String));     // コード
                dt.Columns.Add("Name", typeof(String));     // 表示名

                // データ作成(変更があるたびに修正が必要になるので修正しないようにしたい)
                dt.Rows.Add("", "");
                dt.Rows.Add("a2210000005Lyp8AAC", "派遣先勤務");
                dt.Rows.Add("a2210000005LypDAAS", "在宅勤務");
                dt.Rows.Add("a2210000005LypIAAS", "本社・支店勤務");

                // 変更をコミット
                dt.AcceptChanges();

                // コンボボックス設定
                workPlaceComb.DataSource    = dt;           // データテーブル表示する設定
                workPlaceComb.ValueMember   = "Code";       // コード
                workPlaceComb.DisplayMember = "Name";       // 表示名
                workPlaceComb.SelectedIndex = 0;            // 初期値設定
            }
        }

        /// <summary>
        /// 戻るボタン(フォームを閉じる)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool TimeTextFormatCheng(TextBox tb)
        {
            // テキストボックスの背景を戻す。
            tb.BackColor = Color.White;

            // 空白
            if(tb.Text == "")
            {
                return true;
            }
            
            // 形式チェック(99:59 or 9:59)
            else if (Regex.IsMatch(tb.Text, timeFormatCheckRegexp))
            {
                tb.Text = tb.Text.Replace(":", "");
                // 文字列→数字変換
                int result = 0;
                if (int.TryParse(tb.Text, out result))
                {
                    // 時間形式に修正
                    tb.Text = result.ToString("00:00");
                    return true;
                }
            }
            // 形式チェック(9959 or 959)
            else if (Regex.IsMatch(tb.Text, timeNumberCheckRegexp))
            {
                // 文字列→数字変換
                int result = 0;
                if (int.TryParse(tb.Text, out result)) {
                    // 時間形式に修正
                    tb.Text = result.ToString("00:00");
                    return true;
                }
            }

            // エラーとなったテクストボックスの色を変更する。
            tb.BackColor = Color.Red;
            
            return false;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TimeTextFormatCheng((TextBox)sender);
        }

        /// <summary>
        /// 保存ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // テキストボックスのバックカラーを白に変更
            userText.BackColor           = Color.White;
            passText.BackColor           = Color.White;
            startTimeText.BackColor      = Color.White;
            endTimeText.BackColor        = Color.White;
            restStartTime1Text.BackColor = Color.White;
            restEndTime1Text.BackColor   = Color.White;
            restStartTime2Text.BackColor = Color.White;
            restEndTime2Text.BackColor   = Color.White;

            // ユーザ名
            if (userText.Text != "")
            {
                setValues.userName = userText.Text;
            } else
            {

            }

            // パスワード
            setValues.password   = passText.Text;
            // 出勤
            setValues.startTime  = startTimeText.Text;
            // 退勤
            setValues.endTime    = endTimeText.Text;
            // 休憩１開始
            setValues.startRest1 = restStartTime1Text.Text;
            // 休憩１終了
            setValues.endRest1   = restEndTime1Text.Text;
            // 休憩２開始
            setValues.startRest2 = restStartTime2Text.Text;
            // 休憩２終了
            setValues.endRest2   = restEndTime2Text.Text;
            // 勤務場所
            if (workPlaceComb.SelectedValue != null)
            {
                setValues.workPlace
                    = workPlaceComb.SelectedValue.ToString();
            }

            // ブラウザ
            int browser;
            int.TryParse(browserComb.SelectedValue.ToString(), out browser);
            setValues.browserType = (Settings.BrowserType) browser;

            setValues.isData = true;

            // 保存
            setValues.Save();

            // フォームを閉じる
            this.Close();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
