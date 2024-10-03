using System.Drawing;
using System;
using System.Windows.Forms;

namespace GUI
{
    partial class GUI
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
            this.prodInfoGrBx = new System.Windows.Forms.GroupBox();
            this.delProdBtn = new System.Windows.Forms.Button();
            this.saveProdBtn = new System.Windows.Forms.Button();
            this.expDLbl = new System.Windows.Forms.Label();
            this.expDDatePicker = new System.Windows.Forms.DateTimePicker();
            this.originLbl = new System.Windows.Forms.Label();
            this.originTxtBx = new System.Windows.Forms.TextBox();
            this.unitPriceLbl = new System.Windows.Forms.Label();
            this.unitPriceTxtBx = new System.Windows.Forms.TextBox();
            this.qttLbl = new System.Windows.Forms.Label();
            this.QttTxtBx = new System.Windows.Forms.TextBox();
            this.prodNameTxtBx = new System.Windows.Forms.TextBox();
            this.prodNameLbl = new System.Windows.Forms.Label();
            this.prodIDTxtBx = new System.Windows.Forms.TextBox();
            this.prodIDLbl = new System.Windows.Forms.Label();
            this.prodMngGrBxTltLbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.prodFilterGrBx = new System.Windows.Forms.GroupBox();
            this.maxUPRFilterTxtBx = new System.Windows.Forms.TextBox();
            this.minUPRFilterTxtBx = new System.Windows.Forms.TextBox();
            this.pbupFilterBtn = new System.Windows.Forms.Button();
            this.epFilterBtn = new System.Windows.Forms.Button();
            this.jppFilterBtn = new System.Windows.Forms.Button();
            this.huppFilterBtn = new System.Windows.Forms.Button();
            this.productFilterDataGridView = new System.Windows.Forms.DataGridView();
            this.prodFilterGrBxTltLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.funcGrBx = new System.Windows.Forms.GroupBox();
            this.delExpProdBtn = new System.Windows.Forms.Button();
            this.delAllProdBtn = new System.Windows.Forms.Button();
            this.expDateProdValidateBtn = new System.Windows.Forms.Button();
            this.spcOriProdTxtBx = new System.Windows.Forms.TextBox();
            this.delOriProdBtn = new System.Windows.Forms.Button();
            this.funcGrBxTltLbl = new System.Windows.Forms.Label();
            this.importedProductDataGridView = new System.Windows.Forms.DataGridView();
            this.impProdGrBxTltLbl = new System.Windows.Forms.Label();
            this.prodInfoGrBx.SuspendLayout();
            this.prodFilterGrBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productFilterDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.funcGrBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importedProductDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prodInfoGrBx
            // 
            this.prodInfoGrBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prodInfoGrBx.Controls.Add(this.delProdBtn);
            this.prodInfoGrBx.Controls.Add(this.saveProdBtn);
            this.prodInfoGrBx.Controls.Add(this.expDLbl);
            this.prodInfoGrBx.Controls.Add(this.expDDatePicker);
            this.prodInfoGrBx.Controls.Add(this.originLbl);
            this.prodInfoGrBx.Controls.Add(this.originTxtBx);
            this.prodInfoGrBx.Controls.Add(this.unitPriceLbl);
            this.prodInfoGrBx.Controls.Add(this.unitPriceTxtBx);
            this.prodInfoGrBx.Controls.Add(this.qttLbl);
            this.prodInfoGrBx.Controls.Add(this.QttTxtBx);
            this.prodInfoGrBx.Controls.Add(this.prodNameTxtBx);
            this.prodInfoGrBx.Controls.Add(this.prodNameLbl);
            this.prodInfoGrBx.Controls.Add(this.prodIDTxtBx);
            this.prodInfoGrBx.Controls.Add(this.prodIDLbl);
            this.prodInfoGrBx.Controls.Add(this.prodMngGrBxTltLbl);
            this.prodInfoGrBx.Font = new System.Drawing.Font("San Francisco Display Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodInfoGrBx.Location = new System.Drawing.Point(11, 12);
            this.prodInfoGrBx.Name = "prodInfoGrBx";
            this.prodInfoGrBx.Size = new System.Drawing.Size(423, 450);
            this.prodInfoGrBx.TabIndex = 0;
            this.prodInfoGrBx.TabStop = false;
            // 
            // delProdBtn
            // 
            this.delProdBtn.Font = new System.Drawing.Font("San Francisco Display Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delProdBtn.Location = new System.Drawing.Point(308, 282);
            this.delProdBtn.Name = "delProdBtn";
            this.delProdBtn.Size = new System.Drawing.Size(103, 34);
            this.delProdBtn.TabIndex = 14;
            this.delProdBtn.Text = "Delete";
            this.delProdBtn.UseVisualStyleBackColor = true;
            // 
            // saveProdBtn
            // 
            this.saveProdBtn.BackColor = System.Drawing.SystemColors.Control;
            this.saveProdBtn.Font = new System.Drawing.Font("San Francisco Display Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveProdBtn.Location = new System.Drawing.Point(148, 283);
            this.saveProdBtn.Name = "saveProdBtn";
            this.saveProdBtn.Size = new System.Drawing.Size(103, 34);
            this.saveProdBtn.TabIndex = 13;
            this.saveProdBtn.Text = "Save";
            this.saveProdBtn.UseVisualStyleBackColor = true;
            this.saveProdBtn.Click += new System.EventHandler(this.saveProdBtn_Click);
            // 
            // expDLbl
            // 
            this.expDLbl.AutoSize = true;
            this.expDLbl.Location = new System.Drawing.Point(6, 248);
            this.expDLbl.Name = "expDLbl";
            this.expDLbl.Size = new System.Drawing.Size(122, 26);
            this.expDLbl.TabIndex = 12;
            this.expDLbl.Text = "Expiry Date:";
            // 
            // expDDatePicker
            // 
            this.expDDatePicker.CustomFormat = "";
            this.expDDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expDDatePicker.Location = new System.Drawing.Point(148, 242);
            this.expDDatePicker.Name = "expDDatePicker";
            this.expDDatePicker.Size = new System.Drawing.Size(263, 34);
            this.expDDatePicker.TabIndex = 11;
            this.expDDatePicker.Value = new System.DateTime(2024, 10, 3, 0, 0, 0, 0);
            // 
            // originLbl
            // 
            this.originLbl.AutoSize = true;
            this.originLbl.Location = new System.Drawing.Point(6, 205);
            this.originLbl.Name = "originLbl";
            this.originLbl.Size = new System.Drawing.Size(72, 26);
            this.originLbl.TabIndex = 10;
            this.originLbl.Text = "Origin:";
            // 
            // originTxtBx
            // 
            this.originTxtBx.Location = new System.Drawing.Point(148, 202);
            this.originTxtBx.Name = "originTxtBx";
            this.originTxtBx.Size = new System.Drawing.Size(263, 34);
            this.originTxtBx.TabIndex = 9;
            // 
            // unitPriceLbl
            // 
            this.unitPriceLbl.AutoSize = true;
            this.unitPriceLbl.Location = new System.Drawing.Point(6, 165);
            this.unitPriceLbl.Name = "unitPriceLbl";
            this.unitPriceLbl.Size = new System.Drawing.Size(105, 26);
            this.unitPriceLbl.TabIndex = 8;
            this.unitPriceLbl.Text = "Unit Price:";
            // 
            // unitPriceTxtBx
            // 
            this.unitPriceTxtBx.Location = new System.Drawing.Point(148, 162);
            this.unitPriceTxtBx.Name = "unitPriceTxtBx";
            this.unitPriceTxtBx.Size = new System.Drawing.Size(263, 34);
            this.unitPriceTxtBx.TabIndex = 7;
            // 
            // qttLbl
            // 
            this.qttLbl.AutoSize = true;
            this.qttLbl.Location = new System.Drawing.Point(6, 125);
            this.qttLbl.Name = "qttLbl";
            this.qttLbl.Size = new System.Drawing.Size(96, 26);
            this.qttLbl.TabIndex = 6;
            this.qttLbl.Text = "Quantity:";
            // 
            // QttTxtBx
            // 
            this.QttTxtBx.Location = new System.Drawing.Point(148, 122);
            this.QttTxtBx.Name = "QttTxtBx";
            this.QttTxtBx.Size = new System.Drawing.Size(263, 34);
            this.QttTxtBx.TabIndex = 5;
            // 
            // prodNameTxtBx
            // 
            this.prodNameTxtBx.Location = new System.Drawing.Point(148, 82);
            this.prodNameTxtBx.Name = "prodNameTxtBx";
            this.prodNameTxtBx.Size = new System.Drawing.Size(263, 34);
            this.prodNameTxtBx.TabIndex = 4;
            // 
            // prodNameLbl
            // 
            this.prodNameLbl.AutoSize = true;
            this.prodNameLbl.Location = new System.Drawing.Point(6, 85);
            this.prodNameLbl.Name = "prodNameLbl";
            this.prodNameLbl.Size = new System.Drawing.Size(148, 26);
            this.prodNameLbl.TabIndex = 3;
            this.prodNameLbl.Text = "Product Name:";
            // 
            // prodIDTxtBx
            // 
            this.prodIDTxtBx.Location = new System.Drawing.Point(148, 42);
            this.prodIDTxtBx.Name = "prodIDTxtBx";
            this.prodIDTxtBx.Size = new System.Drawing.Size(263, 34);
            this.prodIDTxtBx.TabIndex = 2;
            // 
            // prodIDLbl
            // 
            this.prodIDLbl.AutoSize = true;
            this.prodIDLbl.Location = new System.Drawing.Point(6, 45);
            this.prodIDLbl.Name = "prodIDLbl";
            this.prodIDLbl.Size = new System.Drawing.Size(113, 26);
            this.prodIDLbl.TabIndex = 1;
            this.prodIDLbl.Text = "Product ID:";
            // 
            // prodMngGrBxTltLbl
            // 
            this.prodMngGrBxTltLbl.AutoSize = true;
            this.prodMngGrBxTltLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodMngGrBxTltLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prodMngGrBxTltLbl.Font = new System.Drawing.Font("San Francisco Display Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodMngGrBxTltLbl.Location = new System.Drawing.Point(96, 0);
            this.prodMngGrBxTltLbl.Name = "prodMngGrBxTltLbl";
            this.prodMngGrBxTltLbl.Size = new System.Drawing.Size(229, 28);
            this.prodMngGrBxTltLbl.TabIndex = 0;
            this.prodMngGrBxTltLbl.Text = "Product Management";
            this.prodMngGrBxTltLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prodFilterGrBx
            // 
            this.prodFilterGrBx.Controls.Add(this.maxUPRFilterTxtBx);
            this.prodFilterGrBx.Controls.Add(this.minUPRFilterTxtBx);
            this.prodFilterGrBx.Controls.Add(this.pbupFilterBtn);
            this.prodFilterGrBx.Controls.Add(this.epFilterBtn);
            this.prodFilterGrBx.Controls.Add(this.jppFilterBtn);
            this.prodFilterGrBx.Controls.Add(this.huppFilterBtn);
            this.prodFilterGrBx.Controls.Add(this.productFilterDataGridView);
            this.prodFilterGrBx.Controls.Add(this.prodFilterGrBxTltLbl);
            this.prodFilterGrBx.Location = new System.Drawing.Point(440, 12);
            this.prodFilterGrBx.Name = "prodFilterGrBx";
            this.prodFilterGrBx.Size = new System.Drawing.Size(710, 450);
            this.prodFilterGrBx.TabIndex = 1;
            this.prodFilterGrBx.TabStop = false;
            // 
            // maxUPRFilterTxtBx
            // 
            this.maxUPRFilterTxtBx.Location = new System.Drawing.Point(601, 117);
            this.maxUPRFilterTxtBx.Name = "maxUPRFilterTxtBx";
            this.maxUPRFilterTxtBx.Size = new System.Drawing.Size(103, 34);
            this.maxUPRFilterTxtBx.TabIndex = 7;
            // 
            // minUPRFilterTxtBx
            // 
            this.minUPRFilterTxtBx.Location = new System.Drawing.Point(601, 45);
            this.minUPRFilterTxtBx.Name = "minUPRFilterTxtBx";
            this.minUPRFilterTxtBx.Size = new System.Drawing.Size(103, 34);
            this.minUPRFilterTxtBx.TabIndex = 6;
            // 
            // pbupFilterBtn
            // 
            this.pbupFilterBtn.Font = new System.Drawing.Font("San Francisco Display Regular", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbupFilterBtn.Location = new System.Drawing.Point(444, 45);
            this.pbupFilterBtn.Name = "pbupFilterBtn";
            this.pbupFilterBtn.Size = new System.Drawing.Size(150, 106);
            this.pbupFilterBtn.TabIndex = 5;
            this.pbupFilterBtn.Text = "Products with Unit Price Range:";
            this.pbupFilterBtn.UseVisualStyleBackColor = true;
            // 
            // epFilterBtn
            // 
            this.epFilterBtn.Location = new System.Drawing.Point(275, 45);
            this.epFilterBtn.Name = "epFilterBtn";
            this.epFilterBtn.Size = new System.Drawing.Size(110, 106);
            this.epFilterBtn.TabIndex = 4;
            this.epFilterBtn.Text = "Expired Products";
            this.epFilterBtn.UseVisualStyleBackColor = true;
            // 
            // jppFilterBtn
            // 
            this.jppFilterBtn.Location = new System.Drawing.Point(145, 42);
            this.jppFilterBtn.Name = "jppFilterBtn";
            this.jppFilterBtn.Size = new System.Drawing.Size(124, 106);
            this.jppFilterBtn.TabIndex = 3;
            this.jppFilterBtn.Text = "Japanese Products";
            this.jppFilterBtn.UseVisualStyleBackColor = true;
            // 
            // huppFilterBtn
            // 
            this.huppFilterBtn.Location = new System.Drawing.Point(6, 42);
            this.huppFilterBtn.Name = "huppFilterBtn";
            this.huppFilterBtn.Size = new System.Drawing.Size(133, 106);
            this.huppFilterBtn.TabIndex = 2;
            this.huppFilterBtn.Text = "Highest Unit Price Product";
            this.huppFilterBtn.UseVisualStyleBackColor = true;
            // 
            // productFilterDataGridView
            // 
            this.productFilterDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.productFilterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productFilterDataGridView.Location = new System.Drawing.Point(6, 157);
            this.productFilterDataGridView.Name = "productFilterDataGridView";
            this.productFilterDataGridView.RowHeadersWidth = 62;
            this.productFilterDataGridView.Size = new System.Drawing.Size(698, 287);
            this.productFilterDataGridView.TabIndex = 1;
            // 
            // prodFilterGrBxTltLbl
            // 
            this.prodFilterGrBxTltLbl.AutoSize = true;
            this.prodFilterGrBxTltLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodFilterGrBxTltLbl.Font = new System.Drawing.Font("San Francisco Display Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodFilterGrBxTltLbl.Location = new System.Drawing.Point(241, 0);
            this.prodFilterGrBxTltLbl.Name = "prodFilterGrBxTltLbl";
            this.prodFilterGrBxTltLbl.Size = new System.Drawing.Size(229, 28);
            this.prodFilterGrBxTltLbl.TabIndex = 0;
            this.prodFilterGrBxTltLbl.Text = "Product Finder - Filter";
            this.prodFilterGrBxTltLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.funcGrBx);
            this.groupBox2.Controls.Add(this.importedProductDataGridView);
            this.groupBox2.Controls.Add(this.impProdGrBxTltLbl);
            this.groupBox2.Location = new System.Drawing.Point(11, 468);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1133, 544);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // funcGrBx
            // 
            this.funcGrBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.funcGrBx.Controls.Add(this.delExpProdBtn);
            this.funcGrBx.Controls.Add(this.delAllProdBtn);
            this.funcGrBx.Controls.Add(this.expDateProdValidateBtn);
            this.funcGrBx.Controls.Add(this.spcOriProdTxtBx);
            this.funcGrBx.Controls.Add(this.delOriProdBtn);
            this.funcGrBx.Controls.Add(this.funcGrBxTltLbl);
            this.funcGrBx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.funcGrBx.Location = new System.Drawing.Point(710, 33);
            this.funcGrBx.Name = "funcGrBx";
            this.funcGrBx.Size = new System.Drawing.Size(417, 505);
            this.funcGrBx.TabIndex = 2;
            this.funcGrBx.TabStop = false;
            // 
            // delExpProdBtn
            // 
            this.delExpProdBtn.Location = new System.Drawing.Point(6, 195);
            this.delExpProdBtn.Name = "delExpProdBtn";
            this.delExpProdBtn.Size = new System.Drawing.Size(405, 34);
            this.delExpProdBtn.TabIndex = 5;
            this.delExpProdBtn.Text = "Delete all Expired Products";
            this.delExpProdBtn.UseVisualStyleBackColor = true;
            // 
            // delAllProdBtn
            // 
            this.delAllProdBtn.Location = new System.Drawing.Point(6, 155);
            this.delAllProdBtn.Name = "delAllProdBtn";
            this.delAllProdBtn.Size = new System.Drawing.Size(405, 34);
            this.delAllProdBtn.TabIndex = 4;
            this.delAllProdBtn.Text = "Delete all Products in Inventory";
            this.delAllProdBtn.UseVisualStyleBackColor = true;
            // 
            // expDateProdValidateBtn
            // 
            this.expDateProdValidateBtn.Location = new System.Drawing.Point(6, 115);
            this.expDateProdValidateBtn.Name = "expDateProdValidateBtn";
            this.expDateProdValidateBtn.Size = new System.Drawing.Size(405, 34);
            this.expDateProdValidateBtn.TabIndex = 3;
            this.expDateProdValidateBtn.Text = "Validation of Expired Products";
            this.expDateProdValidateBtn.UseVisualStyleBackColor = true;
            // 
            // spcOriProdTxtBx
            // 
            this.spcOriProdTxtBx.Location = new System.Drawing.Point(233, 60);
            this.spcOriProdTxtBx.Name = "spcOriProdTxtBx";
            this.spcOriProdTxtBx.Size = new System.Drawing.Size(178, 34);
            this.spcOriProdTxtBx.TabIndex = 2;
            // 
            // delOriProdBtn
            // 
            this.delOriProdBtn.Location = new System.Drawing.Point(6, 44);
            this.delOriProdBtn.Name = "delOriProdBtn";
            this.delOriProdBtn.Size = new System.Drawing.Size(221, 65);
            this.delOriProdBtn.TabIndex = 1;
            this.delOriProdBtn.Text = "Delete Products which come from:";
            this.delOriProdBtn.UseVisualStyleBackColor = true;
            // 
            // funcGrBxTltLbl
            // 
            this.funcGrBxTltLbl.AutoSize = true;
            this.funcGrBxTltLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.funcGrBxTltLbl.Font = new System.Drawing.Font("San Francisco Display Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcGrBxTltLbl.Location = new System.Drawing.Point(159, 0);
            this.funcGrBxTltLbl.Name = "funcGrBxTltLbl";
            this.funcGrBxTltLbl.Size = new System.Drawing.Size(114, 28);
            this.funcGrBxTltLbl.TabIndex = 0;
            this.funcGrBxTltLbl.Text = "Functions";
            // 
            // importedProductDataGridView
            // 
            this.importedProductDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.importedProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.importedProductDataGridView.Location = new System.Drawing.Point(6, 33);
            this.importedProductDataGridView.Name = "importedProductDataGridView";
            this.importedProductDataGridView.RowHeadersWidth = 62;
            this.importedProductDataGridView.Size = new System.Drawing.Size(692, 505);
            this.importedProductDataGridView.TabIndex = 1;
            // 
            // impProdGrBxTltLbl
            // 
            this.impProdGrBxTltLbl.AutoSize = true;
            this.impProdGrBxTltLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.impProdGrBxTltLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.impProdGrBxTltLbl.Font = new System.Drawing.Font("San Francisco Display Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impProdGrBxTltLbl.Location = new System.Drawing.Point(6, 0);
            this.impProdGrBxTltLbl.Name = "impProdGrBxTltLbl";
            this.impProdGrBxTltLbl.Size = new System.Drawing.Size(228, 28);
            this.impProdGrBxTltLbl.TabIndex = 0;
            this.impProdGrBxTltLbl.Text = "Imported Product List";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 1024);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.prodFilterGrBx);
            this.Controls.Add(this.prodInfoGrBx);
            this.Font = new System.Drawing.Font("San Francisco Display Regular", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Management - 22521474 - To Vinh Tien";
            this.prodInfoGrBx.ResumeLayout(false);
            this.prodInfoGrBx.PerformLayout();
            this.prodFilterGrBx.ResumeLayout(false);
            this.prodFilterGrBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productFilterDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.funcGrBx.ResumeLayout(false);
            this.funcGrBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importedProductDataGridView)).EndInit();
            this.ResumeLayout(false);

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
        private TextBox originTxtBx;
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

