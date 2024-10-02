namespace NET_SE310.P12_ProductManagement
{
    partial class ProdMng
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            prodInfoGrBx = new GroupBox();
            delProdBtn = new Button();
            saveProdBtn = new Button();
            expDLbl = new Label();
            expDDatePicker = new DateTimePicker();
            originLbl = new Label();
            OriginTxtBx = new TextBox();
            unitPriceLbl = new Label();
            unitPriceTxtBx = new TextBox();
            qttLbl = new Label();
            QttTxtBx = new TextBox();
            prodNameTxtBx = new TextBox();
            prodNameLbl = new Label();
            prodIDTxtBx = new TextBox();
            prodIDLbl = new Label();
            prodMngGrBxTltLbl = new Label();
            toolTip1 = new ToolTip(components);
            prodFilterGrBx = new GroupBox();
            maxUPRFilterTxtBx = new TextBox();
            minUPRFilterTxtBx = new TextBox();
            pbupFilterBtn = new Button();
            epFilterBtn = new Button();
            jppFilterBtn = new Button();
            huppFilterBtn = new Button();
            productFilterDataGridView = new DataGridView();
            prodFilterGrBxTltLbl = new Label();
            groupBox2 = new GroupBox();
            funcGrBx = new GroupBox();
            delExpProdBtn = new Button();
            delAllProdBtn = new Button();
            expDateProdValidateBtn = new Button();
            spcOriProdTxtBx = new TextBox();
            delOriProdBtn = new Button();
            funcGrBxTltLbl = new Label();
            importedProductDataGridView = new DataGridView();
            impProdGrBxTltLbl = new Label();
            prodInfoGrBx.SuspendLayout();
            prodFilterGrBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productFilterDataGridView).BeginInit();
            groupBox2.SuspendLayout();
            funcGrBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)importedProductDataGridView).BeginInit();
            SuspendLayout();
            // 
            // prodInfoGrBx
            // 
            prodInfoGrBx.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            prodInfoGrBx.Controls.Add(delProdBtn);
            prodInfoGrBx.Controls.Add(saveProdBtn);
            prodInfoGrBx.Controls.Add(expDLbl);
            prodInfoGrBx.Controls.Add(expDDatePicker);
            prodInfoGrBx.Controls.Add(originLbl);
            prodInfoGrBx.Controls.Add(OriginTxtBx);
            prodInfoGrBx.Controls.Add(unitPriceLbl);
            prodInfoGrBx.Controls.Add(unitPriceTxtBx);
            prodInfoGrBx.Controls.Add(qttLbl);
            prodInfoGrBx.Controls.Add(QttTxtBx);
            prodInfoGrBx.Controls.Add(prodNameTxtBx);
            prodInfoGrBx.Controls.Add(prodNameLbl);
            prodInfoGrBx.Controls.Add(prodIDTxtBx);
            prodInfoGrBx.Controls.Add(prodIDLbl);
            prodInfoGrBx.Controls.Add(prodMngGrBxTltLbl);
            prodInfoGrBx.Font = new Font("San Francisco Display Light", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prodInfoGrBx.Location = new Point(11, 12);
            prodInfoGrBx.Name = "prodInfoGrBx";
            prodInfoGrBx.Size = new Size(417, 450);
            prodInfoGrBx.TabIndex = 0;
            prodInfoGrBx.TabStop = false;
            // 
            // delProdBtn
            // 
            delProdBtn.Font = new Font("San Francisco Display Bold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delProdBtn.Location = new Point(308, 282);
            delProdBtn.Name = "delProdBtn";
            delProdBtn.Size = new Size(103, 34);
            delProdBtn.TabIndex = 14;
            delProdBtn.Text = "Delete";
            delProdBtn.UseVisualStyleBackColor = true;
            // 
            // saveProdBtn
            // 
            saveProdBtn.BackColor = SystemColors.Control;
            saveProdBtn.Font = new Font("San Francisco Display Bold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveProdBtn.Location = new Point(148, 283);
            saveProdBtn.Name = "saveProdBtn";
            saveProdBtn.Size = new Size(103, 34);
            saveProdBtn.TabIndex = 13;
            saveProdBtn.Text = "Save";
            saveProdBtn.UseVisualStyleBackColor = true;
            // 
            // expDLbl
            // 
            expDLbl.AutoSize = true;
            expDLbl.Location = new Point(6, 248);
            expDLbl.Name = "expDLbl";
            expDLbl.Size = new Size(122, 26);
            expDLbl.TabIndex = 12;
            expDLbl.Text = "Expiry Date:";
            // 
            // expDDatePicker
            // 
            expDDatePicker.CustomFormat = "";
            expDDatePicker.Format = DateTimePickerFormat.Short;
            expDDatePicker.Location = new Point(148, 242);
            expDDatePicker.Name = "expDDatePicker";
            expDDatePicker.Size = new Size(263, 34);
            expDDatePicker.TabIndex = 11;
            expDDatePicker.Value = new DateTime(2024, 10, 3, 0, 0, 0, 0);
            // 
            // originLbl
            // 
            originLbl.AutoSize = true;
            originLbl.Location = new Point(6, 205);
            originLbl.Name = "originLbl";
            originLbl.Size = new Size(72, 26);
            originLbl.TabIndex = 10;
            originLbl.Text = "Origin:";
            // 
            // OriginTxtBx
            // 
            OriginTxtBx.Location = new Point(148, 202);
            OriginTxtBx.Name = "OriginTxtBx";
            OriginTxtBx.Size = new Size(263, 34);
            OriginTxtBx.TabIndex = 9;
            // 
            // unitPriceLbl
            // 
            unitPriceLbl.AutoSize = true;
            unitPriceLbl.Location = new Point(6, 165);
            unitPriceLbl.Name = "unitPriceLbl";
            unitPriceLbl.Size = new Size(105, 26);
            unitPriceLbl.TabIndex = 8;
            unitPriceLbl.Text = "Unit Price:";
            // 
            // unitPriceTxtBx
            // 
            unitPriceTxtBx.Location = new Point(148, 162);
            unitPriceTxtBx.Name = "unitPriceTxtBx";
            unitPriceTxtBx.Size = new Size(263, 34);
            unitPriceTxtBx.TabIndex = 7;
            // 
            // qttLbl
            // 
            qttLbl.AutoSize = true;
            qttLbl.Location = new Point(6, 125);
            qttLbl.Name = "qttLbl";
            qttLbl.Size = new Size(96, 26);
            qttLbl.TabIndex = 6;
            qttLbl.Text = "Quantity:";
            // 
            // QttTxtBx
            // 
            QttTxtBx.Location = new Point(148, 122);
            QttTxtBx.Name = "QttTxtBx";
            QttTxtBx.Size = new Size(263, 34);
            QttTxtBx.TabIndex = 5;
            // 
            // prodNameTxtBx
            // 
            prodNameTxtBx.Location = new Point(148, 82);
            prodNameTxtBx.Name = "prodNameTxtBx";
            prodNameTxtBx.Size = new Size(263, 34);
            prodNameTxtBx.TabIndex = 4;
            // 
            // prodNameLbl
            // 
            prodNameLbl.AutoSize = true;
            prodNameLbl.Location = new Point(6, 85);
            prodNameLbl.Name = "prodNameLbl";
            prodNameLbl.Size = new Size(148, 26);
            prodNameLbl.TabIndex = 3;
            prodNameLbl.Text = "Product Name:";
            // 
            // prodIDTxtBx
            // 
            prodIDTxtBx.Location = new Point(148, 42);
            prodIDTxtBx.Name = "prodIDTxtBx";
            prodIDTxtBx.Size = new Size(263, 34);
            prodIDTxtBx.TabIndex = 2;
            // 
            // prodIDLbl
            // 
            prodIDLbl.AutoSize = true;
            prodIDLbl.Location = new Point(6, 45);
            prodIDLbl.Name = "prodIDLbl";
            prodIDLbl.Size = new Size(113, 26);
            prodIDLbl.TabIndex = 1;
            prodIDLbl.Text = "Product ID:";
            // 
            // prodMngGrBxTltLbl
            // 
            prodMngGrBxTltLbl.AutoSize = true;
            prodMngGrBxTltLbl.BorderStyle = BorderStyle.FixedSingle;
            prodMngGrBxTltLbl.FlatStyle = FlatStyle.Popup;
            prodMngGrBxTltLbl.Font = new Font("San Francisco Display Bold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prodMngGrBxTltLbl.Location = new Point(84, 2);
            prodMngGrBxTltLbl.Name = "prodMngGrBxTltLbl";
            prodMngGrBxTltLbl.Size = new Size(229, 28);
            prodMngGrBxTltLbl.TabIndex = 0;
            prodMngGrBxTltLbl.Text = "Product Management";
            prodMngGrBxTltLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // prodFilterGrBx
            // 
            prodFilterGrBx.Controls.Add(maxUPRFilterTxtBx);
            prodFilterGrBx.Controls.Add(minUPRFilterTxtBx);
            prodFilterGrBx.Controls.Add(pbupFilterBtn);
            prodFilterGrBx.Controls.Add(epFilterBtn);
            prodFilterGrBx.Controls.Add(jppFilterBtn);
            prodFilterGrBx.Controls.Add(huppFilterBtn);
            prodFilterGrBx.Controls.Add(productFilterDataGridView);
            prodFilterGrBx.Controls.Add(prodFilterGrBxTltLbl);
            prodFilterGrBx.Location = new Point(434, 12);
            prodFilterGrBx.Name = "prodFilterGrBx";
            prodFilterGrBx.Size = new Size(612, 450);
            prodFilterGrBx.TabIndex = 1;
            prodFilterGrBx.TabStop = false;
            // 
            // maxUPRFilterTxtBx
            // 
            maxUPRFilterTxtBx.Location = new Point(503, 117);
            maxUPRFilterTxtBx.Name = "maxUPRFilterTxtBx";
            maxUPRFilterTxtBx.PlaceholderText = "Max:";
            maxUPRFilterTxtBx.Size = new Size(103, 34);
            maxUPRFilterTxtBx.TabIndex = 7;
            // 
            // minUPRFilterTxtBx
            // 
            minUPRFilterTxtBx.Location = new Point(503, 45);
            minUPRFilterTxtBx.Name = "minUPRFilterTxtBx";
            minUPRFilterTxtBx.PlaceholderText = "Min:";
            minUPRFilterTxtBx.Size = new Size(103, 34);
            minUPRFilterTxtBx.TabIndex = 6;
            // 
            // pbupFilterBtn
            // 
            pbupFilterBtn.Font = new Font("San Francisco Display Regular", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pbupFilterBtn.Location = new Point(357, 45);
            pbupFilterBtn.Name = "pbupFilterBtn";
            pbupFilterBtn.Size = new Size(140, 106);
            pbupFilterBtn.TabIndex = 5;
            pbupFilterBtn.Text = "Products with Unit Price Range:";
            pbupFilterBtn.UseVisualStyleBackColor = true;
            // 
            // epFilterBtn
            // 
            epFilterBtn.Location = new Point(241, 45);
            epFilterBtn.Name = "epFilterBtn";
            epFilterBtn.Size = new Size(110, 106);
            epFilterBtn.TabIndex = 4;
            epFilterBtn.Text = "Expired Products";
            epFilterBtn.UseVisualStyleBackColor = true;
            // 
            // jppFilterBtn
            // 
            jppFilterBtn.Location = new Point(125, 45);
            jppFilterBtn.Name = "jppFilterBtn";
            jppFilterBtn.Size = new Size(110, 106);
            jppFilterBtn.TabIndex = 3;
            jppFilterBtn.Text = "Japanese Products";
            jppFilterBtn.UseVisualStyleBackColor = true;
            // 
            // huppFilterBtn
            // 
            huppFilterBtn.Location = new Point(6, 45);
            huppFilterBtn.Name = "huppFilterBtn";
            huppFilterBtn.Size = new Size(113, 106);
            huppFilterBtn.TabIndex = 2;
            huppFilterBtn.Text = "Highest Unit Price Product";
            huppFilterBtn.UseVisualStyleBackColor = true;
            // 
            // productFilterDataGridView
            // 
            productFilterDataGridView.BackgroundColor = SystemColors.Control;
            productFilterDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productFilterDataGridView.Location = new Point(6, 157);
            productFilterDataGridView.Name = "productFilterDataGridView";
            productFilterDataGridView.RowHeadersWidth = 62;
            productFilterDataGridView.Size = new Size(600, 287);
            productFilterDataGridView.TabIndex = 1;
            // 
            // prodFilterGrBxTltLbl
            // 
            prodFilterGrBxTltLbl.AutoSize = true;
            prodFilterGrBxTltLbl.BorderStyle = BorderStyle.FixedSingle;
            prodFilterGrBxTltLbl.Font = new Font("San Francisco Display Bold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prodFilterGrBxTltLbl.Location = new Point(187, 2);
            prodFilterGrBxTltLbl.Name = "prodFilterGrBxTltLbl";
            prodFilterGrBxTltLbl.Size = new Size(229, 28);
            prodFilterGrBxTltLbl.TabIndex = 0;
            prodFilterGrBxTltLbl.Text = "Product Finder - Filter";
            prodFilterGrBxTltLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(funcGrBx);
            groupBox2.Controls.Add(importedProductDataGridView);
            groupBox2.Controls.Add(impProdGrBxTltLbl);
            groupBox2.Location = new Point(11, 468);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1035, 544);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // funcGrBx
            // 
            funcGrBx.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            funcGrBx.Controls.Add(delExpProdBtn);
            funcGrBx.Controls.Add(delAllProdBtn);
            funcGrBx.Controls.Add(expDateProdValidateBtn);
            funcGrBx.Controls.Add(spcOriProdTxtBx);
            funcGrBx.Controls.Add(delOriProdBtn);
            funcGrBx.Controls.Add(funcGrBxTltLbl);
            funcGrBx.FlatStyle = FlatStyle.Popup;
            funcGrBx.Location = new Point(612, 33);
            funcGrBx.Name = "funcGrBx";
            funcGrBx.Size = new Size(417, 505);
            funcGrBx.TabIndex = 2;
            funcGrBx.TabStop = false;
            // 
            // delExpProdBtn
            // 
            delExpProdBtn.Location = new Point(6, 195);
            delExpProdBtn.Name = "delExpProdBtn";
            delExpProdBtn.Size = new Size(405, 34);
            delExpProdBtn.TabIndex = 5;
            delExpProdBtn.Text = "Delete all Expired Products";
            delExpProdBtn.UseVisualStyleBackColor = true;
            // 
            // delAllProdBtn
            // 
            delAllProdBtn.Location = new Point(6, 155);
            delAllProdBtn.Name = "delAllProdBtn";
            delAllProdBtn.Size = new Size(405, 34);
            delAllProdBtn.TabIndex = 4;
            delAllProdBtn.Text = "Delete all Products in Inventory";
            delAllProdBtn.UseVisualStyleBackColor = true;
            // 
            // expDateProdValidateBtn
            // 
            expDateProdValidateBtn.Location = new Point(6, 115);
            expDateProdValidateBtn.Name = "expDateProdValidateBtn";
            expDateProdValidateBtn.Size = new Size(405, 34);
            expDateProdValidateBtn.TabIndex = 3;
            expDateProdValidateBtn.Text = "Validation of Expired Products";
            expDateProdValidateBtn.UseVisualStyleBackColor = true;
            // 
            // spcOriProdTxtBx
            // 
            spcOriProdTxtBx.Location = new Point(233, 60);
            spcOriProdTxtBx.Name = "spcOriProdTxtBx";
            spcOriProdTxtBx.Size = new Size(178, 34);
            spcOriProdTxtBx.TabIndex = 2;
            // 
            // delOriProdBtn
            // 
            delOriProdBtn.Location = new Point(6, 44);
            delOriProdBtn.Name = "delOriProdBtn";
            delOriProdBtn.Size = new Size(221, 65);
            delOriProdBtn.TabIndex = 1;
            delOriProdBtn.Text = "Delete Products which come from:";
            delOriProdBtn.UseVisualStyleBackColor = true;
            // 
            // funcGrBxTltLbl
            // 
            funcGrBxTltLbl.AutoSize = true;
            funcGrBxTltLbl.BorderStyle = BorderStyle.FixedSingle;
            funcGrBxTltLbl.Font = new Font("San Francisco Display Bold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            funcGrBxTltLbl.Location = new Point(159, 0);
            funcGrBxTltLbl.Name = "funcGrBxTltLbl";
            funcGrBxTltLbl.Size = new Size(114, 28);
            funcGrBxTltLbl.TabIndex = 0;
            funcGrBxTltLbl.Text = "Functions";
            // 
            // importedProductDataGridView
            // 
            importedProductDataGridView.BackgroundColor = SystemColors.Control;
            importedProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            importedProductDataGridView.Location = new Point(6, 33);
            importedProductDataGridView.Name = "importedProductDataGridView";
            importedProductDataGridView.RowHeadersWidth = 62;
            importedProductDataGridView.Size = new Size(600, 505);
            importedProductDataGridView.TabIndex = 1;
            // 
            // impProdGrBxTltLbl
            // 
            impProdGrBxTltLbl.AutoSize = true;
            impProdGrBxTltLbl.BorderStyle = BorderStyle.FixedSingle;
            impProdGrBxTltLbl.FlatStyle = FlatStyle.Flat;
            impProdGrBxTltLbl.Font = new Font("San Francisco Display Bold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            impProdGrBxTltLbl.Location = new Point(6, 0);
            impProdGrBxTltLbl.Name = "impProdGrBxTltLbl";
            impProdGrBxTltLbl.Size = new Size(228, 28);
            impProdGrBxTltLbl.TabIndex = 0;
            impProdGrBxTltLbl.Text = "Imported Product List";
            // 
            // ProdMng
            // 
            AutoScaleDimensions = new SizeF(12F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 1024);
            Controls.Add(groupBox2);
            Controls.Add(prodFilterGrBx);
            Controls.Add(prodInfoGrBx);
            Font = new Font("San Francisco Display Regular", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ProdMng";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Management - 22521474 - To Vinh Tien";
            prodInfoGrBx.ResumeLayout(false);
            prodInfoGrBx.PerformLayout();
            prodFilterGrBx.ResumeLayout(false);
            prodFilterGrBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productFilterDataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            funcGrBx.ResumeLayout(false);
            funcGrBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)importedProductDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox prodInfoGrBx;
        private Label prodMngGrBxTltLbl;
        private TextBox prodIDTxtBx;
        private Label prodIDLbl;
        private TextBox prodNameTxtBx;
        private Label prodNameLbl;
        private TextBox QttTxtBx;
        private Label unitPriceLbl;
        private TextBox unitPriceTxtBx;
        private Label qttLbl;
        private ToolTip toolTip1;
        private Label originLbl;
        private TextBox OriginTxtBx;
        private DateTimePicker expDDatePicker;
        private Label expDLbl;
        private Button saveProdBtn;
        private Button delProdBtn;
        private GroupBox prodFilterGrBx;
        private Label prodFilterGrBxTltLbl;
        private Button jppFilterBtn;
        private Button huppFilterBtn;
        private DataGridView productFilterDataGridView;
        private Button pbupFilterBtn;
        private Button epFilterBtn;
        private TextBox maxUPRFilterTxtBx;
        private TextBox minUPRFilterTxtBx;
        private GroupBox groupBox2;
        private Label impProdGrBxTltLbl;
        private DataGridView importedProductDataGridView;
        private GroupBox funcGrBx;
        private Button delOriProdBtn;
        private Label funcGrBxTltLbl;
        private Button delExpProdBtn;
        private Button delAllProdBtn;
        private Button expDateProdValidateBtn;
        private TextBox spcOriProdTxtBx;
    }
}
