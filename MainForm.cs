using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace TeamSprit_input
{
    public partial class MainForm : Form
    {
        #region 定数
        // 年月関連
        private const int MinMonth = -1; // 最小月
        private const int MaxMonth = 2;  // 最大月

        // フォーマット関連
        private const String CodeDateFormat = "yyyyMM01";       // コード用フォーマット
        private const String DisplayDateFormat = "yyyy年MM月";  // 表示日時要フォーマット

        // 入力ウィンドウの接頭辞、接尾辞
        private const String inputPrefix = "ttvTimeSt";
        private const String inputSuffix = "";
        #endregion 定数

        #region メンバー
        private Settings _settings = new Settings();
        #endregion メンバー

        #region コンストラクタ
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion コンストラクタ

        #region フォームイベント
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // 年月コンボボックスの初期化
            InitDateComb();

            // 設定ファイルを読込
            _settings.Load();

            // ユーザID、パスワードが設定されている場合はイベント終了する。
            if (_settings.isData)
            {
                return;
            }

            // 設定画面を表示する。
            SettingForm settingForm = new SettingForm(true, _settings);
            settingForm.ShowDialog();
            _settings = settingForm.setValues.Clone();

            // データが入っていはい場合は終了する
            if (! _settings.isData)
            {
                this.Close();
            }

        }
        #endregion フォームイベント

        #region ボタンイベント
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm(false, _settings);
            settingForm.ShowDialog();
            _settings = settingForm.setValues.Clone();
        }

        /// <summary>
        /// Seleniumを動作させる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScheduleRegisterButton_Click(object sender, EventArgs e)
        {
            _settings.date = dateComb.SelectedValue.ToString();

            IWebDriver driver;

            switch (_settings.browserType)
            {
                case Settings.BrowserType.Edge:
                    driver = new EdgeDriver();
                    break;
                case Settings.BrowserType.Chrome:
                    driver = new ChromeDriver();
                    break;
                case Settings.BrowserType.FireFox:
                    driver = new FirefoxDriver();
                    break;
                default:
                    return;
            }

            Selenium(driver);
        }
        #endregion ボタンイベント

        #region コンボボックス関連
        /// <summary>
        /// コンボボックスの初期化を行う。
        /// </summary>
        private void InitDateComb()
        {
            // 日付取得
            var date = DateTime.Now;

            // コンボボックス用の値作成(現在の月の+2ヶ月 ～ -１ヶ月)
            DataTable dt = new DataTable();
            dt.Columns.Add("Code", typeof(String));     // コード
            dt.Columns.Add("Name", typeof(String));     // 表示名
            
            // 日付データ作成
            for (var i = MinMonth; i <= MaxMonth; i++)
            {
                dt.Rows.Add(date.AddMonths(i).ToString(CodeDateFormat),     // コード
                            date.AddMonths(i).ToString(DisplayDateFormat)); // 表示名
            }

            // 変更をコミット
            dt.AcceptChanges();

            // コンボボック設定
            dateComb.DataSource = dt;                               // データテーブル表示する設定
            dateComb.ValueMember = "Code";                          // コード
            dateComb.DisplayMember = "Name";                        // 表示名
            dateComb.SelectedValue = date.ToString(CodeDateFormat); // 初期値設定
        }
        #endregion コンボボックス関連

        #region ブラウザ操作関連
        /// <summary>
        /// Selenium操作処理
        /// </summary>
        private void Selenium(IWebDriver driver)
        {

            // タイムアウトを長めに設定しないと以下処理で「オブジェクトがない」とエラーとなる。
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            // サイトにアクセス
            driver.Navigate().GoToUrl("https://teamspirit-385.my.salesforce.com");

            // 「次を使用してログイン Okta」をクリック
            driver.FindElement(By.Id("idp_section_buttons")).Click();

            // ユーザIDを入力する。
            Thread.Sleep(5000);
            driver.FindElement(By.Id("input28")).SendKeys(_settings.userName);
            driver.FindElement(By.ClassName("button")).Click();

            // パスワードを入力する。
            driver.FindElement(By.Id("input60")).SendKeys(_settings.password);
            driver.FindElement(By.ClassName("button")).Click();

            // 「勤怠表」をクリック
            driver.FindElement(By.LinkText("勤務表")).Click();

            // 入力年月確認
            {
                var element = driver.FindElement(By.Id("yearMonthList"));
                var select = new SelectElement(element);

                select.SelectByValue(_settings.date);
            }

            // 予定を入力
            var inputDate = DateTime.ParseExact(_settings.date, "yyyyMMdd", null);
            var startDate = new DateTime(inputDate.Year, inputDate.Month, 1);
            var endDate   = startDate.AddMonths(1).AddDays(-1);

            Thread.Sleep(3000);

            // 月初～月末まで入力
            while (startDate <= endDate)
            {
                // タイムアウトを設定する。
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

                // オブジェクト存在チェック
                if (driver.FindElements(By.Id(inputPrefix + startDate.ToString("yyyy-MM-dd") + inputSuffix)).Count <= 0)
                {
                    // オブジェクトがない場合は次の日に移動する。
                    startDate = startDate.AddDays(1);
                    continue;                    
                }

                // 入力ウィンドウを開く。
                driver.FindElement(By.Id(inputPrefix + startDate.ToString("yyyy-MM-dd") + inputSuffix)).Click();

                // 既設定をクリアするフラグがオンの場合
                if (isClearCheck.Checked)
                {
                    // タイムアウトを設定する。
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

                    // クリアボタンをクリック
                    driver.FindElement(By.Id("dlgInpTimeReset")).Click();
                    // 確認OK
                    driver.FindElement(By.Id("confirmAlertOk")).Click();
                    // 登録ボタンクリック
                    driver.FindElement(By.Id("dlgInpTimeOk")).Click();
                    driver.FindElement(By.Id("messageBoxOk")).Click();
                    
                    // 日付を１日進める。
                    startDate = startDate.AddDays(1);
                    Thread.Sleep(4000);
                    continue;
                }


                // 出勤入力
                if (_settings.startTime != "")
                {
                    driver.FindElement(By.Id("startTime")).Clear();
                    driver.FindElement(By.Id("startTime")).SendKeys(_settings.startTime);
                }

                // 退勤入力
                if (_settings.endTime != "")
                {
                    driver.FindElement(By.Id("endTime")).Clear();
                    driver.FindElement(By.Id("endTime")).SendKeys(_settings.endTime);
                }

                // 休憩１入力
                if (_settings.startRest1 != "" && _settings.endRest1 != "")
                {
                    driver.FindElement(By.Id("startRest1")).Clear();
                    driver.FindElement(By.Id("endRest1")).Clear();
                    driver.FindElement(By.Id("startRest1")).SendKeys(_settings.startRest1);
                    driver.FindElement(By.Id("endRest1")).SendKeys(_settings.endRest1);
                }

                // 休憩２入力
                if (_settings.startRest2 != "" && _settings.endRest2 != "")
                {
                    driver.FindElement(By.Id("startRest2")).Clear();
                    driver.FindElement(By.Id("endRest2")).Clear();
                    driver.FindElement(By.Id("startRest2")).SendKeys(_settings.startRest2);
                    driver.FindElement(By.Id("endRest2")).SendKeys(_settings.endRest2);
                }

                // 勤務場所入力
                if (_settings.workPlace != "")
                {
                    var workElement = driver.FindElement(By.Id("workLocationId"));
                    var select = new SelectElement(workElement);
                    select.SelectByValue(_settings.workPlace);
                }

                // 登録ボタンクリック
                driver.FindElement(By.Id("dlgInpTimeOk")).Click();

                // 日付を１日進める。
                startDate = startDate.AddDays(1);

                Thread.Sleep(4000);
            }

            // 処理終了時のメッセージ
            MessageBox.Show("処理成功したかな？(*´∀｀*)\r\n" +
                            "確認して成功していなかったら管理者へ連絡！(´Д｀)ﾊｧ…\r\n" +
                            "軽微な修正で終わるなら手動で修正してね(ToT)");

            // ブラウザ終了
            driver.Quit();

        }
        #endregion ブラウザ操作関連
    }
}
