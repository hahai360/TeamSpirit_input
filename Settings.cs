using System;
using System.Data;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace TeamSprit_input
{
    [Serializable]
    public class Settings
    {
        #region 定数
        // 保存関連
        private const String FileName = "dt";
        #endregion 定数

        #region enum
        // ブラウザ種別
        public enum BrowserType
        {
            Edge,
            Chrome,
            FireFox
        }
        #endregion enum

        #region メンバー
        // 設定情報
        public String userName { get; set; }         = "";                  // ユーザ名
        public String password { get; set; }         = "";                  // パスワード
        public String date { get; set; }             = "";                  // 日付
        public String startTime { get; set; }        = "";                  // 出勤
        public String endTime { get; set; }          = "";                  // 退勤
        public String startRest1 { get; set; }       = "";                  // 休憩開始１
        public String endRest1 { get; set; }         = "";                  // 休憩終了１
        public String startRest2 { get; set; }       = "";                  // 休憩開始２
        public String endRest2 { get; set; }         = "";                  // 休憩終了２
        public String workPlace { get; set; }        = "";                  // 勤務場所
        public bool isData { get; set; }             = false;               // データが正常に入っているか
        public BrowserType browserType { get; set; } = BrowserType.Edge;    // ブラウザ
        #endregion メンバー

        #region コンストラクタ
        public Settings() 
        {
 
        }
        #endregion コンストラクタ

        #region メソッド
        /// <summary>
        /// 簡易コピー
        /// </summary>
        /// <returns></returns>
        public Settings Clone()
        {
            return (Settings)MemberwiseClone();
        }

        
        /// <summary>
        /// ブラウザの種別を作成
        /// </summary>
        /// <returns></returns>
        public static DataTable BrowserData()
        {
            // ブラウザ
            DataTable dt = new DataTable();
            dt.Columns.Add("Code", typeof(String));     // コード
            dt.Columns.Add("Name", typeof(String));     // 表示名

            // データセットへブラウザ情報を設定
            foreach(BrowserType browser in Enum.GetValues(typeof(BrowserType)))
            {
                dt.Rows.Add(
                        (int) browser,
                        Enum.GetName(typeof(BrowserType), browser)
                    );
            }

            // 変更をコミット
            dt.AcceptChanges();

            return dt;
        }
        #endregion メソッド

        #region 設定情報の保存・読込関連
        /// <summary>
        /// 設定情報をファイルに保存
        /// </summary>
        public void Save()
        {
            using (FileStream fs = new FileStream(FileName, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, this);
            }
        }

        /// <summary>
        /// 設定情報をファイルから読込
        /// </summary>
        public void Load()
        {
            // ファイルの存在チェック
            if ( ! File.Exists(FileName))
            {
                isData = false;
                return;
            }

            using (FileStream fs = new FileStream(FileName, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Settings temp = (Settings)formatter.Deserialize(fs);

                // リフレクションを使用してメンバーの値を一括でコピーする
                foreach (PropertyInfo prop in typeof(Settings).GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    if (prop.CanWrite)
                    {
                        prop.SetValue(this, prop.GetValue(temp));
                    }
                }
            }
        }
        #endregion 設定情報の保存・読込関連
    }
}
