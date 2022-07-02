
namespace QLNHANSU.TINHLUONG
{
    partial class frmBangLuong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBangLuong));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.btnTinhLuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.btnXemBangLuong = new DevExpress.XtraEditors.SimpleButton();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAKYCONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDNV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTENNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KHONGPHEP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYCONGTRONGTHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYPHEP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYCHUNHAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYTHUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TANGCA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PHUCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UNGLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THUCLANH = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4,
            this.bar5});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTinhLuong,
            this.btnDong,
            this.btnIn});
            this.barManager1.MainMenu = this.bar4;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar5;
            // 
            // bar4
            // 
            this.bar4.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.bar4.BarAppearance.Normal.Options.UseFont = true;
            this.bar4.BarAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 12F);
            this.bar4.BarAppearance.Pressed.Options.UseFont = true;
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTinhLuong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Caption = "Tính lương ";
            this.btnTinhLuong.Id = 0;
            this.btnTinhLuong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTinhLuong.ImageOptions.Image")));
            this.btnTinhLuong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTinhLuong.ImageOptions.LargeImage")));
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTinhLuong_ItemClick);
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Id = 6;
            this.btnIn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIn.ImageOptions.SvgImage")));
            this.btnIn.Name = "btnIn";
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 4;
            this.btnDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDong.ImageOptions.SvgImage")));
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // bar5
            // 
            this.bar5.BarName = "Status bar";
            this.bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar5.OptionsBar.AllowQuickCustomization = false;
            this.bar5.OptionsBar.DrawDragBorder = false;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1355, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 599);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1355, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 573);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1355, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 573);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 26);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cboThang);
            this.splitContainer1.Panel1.Controls.Add(this.btnXemBangLuong);
            this.splitContainer1.Panel1.Controls.Add(this.cboNam);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(1355, 573);
            this.splitContainer1.SplitterDistance = 76;
            this.splitContainer1.TabIndex = 11;
            // 
            // cboThang
            // 
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboThang.Location = new System.Drawing.Point(264, 23);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(121, 21);
            this.cboThang.TabIndex = 9;
            // 
            // btnXemBangLuong
            // 
            this.btnXemBangLuong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXemBangLuong.ImageOptions.Image")));
            this.btnXemBangLuong.Location = new System.Drawing.Point(404, 19);
            this.btnXemBangLuong.Name = "btnXemBangLuong";
            this.btnXemBangLuong.Size = new System.Drawing.Size(117, 27);
            this.btnXemBangLuong.TabIndex = 8;
            this.btnXemBangLuong.Text = "Xem bảng lương ";
            this.btnXemBangLuong.Click += new System.EventHandler(this.btnXemBangLuong_Click);
            // 
            // cboNam
            // 
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cboNam.Location = new System.Drawing.Point(90, 22);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(121, 21);
            this.cboNam.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(217, 24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Tháng:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(53, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Năm:";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1355, 493);
            this.gcDanhSach.TabIndex = 0;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.MAKYCONG,
            this.IDNV1,
            this.HOTENNV,
            this.KHONGPHEP,
            this.NGAYCONGTRONGTHANG,
            this.NGAYPHEP,
            this.NGAYLE,
            this.NGAYCHUNHAT,
            this.NGAYTHUONG,
            this.TANGCA,
            this.PHUCAP,
            this.UNGLUONG,
            this.THUCLANH});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ID.AppearanceHeader.Options.UseFont = true;
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.MaxWidth = 90;
            this.ID.MinWidth = 90;
            this.ID.Name = "ID";
            this.ID.Width = 90;
            // 
            // MAKYCONG
            // 
            this.MAKYCONG.AppearanceCell.Options.UseTextOptions = true;
            this.MAKYCONG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MAKYCONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.MAKYCONG.AppearanceHeader.Options.UseFont = true;
            this.MAKYCONG.Caption = "KỲ CÔNG";
            this.MAKYCONG.FieldName = "MAKYCONG";
            this.MAKYCONG.MaxWidth = 60;
            this.MAKYCONG.MinWidth = 60;
            this.MAKYCONG.Name = "MAKYCONG";
            this.MAKYCONG.Visible = true;
            this.MAKYCONG.VisibleIndex = 0;
            this.MAKYCONG.Width = 60;
            // 
            // IDNV1
            // 
            this.IDNV1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.IDNV1.AppearanceHeader.Options.UseFont = true;
            this.IDNV1.Caption = "ID";
            this.IDNV1.FieldName = "MANV";
            this.IDNV1.MaxWidth = 30;
            this.IDNV1.MinWidth = 30;
            this.IDNV1.Name = "IDNV1";
            this.IDNV1.Visible = true;
            this.IDNV1.VisibleIndex = 1;
            this.IDNV1.Width = 30;
            // 
            // HOTENNV
            // 
            this.HOTENNV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.HOTENNV.AppearanceHeader.Options.UseFont = true;
            this.HOTENNV.Caption = "HỌ TÊN";
            this.HOTENNV.FieldName = "HOTEN";
            this.HOTENNV.MaxWidth = 200;
            this.HOTENNV.MinWidth = 50;
            this.HOTENNV.Name = "HOTENNV";
            this.HOTENNV.Visible = true;
            this.HOTENNV.VisibleIndex = 2;
            this.HOTENNV.Width = 200;
            // 
            // KHONGPHEP
            // 
            this.KHONGPHEP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.KHONGPHEP.AppearanceHeader.Options.UseFont = true;
            this.KHONGPHEP.Caption = "KHÔNG PHÉP";
            this.KHONGPHEP.DisplayFormat.FormatString = "n0";
            this.KHONGPHEP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.KHONGPHEP.FieldName = "KHONGPHEP";
            this.KHONGPHEP.MaxWidth = 100;
            this.KHONGPHEP.MinWidth = 100;
            this.KHONGPHEP.Name = "KHONGPHEP";
            this.KHONGPHEP.Visible = true;
            this.KHONGPHEP.VisibleIndex = 4;
            this.KHONGPHEP.Width = 100;
            // 
            // NGAYCONGTRONGTHANG
            // 
            this.NGAYCONGTRONGTHANG.AppearanceCell.Options.UseTextOptions = true;
            this.NGAYCONGTRONGTHANG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAYCONGTRONGTHANG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.NGAYCONGTRONGTHANG.AppearanceHeader.Options.UseFont = true;
            this.NGAYCONGTRONGTHANG.Caption = "NGÀY CÔNG";
            this.NGAYCONGTRONGTHANG.DisplayFormat.FormatString = "n0";
            this.NGAYCONGTRONGTHANG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NGAYCONGTRONGTHANG.FieldName = "NGAYCONGTRONGTHANG";
            this.NGAYCONGTRONGTHANG.MaxWidth = 80;
            this.NGAYCONGTRONGTHANG.MinWidth = 80;
            this.NGAYCONGTRONGTHANG.Name = "NGAYCONGTRONGTHANG";
            this.NGAYCONGTRONGTHANG.Visible = true;
            this.NGAYCONGTRONGTHANG.VisibleIndex = 3;
            this.NGAYCONGTRONGTHANG.Width = 80;
            // 
            // NGAYPHEP
            // 
            this.NGAYPHEP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.NGAYPHEP.AppearanceHeader.Options.UseFont = true;
            this.NGAYPHEP.Caption = "NGÀY PHÉP";
            this.NGAYPHEP.DisplayFormat.FormatString = "n0";
            this.NGAYPHEP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.NGAYPHEP.FieldName = "NGAYPHEP";
            this.NGAYPHEP.MaxWidth = 100;
            this.NGAYPHEP.MinWidth = 100;
            this.NGAYPHEP.Name = "NGAYPHEP";
            this.NGAYPHEP.Visible = true;
            this.NGAYPHEP.VisibleIndex = 5;
            this.NGAYPHEP.Width = 100;
            // 
            // NGAYLE
            // 
            this.NGAYLE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.NGAYLE.AppearanceHeader.Options.UseFont = true;
            this.NGAYLE.Caption = "NGÀY LỄ";
            this.NGAYLE.DisplayFormat.FormatString = "n0";
            this.NGAYLE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NGAYLE.FieldName = "NGAYLE";
            this.NGAYLE.MaxWidth = 100;
            this.NGAYLE.MinWidth = 100;
            this.NGAYLE.Name = "NGAYLE";
            this.NGAYLE.Visible = true;
            this.NGAYLE.VisibleIndex = 6;
            this.NGAYLE.Width = 100;
            // 
            // NGAYCHUNHAT
            // 
            this.NGAYCHUNHAT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.NGAYCHUNHAT.AppearanceHeader.Options.UseFont = true;
            this.NGAYCHUNHAT.Caption = "CHỦ NHẬT";
            this.NGAYCHUNHAT.DisplayFormat.FormatString = "n0";
            this.NGAYCHUNHAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.NGAYCHUNHAT.FieldName = "NGAYCHUNHAT";
            this.NGAYCHUNHAT.MaxWidth = 100;
            this.NGAYCHUNHAT.MinWidth = 100;
            this.NGAYCHUNHAT.Name = "NGAYCHUNHAT";
            this.NGAYCHUNHAT.Visible = true;
            this.NGAYCHUNHAT.VisibleIndex = 7;
            this.NGAYCHUNHAT.Width = 100;
            // 
            // NGAYTHUONG
            // 
            this.NGAYTHUONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.NGAYTHUONG.AppearanceHeader.Options.UseFont = true;
            this.NGAYTHUONG.Caption = "NGÀY THƯỜNG";
            this.NGAYTHUONG.DisplayFormat.FormatString = "n0";
            this.NGAYTHUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.NGAYTHUONG.FieldName = "NGAYTHUONG";
            this.NGAYTHUONG.MaxWidth = 100;
            this.NGAYTHUONG.MinWidth = 100;
            this.NGAYTHUONG.Name = "NGAYTHUONG";
            this.NGAYTHUONG.Visible = true;
            this.NGAYTHUONG.VisibleIndex = 8;
            this.NGAYTHUONG.Width = 100;
            // 
            // TANGCA
            // 
            this.TANGCA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TANGCA.AppearanceHeader.Options.UseFont = true;
            this.TANGCA.Caption = "TĂNG CA";
            this.TANGCA.DisplayFormat.FormatString = "n0";
            this.TANGCA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TANGCA.FieldName = "TANGCA";
            this.TANGCA.MaxWidth = 100;
            this.TANGCA.MinWidth = 100;
            this.TANGCA.Name = "TANGCA";
            this.TANGCA.Visible = true;
            this.TANGCA.VisibleIndex = 9;
            this.TANGCA.Width = 100;
            // 
            // PHUCAP
            // 
            this.PHUCAP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.PHUCAP.AppearanceHeader.Options.UseFont = true;
            this.PHUCAP.Caption = "PHỤ CẤP";
            this.PHUCAP.DisplayFormat.FormatString = "n0";
            this.PHUCAP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PHUCAP.FieldName = "PHUCAP";
            this.PHUCAP.MaxWidth = 100;
            this.PHUCAP.MinWidth = 100;
            this.PHUCAP.Name = "PHUCAP";
            this.PHUCAP.Visible = true;
            this.PHUCAP.VisibleIndex = 10;
            this.PHUCAP.Width = 100;
            // 
            // UNGLUONG
            // 
            this.UNGLUONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.UNGLUONG.AppearanceHeader.Options.UseFont = true;
            this.UNGLUONG.Caption = "ỨNG LƯƠNG ";
            this.UNGLUONG.DisplayFormat.FormatString = "n0";
            this.UNGLUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.UNGLUONG.FieldName = "UNGLUONG";
            this.UNGLUONG.MaxWidth = 100;
            this.UNGLUONG.MinWidth = 100;
            this.UNGLUONG.Name = "UNGLUONG";
            this.UNGLUONG.Visible = true;
            this.UNGLUONG.VisibleIndex = 11;
            this.UNGLUONG.Width = 100;
            // 
            // THUCLANH
            // 
            this.THUCLANH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.THUCLANH.AppearanceHeader.Options.UseFont = true;
            this.THUCLANH.Caption = "THỰC LÃNH";
            this.THUCLANH.DisplayFormat.FormatString = "n0";
            this.THUCLANH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.THUCLANH.FieldName = "THUCLANH";
            this.THUCLANH.MaxWidth = 100;
            this.THUCLANH.MinWidth = 100;
            this.THUCLANH.Name = "THUCLANH";
            this.THUCLANH.Visible = true;
            this.THUCLANH.VisibleIndex = 12;
            this.THUCLANH.Width = 100;
            // 
            // frmBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 619);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBangLuong";
            this.Text = "Bảng lương ";
            this.Load += new System.EventHandler(this.frmBangLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem btnTinhLuong;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cboNam;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn MAKYCONG;
        private DevExpress.XtraGrid.Columns.GridColumn HOTENNV;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYCONGTRONGTHANG;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYPHEP;
        private DevExpress.XtraGrid.Columns.GridColumn IDNV1;
        private DevExpress.XtraEditors.SimpleButton btnXemBangLuong;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYLE;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYCHUNHAT;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYTHUONG;
        private DevExpress.XtraGrid.Columns.GridColumn TANGCA;
        private DevExpress.XtraGrid.Columns.GridColumn PHUCAP;
        private DevExpress.XtraGrid.Columns.GridColumn THUCLANH;
        private DevExpress.XtraGrid.Columns.GridColumn UNGLUONG;
        private System.Windows.Forms.ComboBox cboThang;
        private DevExpress.XtraGrid.Columns.GridColumn KHONGPHEP;
    }
}