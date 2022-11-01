using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Windows.Forms;
using static DevExpress.Utils.Svg.CommonSvgImages;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WebDataSciencer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool isSummaryAdded = false;

        List<PersonComment> GetData(string link)
        {
            var resultList = new List<PersonComment>();

            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string htmlString = client.DownloadString(link);

            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.OptionFixNestedTags = true;
            doc.LoadHtml(htmlString);

            for (int i = 2; i < 12; i++)
            {
                var personComment = new PersonComment();

                var nameNode = doc.DocumentNode.SelectSingleNode($"//*[@id=\"main\"]/div[2]/div/div[2]/div[2]/div[{i}]/div/div[2]/div/div[1]/div[1]/strong");
                if (nameNode != null)
                {
                    personComment.Name = nameNode.InnerText.Trim();
                }

                var ageNode = doc.DocumentNode.SelectSingleNode($"//*[@id=\"main\"]/div[2]/div/div[2]/div[2]/div[{i}]/div/div[2]/div/div[1]/div[1]/span[1]");
                if (ageNode != null)
                {
                    personComment.Age = Convert.ToInt32(ageNode.InnerText.Trim().Replace("&middot;&nbsp;", ""));
                }

                var cityNode = doc.DocumentNode.SelectSingleNode($"//*[@id=\"main\"]/div[2]/div/div[2]/div[2]/div[{i}]/div/div[2]/div/div[1]/div[1]/span[2]");
                if (cityNode != null)
                {
                    personComment.City = cityNode.InnerText.Trim().Replace("&middot;&nbsp;", "");
                }

                var commentTimeNode = doc.DocumentNode.SelectSingleNode($"//*[@id=\"main\"]/div[2]/div/div[2]/div[2]/div[{i}]/div/div[2]/div/div[1]/div[2]/span[1]");
                if (commentTimeNode != null)
                {
                    personComment.CommentTime = commentTimeNode.InnerText.Trim();
                }
                var commentNode = doc.DocumentNode.SelectSingleNode($"//*[@id=\"main\"]/div[2]/div/div[2]/div[2]/div[{i}]/div/div[2]/div/div[2]");
                if (commentNode != null)
                {
                    string textNode = "";
                    bool isNextTextNode = false;
                    foreach (var item in commentNode.ChildNodes)
                    {
                        if (isNextTextNode)
                        {
                            textNode = item.InnerText.Trim();
                            break;
                        }

                        if (item.Name == "br")
                        {
                            isNextTextNode = true;
                        }
                    }
                    personComment.Comment = textNode;
                }
                resultList.Add(personComment);
            }
            return resultList;
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            try
            {
                var linkText = tbLink.Text;
                var pageCount = Convert.ToInt32(tbPage.EditValue);

                var pageText = "sayfa=";

                var onlyLinkTextIndex = linkText.LastIndexOf(pageText, StringComparison.InvariantCultureIgnoreCase) + 6;

                var onlyLinkText = linkText.Substring(0, onlyLinkTextIndex);
                var pageNumber = Convert.ToInt32(linkText.Substring(onlyLinkTextIndex, (linkText.Length - onlyLinkText.Length)));

                var personCommentList = new List<PersonComment>();

                for (int pi = pageNumber; pi <= pageCount; pi++)
                {
                    var list = GetData(onlyLinkText + pi.ToString());
                    personCommentList.AddRange(list);
                }

                gridControl1.DataSource = personCommentList;

                if (personCommentList.Count > 0)
                {
                    gridView1.Columns["Name"].Width = 110;
                    gridView1.Columns["Age"].Width = 80;
                    gridView1.Columns["City"].Width = 90;
                    gridView1.Columns["CommentTime"].Width = 120;
                }

                if (!isSummaryAdded)
                {
                    AddSummary(gridView1, "Name", "Toplam", DevExpress.Data.SummaryItemType.Count);
                    isSummaryAdded = true;
                }

                GetComment();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbLink.Text = @"https://denebunu.com/product/lipton-tek-dem-classic-19-gr/?o=auto&sayfa=1";
        }

        void GetComment()
        {
            if (gridView1.GetFocusedRow() is PersonComment model)
            {
                if (model != null)
                {
                    memComment.Text = model.Comment;
                }
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GetComment();
        }

        readonly static string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        static public void AddSummary(GridView grid, string column, string caption, SummaryItemType type)
        {
            if (grid.RowCount > 0)
            {
                grid.OptionsView.ShowFooter = true;
                GridColumnSummaryItem item = new GridColumnSummaryItem(type, column, caption + ": {0}");
                grid.Columns[column].Summary.Add(item);
            }
        }

        static public bool Excelx(GridControl grid, string file)
        {
            if (grid.DefaultView.RowCount < 1)
            {
                XtraMessageBox.Show("Liste boş.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            try
            {
                string fileExtension = ".xlsx";
                string exportFile = filePath + "\\" + file + fileExtension;
                grid.ExportToXlsx(exportFile);
                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($" {file} dosyası kaydedilemedi." + Environment.NewLine + ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            var fileName = $"{now.ToString("ddMMyyyy HHmmss")} - Yorum Listesi";
            if (Excelx(gridControl1, fileName))
            {
                XtraMessageBox.Show($"Masaüstüne {fileName} excel dosyası oluşturulmuştur.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
