namespace DynamicRest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.comboMethod = new System.Windows.Forms.ComboBox();
            this.textboxUrl = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.dataGridViewParam = new System.Windows.Forms.DataGridView();
            this.comboParamUrl = new System.Windows.Forms.ComboBox();
            this.labelRestUrl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxNewUrl = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSetInput = new System.Windows.Forms.Button();
            this.comboNewMethod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboSelectUrl = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParam)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxResult
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxResult, 4);
            this.textBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(23, 497);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(937, 297);
            this.textBoxResult.TabIndex = 0;
            // 
            // comboMethod
            // 
            this.comboMethod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMethod.FormattingEnabled = true;
            this.comboMethod.Location = new System.Drawing.Point(143, 123);
            this.comboMethod.Name = "comboMethod";
            this.comboMethod.Size = new System.Drawing.Size(94, 24);
            this.comboMethod.TabIndex = 2;
            // 
            // textboxUrl
            // 
            this.textboxUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxUrl.Location = new System.Drawing.Point(243, 124);
            this.textboxUrl.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.textboxUrl.Name = "textboxUrl";
            this.textboxUrl.Size = new System.Drawing.Size(612, 22);
            this.textboxUrl.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(861, 124);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(96, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // dataGridViewParam
            // 
            this.dataGridViewParam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewParam.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewParam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewParam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewParam, 4);
            this.dataGridViewParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewParam.Location = new System.Drawing.Point(23, 194);
            this.dataGridViewParam.Name = "dataGridViewParam";
            this.dataGridViewParam.Size = new System.Drawing.Size(937, 297);
            this.dataGridViewParam.TabIndex = 8;
            // 
            // comboParamUrl
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.comboParamUrl, 2);
            this.comboParamUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboParamUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboParamUrl.FormattingEnabled = true;
            this.comboParamUrl.Location = new System.Drawing.Point(143, 157);
            this.comboParamUrl.Name = "comboParamUrl";
            this.comboParamUrl.Size = new System.Drawing.Size(712, 24);
            this.comboParamUrl.TabIndex = 2;
            // 
            // labelRestUrl
            // 
            this.labelRestUrl.AutoSize = true;
            this.labelRestUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRestUrl.Location = new System.Drawing.Point(23, 25);
            this.labelRestUrl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelRestUrl.Name = "labelRestUrl";
            this.labelRestUrl.Size = new System.Drawing.Size(96, 16);
            this.labelRestUrl.TabIndex = 9;
            this.labelRestUrl.Text = "New Rest URL";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Input Param From";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxResult, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.comboMethod, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboParamUrl, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSend, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.textboxUrl, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewParam, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelRestUrl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNewUrl, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSetInput, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboNewMethod, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboSelectUrl, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(983, 817);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // textBoxNewUrl
            // 
            this.textBoxNewUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNewUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewUrl.Location = new System.Drawing.Point(243, 23);
            this.textBoxNewUrl.Name = "textBoxNewUrl";
            this.textBoxNewUrl.Size = new System.Drawing.Size(612, 22);
            this.textBoxNewUrl.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(861, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSetInput
            // 
            this.btnSetInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSetInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetInput.Location = new System.Drawing.Point(862, 157);
            this.btnSetInput.Name = "btnSetInput";
            this.btnSetInput.Size = new System.Drawing.Size(96, 23);
            this.btnSetInput.TabIndex = 12;
            this.btnSetInput.Text = "Set";
            this.btnSetInput.UseVisualStyleBackColor = true;
            // 
            // comboNewMethod
            // 
            this.comboNewMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboNewMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboNewMethod.FormattingEnabled = true;
            this.comboNewMethod.Location = new System.Drawing.Point(143, 23);
            this.comboNewMethod.Name = "comboNewMethod";
            this.comboNewMethod.Size = new System.Drawing.Size(94, 24);
            this.comboNewMethod.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Rest URL";
            // 
            // comboSelectUrl
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.comboSelectUrl, 2);
            this.comboSelectUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboSelectUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSelectUrl.FormattingEnabled = true;
            this.comboSelectUrl.Location = new System.Drawing.Point(143, 83);
            this.comboSelectUrl.Name = "comboSelectUrl";
            this.comboSelectUrl.Size = new System.Drawing.Size(712, 24);
            this.comboSelectUrl.TabIndex = 14;
            this.comboSelectUrl.SelectedIndexChanged += new System.EventHandler(this.comboSelectUrl_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 817);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "DynamicRest";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParam)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.ComboBox comboMethod;
        private System.Windows.Forms.TextBox textboxUrl;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.DataGridView dataGridViewParam;
        private System.Windows.Forms.ComboBox comboParamUrl;
        private System.Windows.Forms.Label labelRestUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewUrl;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSetInput;
        private System.Windows.Forms.ComboBox comboNewMethod;
        private System.Windows.Forms.ComboBox comboSelectUrl;
    }
}

