namespace WebDataSciencer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnGetData = new DevExpress.XtraEditors.SimpleButton();
            this.tbLink = new DevExpress.XtraEditors.TextEdit();
            this.memComment = new DevExpress.XtraEditors.MemoEdit();
            this.lbComment = new DevExpress.XtraEditors.LabelControl();
            this.btnExportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tbPage = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLink.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPage.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControl1.Location = new System.Drawing.Point(10, 40);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(791, 436);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.FilterCriteriaDisplayStyle = DevExpress.XtraEditors.FilterCriteriaDisplayStyle.Text;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(627, 13);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(86, 23);
            this.btnGetData.TabIndex = 1;
            this.btnGetData.Text = "Yorumları Getir";
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(34, 15);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(420, 20);
            this.tbLink.TabIndex = 2;
            // 
            // memComment
            // 
            this.memComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memComment.Location = new System.Drawing.Point(807, 39);
            this.memComment.Name = "memComment";
            this.memComment.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.memComment.Properties.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.memComment.Properties.Appearance.Options.UseFont = true;
            this.memComment.Properties.Appearance.Options.UseForeColor = true;
            this.memComment.Properties.ReadOnly = true;
            this.memComment.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.memComment.Size = new System.Drawing.Size(284, 437);
            this.memComment.TabIndex = 3;
            // 
            // lbComment
            // 
            this.lbComment.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbComment.Appearance.Options.UseFont = true;
            this.lbComment.Location = new System.Drawing.Point(807, 18);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(47, 16);
            this.lbComment.TabIndex = 4;
            this.lbComment.Text = "Yorum:";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(719, 13);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(82, 23);
            this.btnExportExcel.TabIndex = 5;
            this.btnExportExcel.Text = "Excele Aktar";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(18, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Link";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(460, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(111, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Kaçıncı Sayfaya Kadar?";
            // 
            // tbPage
            // 
            this.tbPage.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbPage.Location = new System.Drawing.Point(577, 15);
            this.tbPage.Name = "tbPage";
            this.tbPage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.tbPage.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.tbPage.Properties.IsFloatValue = false;
            this.tbPage.Properties.MaskSettings.Set("mask", "N00");
            this.tbPage.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tbPage.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbPage.Size = new System.Drawing.Size(44, 20);
            this.tbPage.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 488);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.lbComment);
            this.Controls.Add(this.memComment);
            this.Controls.Add(this.tbLink);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.tbPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeneBunu.com Web Data Sciencer v01";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLink.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPage.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnGetData;
        private DevExpress.XtraEditors.TextEdit tbLink;
        private DevExpress.XtraEditors.MemoEdit memComment;
        private DevExpress.XtraEditors.LabelControl lbComment;
        private DevExpress.XtraEditors.SimpleButton btnExportExcel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit tbPage;
    }
}

