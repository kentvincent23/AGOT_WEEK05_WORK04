namespace AGOT_WEEK05_WORK04
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
            this.lbl_barcode = new System.Windows.Forms.Label();
            this.txtBox_barcode = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.txtbox_description = new System.Windows.Forms.TextBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.lbl_origin = new System.Windows.Forms.Label();
            this.grp_manufactured = new System.Windows.Forms.GroupBox();
            this.radio_abroad = new System.Windows.Forms.RadioButton();
            this.radio_local = new System.Windows.Forms.RadioButton();
            this.lbl_status = new System.Windows.Forms.Label();
            this.check_active = new System.Windows.Forms.CheckBox();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_markup = new System.Windows.Forms.Label();
            this.txtBox_cost = new System.Windows.Forms.TextBox();
            this.txtBox_price = new System.Windows.Forms.TextBox();
            this.txtBox_markup = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.grp_manufactured.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_barcode
            // 
            this.lbl_barcode.AutoSize = true;
            this.lbl_barcode.Location = new System.Drawing.Point(13, 13);
            this.lbl_barcode.Name = "lbl_barcode";
            this.lbl_barcode.Size = new System.Drawing.Size(59, 16);
            this.lbl_barcode.TabIndex = 0;
            this.lbl_barcode.Text = "Barcode";
            // 
            // txtBox_barcode
            // 
            this.txtBox_barcode.Location = new System.Drawing.Point(127, 13);
            this.txtBox_barcode.Name = "txtBox_barcode";
            this.txtBox_barcode.Size = new System.Drawing.Size(261, 22);
            this.txtBox_barcode.TabIndex = 1;
            this.txtBox_barcode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(12, 63);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(44, 16);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name";
            // 
            // txtbox_name
            // 
            this.txtbox_name.Location = new System.Drawing.Point(127, 63);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(261, 22);
            this.txtbox_name.TabIndex = 3;
            this.txtbox_name.TextChanged += new System.EventHandler(this.txtbox_name_TextChanged);
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(12, 94);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(75, 16);
            this.lbl_description.TabIndex = 4;
            this.lbl_description.Text = "Description";
            // 
            // txtbox_description
            // 
            this.txtbox_description.Location = new System.Drawing.Point(127, 94);
            this.txtbox_description.Multiline = true;
            this.txtbox_description.Name = "txtbox_description";
            this.txtbox_description.Size = new System.Drawing.Size(261, 133);
            this.txtbox_description.TabIndex = 5;
            this.txtbox_description.TextChanged += new System.EventHandler(this.txtbox_description_TextChanged);
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(13, 241);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(62, 16);
            this.lbl_category.TabIndex = 6;
            this.lbl_category.Text = "Category";
            // 
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Items.AddRange(new object[] {
            "Food Item",
            "Appliance",
            "Furniture",
            "Accessories",
            "Decoration"});
            this.cmb_category.Location = new System.Drawing.Point(127, 241);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(261, 24);
            this.cmb_category.TabIndex = 7;
            // 
            // lbl_origin
            // 
            this.lbl_origin.AutoSize = true;
            this.lbl_origin.Location = new System.Drawing.Point(13, 285);
            this.lbl_origin.Name = "lbl_origin";
            this.lbl_origin.Size = new System.Drawing.Size(42, 16);
            this.lbl_origin.TabIndex = 8;
            this.lbl_origin.Text = "Origin";
            this.lbl_origin.Click += new System.EventHandler(this.lbl_origin_Click);
            // 
            // grp_manufactured
            // 
            this.grp_manufactured.Controls.Add(this.radio_abroad);
            this.grp_manufactured.Controls.Add(this.radio_local);
            this.grp_manufactured.Location = new System.Drawing.Point(127, 285);
            this.grp_manufactured.Name = "grp_manufactured";
            this.grp_manufactured.Size = new System.Drawing.Size(261, 68);
            this.grp_manufactured.TabIndex = 9;
            this.grp_manufactured.TabStop = false;
            this.grp_manufactured.Text = "Manufactured";
            this.grp_manufactured.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radio_abroad
            // 
            this.radio_abroad.AutoSize = true;
            this.radio_abroad.Location = new System.Drawing.Point(103, 22);
            this.radio_abroad.Name = "radio_abroad";
            this.radio_abroad.Size = new System.Drawing.Size(73, 20);
            this.radio_abroad.TabIndex = 1;
            this.radio_abroad.TabStop = true;
            this.radio_abroad.Text = "Abroad";
            this.radio_abroad.UseVisualStyleBackColor = true;
            // 
            // radio_local
            // 
            this.radio_local.AutoSize = true;
            this.radio_local.Location = new System.Drawing.Point(25, 22);
            this.radio_local.Name = "radio_local";
            this.radio_local.Size = new System.Drawing.Size(61, 20);
            this.radio_local.TabIndex = 0;
            this.radio_local.TabStop = true;
            this.radio_local.Text = "Local";
            this.radio_local.UseVisualStyleBackColor = true;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(14, 374);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(44, 16);
            this.lbl_status.TabIndex = 10;
            this.lbl_status.Text = "Status";
            // 
            // check_active
            // 
            this.check_active.AutoSize = true;
            this.check_active.Location = new System.Drawing.Point(127, 374);
            this.check_active.Name = "check_active";
            this.check_active.Size = new System.Drawing.Size(66, 20);
            this.check_active.TabIndex = 11;
            this.check_active.Text = "Active";
            this.check_active.UseVisualStyleBackColor = true;
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.Location = new System.Drawing.Point(14, 420);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(34, 16);
            this.lbl_cost.TabIndex = 12;
            this.lbl_cost.Text = "Cost";
            this.lbl_cost.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(124, 420);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(38, 16);
            this.lbl_price.TabIndex = 13;
            this.lbl_price.Text = "Price";
            // 
            // lbl_markup
            // 
            this.lbl_markup.AutoSize = true;
            this.lbl_markup.Location = new System.Drawing.Point(265, 420);
            this.lbl_markup.Name = "lbl_markup";
            this.lbl_markup.Size = new System.Drawing.Size(52, 16);
            this.lbl_markup.TabIndex = 14;
            this.lbl_markup.Text = "Markup";
            // 
            // txtBox_cost
            // 
            this.txtBox_cost.Location = new System.Drawing.Point(12, 439);
            this.txtBox_cost.Name = "txtBox_cost";
            this.txtBox_cost.Size = new System.Drawing.Size(109, 22);
            this.txtBox_cost.TabIndex = 15;
            // 
            // txtBox_price
            // 
            this.txtBox_price.Location = new System.Drawing.Point(127, 439);
            this.txtBox_price.Name = "txtBox_price";
            this.txtBox_price.Size = new System.Drawing.Size(109, 22);
            this.txtBox_price.TabIndex = 16;
            // 
            // txtBox_markup
            // 
            this.txtBox_markup.Location = new System.Drawing.Point(268, 439);
            this.txtBox_markup.Name = "txtBox_markup";
            this.txtBox_markup.Size = new System.Drawing.Size(109, 22);
            this.txtBox_markup.TabIndex = 17;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(17, 482);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(104, 42);
            this.btn_cancel.TabIndex = 18;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(127, 482);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(104, 42);
            this.btn_clear.TabIndex = 19;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(268, 482);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(104, 42);
            this.btn_save.TabIndex = 20;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 536);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txtBox_markup);
            this.Controls.Add(this.txtBox_price);
            this.Controls.Add(this.txtBox_cost);
            this.Controls.Add(this.lbl_markup);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_cost);
            this.Controls.Add(this.check_active);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.grp_manufactured);
            this.Controls.Add(this.lbl_origin);
            this.Controls.Add(this.cmb_category);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.txtbox_description);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.txtbox_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txtBox_barcode);
            this.Controls.Add(this.lbl_barcode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_manufactured.ResumeLayout(false);
            this.grp_manufactured.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_barcode;
        private System.Windows.Forms.TextBox txtBox_barcode;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.TextBox txtbox_description;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.Label lbl_origin;
        private System.Windows.Forms.GroupBox grp_manufactured;
        private System.Windows.Forms.RadioButton radio_abroad;
        private System.Windows.Forms.RadioButton radio_local;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.CheckBox check_active;
        private System.Windows.Forms.Label lbl_cost;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_markup;
        private System.Windows.Forms.TextBox txtBox_cost;
        private System.Windows.Forms.TextBox txtBox_price;
        private System.Windows.Forms.TextBox txtBox_markup;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
    }
}

